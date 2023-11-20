using CalorieTrackerApp.DAL.Interface;
using CalorieTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CalorieTrackerApp.DAL.Repository
{
    public class CalorieTrackerRepository : ICalorieTrackerRepository
    {
        private CalorieTrackerDbContext _context;
        public CalorieTrackerRepository(CalorieTrackerDbContext Context)
        {
            this._context = Context;
        }
        public IEnumerable<Calorie> GetCalories()
        {
             return _context.Calories.ToList();
        }
        public Calorie GetCalorieByID(int id)
        {
            return _context.Calories.Find(id);
        }
        public Calorie InsertCalorie(Calorie Calorie)
        {
            return _context.Calories.Add(Calorie);
        }
        public int DeleteCalorie(int CalorieID)
        {
            Calorie Calorie = _context.Calories.Find(CalorieID);
            var res= _context.Calories.Remove(Calorie);
            return res.Id;
        }
        public bool UpdateCalorie(Calorie Calorie)
        {
            var res= _context.Entry(Calorie).State = EntityState.Modified;
            return res.Equals("Calorie");
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
