using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Komodo_Cafe_Repository
{
    public class MenuItems_repo
    {
        private List<MenuItems> _menuItems = new List<MenuItems>();

        public bool AddToMenu(MenuItems meal)
        {
            int startingCount = _menuItems.Count;

            _menuItems.Add(meal);

            bool wasAdded = (_menuItems.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public List<MenuItems> GetItems()
        {
            return _menuItems;
        }

        public MenuItems GetItemByName(string name)
        {
            foreach (MenuItems meal in _menuItems)
            {
                if (meal.Name.ToLower() == name.ToLower())
                {
                    return meal;
                }
            }
            return null;
        }
        
        public bool DeleteItemsFromMenu(MenuItems existingMeal)
        {
            bool wasDeleted = _menuItems.Remove(existingMeal);
            return wasDeleted;
        }
    }
}
