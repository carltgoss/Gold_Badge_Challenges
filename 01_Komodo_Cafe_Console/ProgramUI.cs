using _01_Komodo_Cafe_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Komodo_Cafe_Console
{
    class ProgramUI
    {
        private MenuItems_repo _menuItems = new MenuItems_repo();
        public void MainMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {

                Console.Clear();

                Console.WriteLine("Enter the number of the option you would like to select:\n" +
                    "1. Add items to the menu.\n" +
                    "2. Delete items from the menu.\n" +
                    "3. See all items on the menu.\n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddItemsToMenu();
                        break;
                    case "2":
                        DeleteItemsFromMenu();
                        break;
                    case "3":
                        SeeAllItems();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void AddItemsToMenu()
        {
            Console.Clear();

            MenuItems newMeal = new MenuItems();

            Console.WriteLine("Please add a meal number.");
            string menuNuberAsString = Console.ReadLine();
            int menuNumberAsInt = int.Parse(menuNuberAsString);
            newMeal.MenuNumber = menuNumberAsInt;

            Console.WriteLine("Please add a name.");
            newMeal.Name = Console.ReadLine();

            Console.WriteLine("Please add a description.");
            newMeal.Description = Console.ReadLine();

            Console.WriteLine("Please list the ingredients.");
            newMeal.Ingredients = Console.ReadLine();

            Console.WriteLine("Please add the price.");
            string priceAsString = Console.ReadLine();
            double priceAsDouble = double.Parse(priceAsString);
            newMeal.Price = priceAsDouble;

            bool wasAdded = _menuItems.AddToMenu(newMeal);
            if (wasAdded == true)
            {
                Console.WriteLine("New meal successfully added to the menu.");
            }
            else
            {
                Console.WriteLine("Failed to add meal to the menu.");
            }
            Console.ReadLine();
        }

        private void DeleteItemsFromMenu()
        {
            SeeAllItems();
            Console.WriteLine("Please select the name of the meal you want to delete.");
            string nameToDelete = Console.ReadLine();

            MenuItems mealToDelete = _menuItems.GetItemByName(nameToDelete);
            bool wasDeleted = _menuItems.DeleteItemsFromMenu(mealToDelete);

            if (wasDeleted)
            {
                Console.WriteLine("Meal successfully deleted from the menu.");
            }
            else
            {
                Console.WriteLine("Unable to delete meal.");
            }
            Console.ReadLine();
        }

        private void SeeAllItems()
        {
            Console.Clear();

            List<MenuItems> menuList = _menuItems.GetItems();

            foreach (MenuItems meal in menuList)
            {
                DisplayItems(meal);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private void DisplayItems(MenuItems meal)
        {
            Console.WriteLine($"Menu Number: {meal.MenuNumber}");
            Console.WriteLine($"Name: {meal.Name}");
            Console.WriteLine($"Description: {meal.Description}");
            Console.WriteLine($"Ingredients: {meal.Ingredients}");
            Console.WriteLine($"Price: ${meal.Price}");

        }
    }
}
