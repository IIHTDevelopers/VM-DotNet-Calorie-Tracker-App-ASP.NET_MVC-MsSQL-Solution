using CalorieTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackerApp.DAL.Interface
{
    public interface ICalorieTrackerInterface 
    {
        IEnumerable<Calorie> GetCalories();
        Calorie GetCalorieByID(int CalorieId);
        Calorie InsertCalorie(Calorie Calorie);
        int DeleteCalorie(int CalorieId);
        bool UpdateCalorie(Calorie Calorie);
        void Save();
    }
}