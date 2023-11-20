using CalorieTrackerApp.DAL.Interface;
using CalorieTrackerApp.DAL.Repository;
using System.Web.Mvc; // Use System.Web.Mvc instead of System.Web.Http
using System.Web.Routing;
using Unity;
using Unity.AspNet.Mvc; // Use Unity.AspNet.Mvc for MVC

namespace CalorieTrackerApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "CalorieTracker", action = "Index", id = UrlParameter.Optional }
            );

            var container = new UnityContainer();

            // Register your dependencies, including ICalorieTrackerInterface
            container.RegisterType<ICalorieTrackerInterface, CalorieTrackerService>();
            container.RegisterType<ICalorieTrackerRepository, CalorieTrackerRepository>();

            // Set the dependency resolver for MVC
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
