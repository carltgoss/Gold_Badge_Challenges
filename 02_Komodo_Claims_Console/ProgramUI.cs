using _02_Komodo_Claims_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace _02_Komodo_Claims_Console
{
    class ProgramUI
    {
        private Claims_Repo _repo = new Claims_Repo();
        public void MainMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();

                Console.WriteLine("Enter the number of the options you'd like to select:\n" +
                    "1. See all claims\n" +
                    "2. Take Care of next claim\n" +
                    "3. Enter a new claim\n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        TakeCareOfNextClaim();
                        break;
                    case "3":
                        AddNewClaim();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please input a valid option.");
                        break;
                }
            }
        }

        private void SeeAllClaims()
        {
            Console.Clear();

            Queue<Claims> allClaims = _repo.GetClaims();
            foreach(var claim in allClaims)
            {
                Console.Write(claim);
            }
            Console.ReadLine();

        }

        private void TakeCareOfNextClaim()
        {
            Console.Clear();

            Queue<Claims> claimsQueue = new Queue<Claims>();

        }

        private void AddNewClaim()
        {
            Console.Clear();

            Claims newClaim = new Claims();

            Console.WriteLine("Please enter a ClaimID.");
            string idAsAString = Console.ReadLine();
            int idAsAInt = int.Parse(idAsAString);
            newClaim.ClaimID = idAsAInt;

            Console.WriteLine("Please enter a claim type. (Car, Home, Theft, etc)");
            newClaim.ClaimType = Console.ReadLine();

            Console.WriteLine("Please enter a description of the incident.");
            newClaim.Description = Console.ReadLine();

            Console.WriteLine("Please enter the claim amount. (400, 250, 1000, etc)");
            string amountAsString = Console.ReadLine();
            double amountAsDouble = double.Parse(amountAsString);
            newClaim.ClaimAmount = amountAsDouble;

            Console.WriteLine("Please enter the date of the incident. (Jan 1, 2020)");
            string dateIncidentAsString = Console.ReadLine();
            var parsedIncidentDate = DateTime.Parse(dateIncidentAsString);
            newClaim.DateOfIncident = parsedIncidentDate;

            Console.WriteLine("Please enter the date of the claim. (Jan 1, 2020)");
            string dateClaimAsString = Console.ReadLine();
            var parsedClaimDate = DateTime.Parse(dateClaimAsString);
            newClaim.DateOfClaim = parsedClaimDate;

            bool wasAdded = _repo.AddClaimsToQueue(newClaim);
            if(wasAdded == true)
            {
                Console.WriteLine("Your claim was successfully added.");
            }
            else
            {
                Console.WriteLine("Unable to add claim.");
            }

            Console.ReadLine();
        }
    }
}
