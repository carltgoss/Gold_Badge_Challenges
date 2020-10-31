using _06_Green_Plan_Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = _06_Green_Plan_Repository.Type;

namespace _06_Green_Plan_Console
{
    public class ProgramUI
    {
        private Cars_Repo _repo = new Cars_Repo();
        public void MainMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {

            Console.Clear();

            Console.WriteLine("Enter the number of the option you want to select.\n" +
                "1. Add a new car.\n" + 
                "2. Update a car.\n" +
                "3. Car directory.\n" +
                "4. Exit.");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddNewCar();
                        break;
                    case "2":
                        UpdateACar();
                        break;
                    case "3":
                        CarDirectory();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Select a valid option.");
                        break;
                }
            }
        }

        private void AddNewCar()
        {
            Console.Clear();

            Cars newCar = new Cars();

            Console.WriteLine("Enter the Id number.");
            string idAsString = Console.ReadLine();
            int idAsInt = int.Parse(idAsString);
            newCar.IdNumber = idAsInt;

            Console.WriteLine("Enter the make of the car.");
            newCar.Make = Console.ReadLine();

            Console.WriteLine("Enter the model of the car.");
            newCar.Model = Console.ReadLine();

            Console.WriteLine("Enter the year of the car.");
            string yearAsString = Console.ReadLine();
            int yearAsInt = int.Parse(yearAsString);
            newCar.Year = yearAsInt;

            Console.WriteLine("Enter the color of the car.");
            newCar.Color = Console.ReadLine();

            Console.WriteLine("Select the type of car.");
            Console.WriteLine("1. Gas");
            Console.WriteLine("2. Hybrid");
            Console.WriteLine("3. Electric");

            string typeAsString = Console.ReadLine();
            int typeAsInt = int.Parse(typeAsString);
            newCar.Type = (Type)typeAsInt;
            if(typeAsInt == 1)
            {
                _repo.AddGasCar(newCar);
            }
            else if(typeAsInt == 2)
            {
                _repo.AddHybridCar(newCar);
            }
            else if(typeAsInt == 3)
            {
                _repo.AddElectricCar(newCar);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }

        private void UpdateACar()
        {
            Console.Clear();

            Console.WriteLine("Select a car type:\n" +
                "1. Gas\n" +
                "2. Hybrid\n" +
                "3. Electric\n" +
                "4. Go back");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    UpdateGasCar();
                    break;
                case "2":
                    UpdateHybridCar();
                    break;
                case "3":
                    UpdateElectricCar();
                    break;
                case "4":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;

            }
        }

        private void UpdateGasCar()
        {
            Console.Clear();

            Console.WriteLine("Enter the car Id number.");
            string idAsString = Console.ReadLine();
            int idAsInt = int.Parse(idAsString);
            Cars oldCar = _repo.GetGasID(idAsInt);

            if(oldCar == null)
            {
                Console.WriteLine("Car was not found.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }

            Cars updateCar = new Cars(
                oldCar.IdNumber,
                oldCar.Make,
                oldCar.Model,
                oldCar.Year,
                oldCar.Color,
                oldCar.Type
                );

            Console.Clear();

            DisplayCars(oldCar);

            Console.WriteLine("Enter new Id number.");
            string newIdAsString = Console.ReadLine();
            int newIdAsInt = int.Parse(newIdAsString);
            updateCar.IdNumber = newIdAsInt;

            Console.WriteLine("Enter the make of the car.");
            updateCar.Make = Console.ReadLine();

            Console.WriteLine("Enter the model of the car.");
            updateCar.Model = Console.ReadLine();

            Console.WriteLine("Enter the year of the car.");
            string yearAsString = Console.ReadLine();
            int yearAsint = int.Parse(yearAsString);
            updateCar.Year = yearAsint;

            Console.WriteLine("Enter the color of the car.");
            updateCar.Color = Console.ReadLine();

            Console.WriteLine("Select the type of car.");
            Console.WriteLine("1. Gas");
            Console.WriteLine("2. Hybrid");
            Console.WriteLine("3. Electric");

            string typeAsString = Console.ReadLine();
            int typeAsInt = int.Parse(typeAsString);
            updateCar.Type = (Type)typeAsInt;
            if (typeAsInt == 1)
            {
                _repo.AddGasCar(updateCar);
            }
            else if (typeAsInt == 2)
            {
                _repo.AddHybridCar(updateCar);
            }
            else if (typeAsInt == 3)
            {
                _repo.AddElectricCar(updateCar);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            bool wasSuccessfull = _repo.UpdateGasCar(idAsInt, oldCar);
            if (wasSuccessfull)
            {
                Console.WriteLine("Car successfully updated.");
            }
            else
            {
                Console.WriteLine("Unable to update.");
            }
        }

        private void UpdateHybridCar()
        {
            Console.Clear();

            Console.WriteLine("Enter the car Id number.");
            string idAsString = Console.ReadLine();
            int idAsInt = int.Parse(idAsString);
            Cars oldCar = _repo.GetHybridID(idAsInt);

            if (oldCar == null)
            {
                Console.WriteLine("Car was not found.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }

            Cars updateCar = new Cars(
                oldCar.IdNumber,
                oldCar.Make,
                oldCar.Model,
                oldCar.Year,
                oldCar.Color,
                oldCar.Type
                );

            Console.Clear();

            DisplayCars(oldCar);

            Console.WriteLine("Enter new Id number.");
            string newIdAsString = Console.ReadLine();
            int newIdAsInt = int.Parse(newIdAsString);
            updateCar.IdNumber = newIdAsInt;

            Console.WriteLine("Enter the make of the car.");
            updateCar.Make = Console.ReadLine();

            Console.WriteLine("Enter the model of the car.");
            updateCar.Model = Console.ReadLine();

            Console.WriteLine("Enter the year of the car.");
            string yearAsString = Console.ReadLine();
            int yearAsint = int.Parse(yearAsString);
            updateCar.Year = yearAsint;

            Console.WriteLine("Enter the color of the car.");
            updateCar.Color = Console.ReadLine();

            Console.WriteLine("Select the type of car.");
            Console.WriteLine("1. Gas");
            Console.WriteLine("2. Hybrid");
            Console.WriteLine("3. Electric");

            string typeAsString = Console.ReadLine();
            int typeAsInt = int.Parse(typeAsString);
            updateCar.Type = (Type)typeAsInt;
            if (typeAsInt == 1)
            {
                _repo.AddGasCar(updateCar);
            }
            else if (typeAsInt == 2)
            {
                _repo.AddHybridCar(updateCar);
            }
            else if (typeAsInt == 3)
            {
                _repo.AddElectricCar(updateCar);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            bool wasSuccessfull = _repo.UpdateHybridCar(idAsInt, oldCar);
            if (wasSuccessfull)
            {
                Console.WriteLine("Car successfully updated.");
            }
            else
            {
                Console.WriteLine("Unable to update.");
            }
        }

        private void UpdateElectricCar()
        {
            Console.Clear();

            Console.WriteLine("Enter the car Id number.");
            string idAsString = Console.ReadLine();
            int idAsInt = int.Parse(idAsString);
            Cars oldCar = _repo.GetElectricID(idAsInt);

            if (oldCar == null)
            {
                Console.WriteLine("Car was not found.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }

            Cars updateCar = new Cars(
                oldCar.IdNumber,
                oldCar.Make,
                oldCar.Model,
                oldCar.Year,
                oldCar.Color,
                oldCar.Type
                );

            Console.Clear();

            DisplayCars(oldCar);

            Console.WriteLine("Enter new Id number.");
            string newIdAsString = Console.ReadLine();
            int newIdAsInt = int.Parse(newIdAsString);
            updateCar.IdNumber = newIdAsInt;

            Console.WriteLine("Enter the make of the car.");
            updateCar.Make = Console.ReadLine();

            Console.WriteLine("Enter the model of the car.");
            updateCar.Model = Console.ReadLine();

            Console.WriteLine("Enter the year of the car.");
            string yearAsString = Console.ReadLine();
            int yearAsint = int.Parse(yearAsString);
            updateCar.Year = yearAsint;

            Console.WriteLine("Enter the color of the car.");
            updateCar.Color = Console.ReadLine();

            Console.WriteLine("Select the type of car.");
            Console.WriteLine("1. Gas");
            Console.WriteLine("2. Hybrid");
            Console.WriteLine("3. Electric");

            string typeAsString = Console.ReadLine();
            int typeAsInt = int.Parse(typeAsString);
            updateCar.Type = (Type)typeAsInt;
            if (typeAsInt == 1)
            {
                _repo.AddGasCar(updateCar);
            }
            else if (typeAsInt == 2)
            {
                _repo.AddHybridCar(updateCar);
            }
            else if (typeAsInt == 3)
            {
                _repo.AddElectricCar(updateCar);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            bool wasSuccessfull = _repo.UpdateElectricCar(idAsInt, oldCar);
            if (wasSuccessfull)
            {
                Console.WriteLine("Car successfully updated.");
            }
            else
            {
                Console.WriteLine("Unable to update.");
            }
        }

        private void CarDirectory()
        {
            Console.Clear();

            Console.WriteLine("Select a car type:\n" +
                "1. Gas\n" +
                "2. Hybrid\n" +
                "3. Electric\n" +
                "4. Go back");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    GasCarList();
                    break;
                case "2":
                    HybridCarList();
                    break;
                case "3":
                    ElectricCarList();
                    break;
                case "4":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;

            }
        }

        private void GasCarList()
        {
            Console.Clear();

            List<Cars> gasCarList = _repo.GetGasList();

            foreach( Cars car in gasCarList)
            {
                DisplayCars(car);
            }
            Console.ReadKey();
        }
        private void HybridCarList()
        {
            Console.Clear();

            List<Cars> hybridCarList = _repo.GetHybridList();

            foreach (Cars car in hybridCarList)
            {
                DisplayCars(car);
            }
            Console.ReadLine();
        }
        private void ElectricCarList()
        {
            Console.Clear();

            List<Cars> electricCarList = _repo.GetElectricList();

            foreach (Cars car in electricCarList)
            {
                DisplayCars(car);
            }
            Console.ReadLine();
        }

        private void DisplayCars(Cars car)
        {
            Console.WriteLine($"Make: {car.Make}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Year: {car.Year}");
            Console.WriteLine($"Color: {car.Color}");
            Console.WriteLine($"Type: {car.Type}");
        }
    }
}
