
using CalorieTrackerApp.Models;
using System.Data.Entity;

namespace CalorieTrackerApp.DAL
{
    public class CalorieTrackerDbContext : DbContext
    {
        public CalorieTrackerDbContext()
            : base("name=CalorieTrackerConnectionString")
        {
        }
        public DbSet<Calorie> Calories { get; set; }
    }
}