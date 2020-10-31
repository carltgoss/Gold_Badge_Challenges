using System;
using _01_Komodo_Cafe_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Komodo_Cafe_Tests
{
    [TestClass]
    public class MenuItemsTest
    {
        [TestMethod]
        public void MenuItems()
        {
            MenuItems meal = new MenuItems();

            meal.Name = "Cheeseburger";

            Assert.AreEqual(meal.Name, "Cheeseburger");
        }
    }
}
