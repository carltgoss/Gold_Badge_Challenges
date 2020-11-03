using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Green_Plan_Repository
{
    public class Cars
    {
        public int IdNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public Type Type { get; set; }

        public Cars() { }
        public Cars(int idNumber, string make, string model, int year, string color, Type type)
        {
            IdNumber = idNumber;
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Type = type;
        }
    }

    public enum Type
    {
        Gas = 1,
        Hybrid,
        Electric,
    }
}
