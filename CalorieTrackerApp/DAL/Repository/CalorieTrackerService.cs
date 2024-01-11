using CalorieTrackerApp.DAL.Interface;
using CalorieTrackerApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CalorieTrackerApp.DAL.Repository
{
    public class CalorieTrackerService : ICalorieTrackerInterface
    {
        private ICalorieTrackerRepository _repo;
        public CalorieTrackerService(ICalorieTrackerRepository repo)
        {
            this._repo = repo;
        }

        public int DeleteCalorie(int CalorieId)
        {
            var res= _repo.DeleteCalorie(CalorieId);
            return res;
        }

        public Calorie GetCalorieByID(int CalorieId)
        {
            return _repo.GetCalorieByID(CalorieId);
        }
        public void Save()
        {
            _repo.Save();
        }


        IEnumerable<Calorie> ICalorieTrackerInterface.GetCalories()
        {
            return _repo.GetCalories();
        }

        Calorie ICalorieTrackerInterface.InsertCalorie(Calorie Calorie)
        {
            return _repo.InsertCalorie(Calorie);
        }

        bool ICalorieTrackerInterface.UpdateCalorie(Calorie Calorie)
        {
            return _repo.UpdateCalorie(Calorie);
        }
    }
}