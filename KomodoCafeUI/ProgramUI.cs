using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoRepository;

namespace KomodoCafeUI
{
    public class ProgramUI
    {
        private readonly MenuItem_Repo _repository = new MenuItem_Repo();

        public void Run()
        {
            SeedContent();
            Runmenu();
            
        }

        public void Runmenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Komodo App.\n" +
                    "1.Show all menu items.\n" +
                    "2. Add a new item.\n" +
                    "3. Remove an item\n" +
                    "4. exit\n");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAllItems();
                        break;
                    case "2":
                        CreateNewItem();
                        break;
                    case "3":
                        RemoveItemFromList();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a number");
                        Console.ReadKey();
                        break;
                }
            }
        }


        private void CreateNewItem()
        {
            Console.Clear();
            MenuItem item = new MenuItem();
            Console.WriteLine("Enter a Meal Number");
            item.MealNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Meal Name.");
            item.MealName = Console.ReadLine();

            Console.WriteLine("Enter a Description");
            item.MealDescription =  Console.ReadLine();

            Console.WriteLine("Enter ingredients");
            item.Ingredients = Console.ReadLine();

            Console.WriteLine("Enter a Price");
            item.Price = double.Parse(Console.ReadLine());
            _repository.AddItemToMenuDirectory(item);
        }
        private void RemoveItemFromList()
        {

        Console.Clear();
        Console.WriteLine( "Which item would you like to remove" );
            List<MenuItem> itemsInList = _repository.GetItems();
            int count = 0;
            foreach(MenuItem item in itemsInList)
            {
                count++;
                Console.WriteLine($"{count}. {item.MealName}");
            }
            int targetItemName = int.Parse(Console.ReadLine());
            int targetIndex = targetItemName - 1;
            if (targetIndex >= 0 && targetIndex < itemsInList.Count())
            {
                MenuItem desiredItem = itemsInList[targetIndex];
                if (_repository.DeleteItem(desiredItem.MealName)) 
                {
                    Console.WriteLine($"{desiredItem.MealName} has been removed.");
                }
                else
                {
                    Console.WriteLine("I'm sorry, I can't do that.");
                }
            }
            else
            {
                Console.WriteLine("No item has that name");
            }
            Console.ReadKey();
        }
        private void ShowAllItems()
        {
            Console.Clear();
            List<MenuItem> listOfItems = _repository.GetItems();
            foreach (MenuItem item in listOfItems)
            {
                DisplayItem(item);
            }
            Console.ReadKey();
        }
        private void DisplayItem(MenuItem item)
        {
            Console.WriteLine($"Meal Number: {item.MealNumber}\n" +
                $"Meal Name: {item.MealName}\n" +
                $"Meal Description: {item.MealDescription}\n" +
                $"Ingredients: {item.Ingredients}\n" +
                $"Price: {item.Price}\n");
        }
        private void SeedContent()
        {
            MenuItem burger = new MenuItem( 1,  "haumburger",  "Meiat",  "The best",  3.50);
            _repository.AddItemToMenuDirectory(burger);
        }
        
    }
}
