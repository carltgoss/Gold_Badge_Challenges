using System;
using _01_Komodo_Cafe_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Komodo_Cafe_Tests
{
    [TestClass]
    public class MenuItems_Repo_Test
    {
        [TestMethod]
        public void AddToMenuShouldGetCorrectBoolean()
        {
            MenuItems meal = new MenuItems();
            MenuItems_repo repository = new MenuItems_repo();

            bool addResult = repository.AddToMenu(meal);
            Assert.IsTrue(addResult);
        }
    }
}
