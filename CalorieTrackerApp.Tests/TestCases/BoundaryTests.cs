
using CalorieTrackerApp.DAL;
using CalorieTrackerApp.DAL.Interface;
using CalorieTrackerApp.DAL.Repository;
using CalorieTrackerApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CalorieTrackerApp.Tests.TestCases
{
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly ICalorieTrackerInterface _calorieTrackerService;
        public readonly Mock<ICalorieTrackerRepository> calorietrackerservice = new Mock<ICalorieTrackerRepository>();
        private readonly Calorie _Calorie;
        private readonly IEnumerable<Calorie> CalorieList;

        private static string type = "Boundary";

        public BoundaryTests(ITestOutputHelper output)
        {
            _calorieTrackerService = new CalorieTrackerService(calorietrackerservice.Object);
            _output = output;
            _Calorie = new Calorie
            {
                 Id = 1,
                Date = DateTime.Now,
                CalorieName = "Exercise",
                IsCompleted = true,
                Notes = "30 minutes of jogging in the park."
            };
            CalorieList = new List<Calorie>
        {
            new Calorie
            {
                Id = 1,
                Date = DateTime.Now,
                CalorieName = "Exercise",
                IsCompleted = true,
                Notes = "30 minutes of jogging in the park."
            },
            new Calorie
            {
                Id = 2,
                Date = DateTime.Now,
                CalorieName = "Exercise",
                IsCompleted = true,
                Notes = "30 minutes of jogging in the park."
            },
        };

        }

        [Fact]
        public async Task<bool> Testfor_Id_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                calorietrackerservice.Setup(repos => repos.GetCalorieByID(_Calorie.Id)).Returns(_Calorie);
                var result = _calorieTrackerService.GetCalorieByID(_Calorie.Id);

                //Assertion
                if (result!= null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Date_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                calorietrackerservice.Setup(repos => repos.GetCalorieByID(_Calorie.Id)).Returns(_Calorie);
                var result = _calorieTrackerService.GetCalorieByID(_Calorie.Id);

                //Assertion
                if (result!= null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_CalorieName_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                calorietrackerservice.Setup(repos => repos.GetCalorieByID(_Calorie.Id)).Returns(_Calorie);
                var result = _calorieTrackerService.GetCalorieByID(_Calorie.Id);

                //Assertion
                if (result!=null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_IsCompleted_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                calorietrackerservice.Setup(repos => repos.GetCalorieByID(_Calorie.Id)).Returns(_Calorie);
                var result = _calorieTrackerService.GetCalorieByID(_Calorie.Id);
               

                //Assertion
                if (result!= null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Notes_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                calorietrackerservice.Setup(repos => repos.GetCalorieByID(_Calorie.Id)).Returns(_Calorie);
                var result = _calorieTrackerService.GetCalorieByID(_Calorie.Id);


                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}