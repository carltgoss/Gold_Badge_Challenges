using System;
using System.Collections.Generic;
using _06_Green_Plan_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Type = _06_Green_Plan_Repository.Type;

namespace _06_Green_Plan_Tests
{
    [TestClass]
    public class Cars_Repo_Tests
    {
        [TestMethod]
        public void AddGasCarShouldReturnCorrectBoolean()
        {
            Cars car = new Cars();
            Cars_Repo repo = new Cars_Repo();

            bool wasAdded = repo.AddGasCar(car);

            Assert.IsTrue(wasAdded);
        }

        [TestMethod]
        public void GetGasListShouldRetunCorrectList()
        {
            Cars car = new Cars();
            Cars_Repo repo = new Cars_Repo();

            repo.AddGasCar(car);

            List<Cars> carList = repo.GetGasList();
            bool gasList = carList.Contains(car);

            Assert.IsTrue(gasList);
        }

        [TestMethod]
        public void GetGasIdShouldRetunCorrectCar()
        {
            Cars car = new Cars(1, "Ford", "Mustang", 2005, "Blue", Type.Gas);
            Cars_Repo repo = new Cars_Repo();
            repo.AddGasCar(car);
            int idNumber = 1;

            Cars searchResult = repo.GetGasID(idNumber);

            Assert.AreEqual(searchResult.IdNumber, idNumber);
        }

        [TestMethod]
        public void UpdateGasCarShouldRetunTrue()
        {
            Cars car = new Cars(1, "Ford", "Mustang", 2005, "Blue", Type.Gas);
            Cars_Repo repo = new Cars_Repo();
            repo.AddGasCar(car);

            Cars newCar = new Cars(5, "Ford", "Mustang", 2005, "Blue", Type.Gas);

            bool updateResult = repo.UpdateGasCar(car.IdNumber, newCar);

            Assert.IsTrue(updateResult);
        }
    }
}
