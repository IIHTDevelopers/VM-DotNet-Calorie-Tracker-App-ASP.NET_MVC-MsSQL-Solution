using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalorieTrackerApp.Models
{
    public class Calorie
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string CalorieName { get; set; }
        public bool IsCompleted { get; set; }
        public string Notes { get; set; }
    }

}