using CalorieTrackerApp.DAL.Interface;
using CalorieTrackerApp.DAL.Repository;
using CalorieTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CalorieTrackerApp.Controllers
{
    public class CalorieTrackerController : Controller
    {
        private readonly ICalorieTrackerInterface _Repository;
        public CalorieTrackerController(ICalorieTrackerInterface service)
        {
            _Repository = service;
        }
        public CalorieTrackerController()
        {
            // Constructor logic, if needed
        }
        // GET: CalorieTracker
        public ActionResult Index()
        {
            var Calories = from work in _Repository.GetCalories()
                        select work;
            return View(Calories);
        }

        public ViewResult Details(int id)
        {
            Calorie Calorie =   _Repository.GetCalorieByID(id);
            return View(Calorie);
        }

        public ActionResult Create()
        {
            return View(new Calorie());
        }

        [HttpPost]
        public ActionResult Create(Calorie Calorie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Repository.InsertCalorie(Calorie);
                    _Repository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(Calorie);
        }

        public ActionResult EditAsync(int id)
        {
            Calorie Calorie =  _Repository.GetCalorieByID(id);
            return View(Calorie);
        }
        [HttpPost]
        public ActionResult Edit(Calorie Calorie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Repository.UpdateCalorie(Calorie);
                    _Repository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(Calorie);
        }

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Unable to save changes. Try again, and if the problem persists see your system administrator.";
            }
            Calorie Calorie =  _Repository.GetCalorieByID(id);
            return View(Calorie);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Calorie Calorie =  _Repository.GetCalorieByID(id);
                _Repository.DeleteCalorie(id);
                _Repository.Save();
            }
            catch (DataException)
            {
                return RedirectToAction("Delete",
                   new System.Web.Routing.RouteValueDictionary {
        { "id", id },
        { "saveChangesError", true } });
            }
            return RedirectToAction("Index");
        }
    }
}