using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Komodo_Cafe_Repository
{
    public class MenuItems
    {
        public int MenuNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        public MenuItems() { }
        public MenuItems(int menuNumber, string name, string description, string ingredients, double price)
        {
            MenuNumber = menuNumber;
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }
    }
}
