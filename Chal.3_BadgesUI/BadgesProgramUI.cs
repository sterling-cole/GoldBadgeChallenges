using Chal._3_BadgesRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chal._3_BadgesUI
{
    public class BadgesProgramUI
    {
        List<string> doors = new List<string> { "A1", "A2", "A3" };
        Badges_Repo _repo = new Badges_Repo();

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
                Console.WriteLine("Welcome Security Admin, what would you like to do ?\n" +
                    "1. Add a badge.\n" +
                    "2. Edit a badge.\n" +
                    "3. List all badges.");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        
                        break;
                    default:
                        Console.WriteLine("Please enter a number.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void AddABadge()
        {
            

            Console.WriteLine("What is the badge number:" );
            //badges.Key = Console.ReadLine();
            Console.WriteLine("Which door would you like to access?");
           // badges.Values = Console.ReadLine();
        }
        public void ShowAllBadges()
        {
            Dictionary<int, List<string>> badges = _repo.GetAllBadges();
            Console.Clear();
            foreach (KeyValuePair<int, List<string>> bodge in badges)
            {
                
            }

        }
        private void DisplayBadge(Badges badges)
        {
            Console.WriteLine("Badge ID is ",  badges.BadgeID);
        }
        private void SeedContent()
        {
           Dictionary<int, List<string>> badges = _repo.GetAllBadges();
            badges.Add(1234, doors);
        }
    }
}
