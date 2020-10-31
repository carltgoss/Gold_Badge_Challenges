using _04_Komodo_Outings_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Komodo_Outings_Console
{
    public class ProgramUI
    {
        private Outings_Repo _repo = new Outings_Repo();
        public void MainMenu()
        {
            bool continueToRun = true;

            while (continueToRun)
            {
                Console.Clear();

                Console.WriteLine("Enter the number of the option you'd like to select.\n" +
                    "1. Display all outings.\n " +
                    "2. Add outings.\n" +
                    "3. Calculations.\n" +
                    "4. Exit.");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DisplayAllOutings();
                        break;
                    case "2":
                        AddOutings();
                        break;
                    case "3":
                        Calculations();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option.");
                        break;
                }
            }
        }

        private void DisplayAllOutings()
        {
            Console.Clear();

            List<Outings> listOfOutings = _repo.GetOutings();

            foreach (Outings outing in listOfOutings)
            {
                DisplayContent(outing);
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        private void AddOutings()
        {
            Console.Clear();

            Outings newOuting = new Outings();

            Console.WriteLine("Select an event type.");
            Console.WriteLine("1. Golf");
            Console.WriteLine("2. Bowling");
            Console.WriteLine("3. Amusement Park");
            Console.WriteLine("4. Concert");

            string inputAsString = Console.ReadLine();
            int inputAsInt = int.Parse(inputAsString);

            newOuting.EventType = (EventType)inputAsInt;

            Console.WriteLine("Enter the number of People that attended.");
            string peopleAsString = Console.ReadLine();
            int peopleAsInt = int.Parse(peopleAsString);
            newOuting.PeopleAttended = peopleAsInt;

            Console.WriteLine("Enter the date of the event. (Jan 1, 2020)";
            string dateAsString = Console.ReadLine();
            var date = DateTime.Parse(dateAsString);
            newOuting.Date = date;

            Console.WriteLine("Enter the cost per person");
            string personCostAsString = Console.ReadLine();
            double personCost = double.Parse(personCostAsString);
            newOuting.CostPerPerson = personCost;

            Console.WriteLine("Enter the cost of the event.");
            string eventCostAsString = Console.ReadLine();
            double eventCost = double.Parse(eventCostAsString);
            newOuting.EventCost = eventCost;


            bool wasAdded = _repo.AddOutingsToList(newOuting);
            if (wasAdded == true)
            {
                Console.WriteLine("Outing was successfully added to the List.");
            }
            else
            {
                Console.WriteLine("Unable to add outing to the list.");
            }

            Console.ReadLine();



        }
        private void Calculations()
        {
            Console.Clear();

            bool continueToRun = true;
            while (continueToRun)
            {

                Console.WriteLine("Select an option:\n" +
                    "1. Cost of all outings combined.\n" +
                    "2. Cost of outings by type.\n" +
                    "3. Go back.");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CostOfAllOutings();
                        break;
                    case "2":
                        SelectTypeMenu();
                        break;
                    case "3":
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        break;
                }
            }

        }

        private void SelectTypeMenu()
        {

        }

        private void DisplayContent(Outings outing)
        {
            Console.WriteLine($"Event type: {outing.EventType}");
            Console.WriteLine($"People Attended: {outing.PeopleAttended}");
            Console.WriteLine($"Date: {outing.Date}");
            Console.WriteLine($"Cost per person: ${outing.CostPerPerson}");
            Console.WriteLine($"Event cost: ${outing.EventCost}");
        }

        private void CostOfAllOutings()
        {
            
        }
    }
}

