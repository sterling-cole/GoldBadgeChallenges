using Chal._2_ClaimsRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chal._2_ClaimsUI
{
    public class Claims_ProgramUI
    {
        private readonly Claims_Repo _repo = new Claims_Repo();
        public void Run()
        {
            SeedContent();
            RunMenu();
        }

        public void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Komodo Insurance Claims App.\n" +
                    "1.Show all current claims.\n" +
                    "2. Take care of next claim.\n" +
                    "3. Enter a new claim.\n" +
                    "4. exit\n");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAllClaims();
                        break;
                    case "2":
                        //ShowNewClaim();
                        break;
                    case "3":
                        EnterNewClaim();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void ShowAllClaims()
        {
            Console.Clear();
            List<Claim> listOfClaims = _repo.GetClaims();
            foreach (Claim claim in listOfClaims)
            {
                DisplayClaim(claim);
            }
            Console.ReadKey();
        }
        private void ShowNewClaim(Claim claim)
        {
            Console.Clear();
            List<Claim> listOfClaims = _repo.GetClaims();
            for (int i = 0; i < listOfClaims.Count; i++) 
            {
                DisplayClaim(claim);
                Console.WriteLine("Would you like to work this claim? y/n");
                ConsoleKeyInfo cki = Console.ReadKey();

                if (cki.Key.ToString() == "y")
                {
                    DisplayClaim(claim);
                }
                else
                {
                    RunMenu();
                }
            }
            

        }
        private void DisplayClaim(Claim claim)
        {
            
            Console.WriteLine($"Claim ID:{claim.ClaimID}\n" +
                  $"Claim Type:{claim.ClaimType}\n" +
                $"Claim Description:{claim.ClaimDescription}\n" +
                $"Claim Amount:{claim.ClaimAmount}\n" +
                $"Date of Incident:{claim.DateOfAccident}\n");
        }
        private void EnterNewClaim()
        {
            Console.Clear();
            Claim claim = new Claim();
            Console.WriteLine("Enter a claim ID");
            claim.ClaimID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a claim type \n" + 
                "1. Car\n " +
                "2. Home\n "+
                "3. Theft\n ");
            string claimString = Console.ReadLine();
            int claimTypeId = int.Parse(claimString);
            claim.ClaimType = (ClaimType)claimTypeId;

            Console.WriteLine("Enter a description");
            claim.ClaimDescription = Console.ReadLine();

            Console.WriteLine("Enter the amount of damage");
            claim.ClaimAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter date of the accident");
            claim.DateOfAccident = Console.ReadLine();
            _repo.AddClaimToRepo(claim);



            
        }

        private void SeedContent()
        {
            Claim newClaim = new Claim(1, ClaimType.Car, "Car accident on 465.", 400.00, "4 / 25 / 18");
            _repo.AddClaimToRepo(newClaim);
            Claim newClaim2 = new Claim(2, ClaimType.Home, "House fire in kitchen", 4000.00, "4 / 11 / 18");
            _repo.AddClaimToRepo(newClaim2);
        }
    }
}
