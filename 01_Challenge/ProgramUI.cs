using System;
using System.Collections.Generic;

namespace _01_Challenge
{
   class ProgramUI
    {
        //add a field to call on repository
        MenuRepo _menuRepo = new MenuRepo();


        public void Run()
        {
            ////set bool for while loop
            bool running = true;
            ///start while loop
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Hello Manager! What would you like to do?\n" +
                    "1. Add an item to the menu:\n" +
                    "2. Remove an item from the menu?\n" +
                    "3. Display the Menu:\n" +
                    "4. Exit"); 

                string input = Console.ReadLine();
                int choice = int.Parse(input);

                switch (choice)
                {
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        RemoveItem();
                        break;
                    case 3:
                        DisplayMenu();
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }

        private void RemoveItem()
        {
            Console.Clear();
            Console.WriteLine("These are the items available for removal. press enter, then you can select an item");
            PrintAllItems();
            Console.WriteLine("Please select an item from the list by its Menu Number:");
            int menuNumber = int.Parse(Console.ReadLine());
            _menuRepo.RemoveSpecificItemFromList(menuNumber);
            Console.WriteLine($"That item has been removed. press enter to return to the main menu.");
            Console.ReadKey();
        }

        private void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("To see a list of all menu items, press enter:");
            Console.ReadKey();
            PrintAllItems();
            Console.WriteLine("Press enter again to return to the main menu");
            Console.ReadKey();

        }

        private void AddItem()
        {
            // Meal #, Meal Name, Description, ingredient list, price
            MenuItems newItem = new MenuItems();

            Console.WriteLine("Lets add a new, delicious item to the menu! press enter to continue");
            Console.ReadKey();

            Console.WriteLine("Please give the new item a menu #:");
            newItem.ItemNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Now enter the name of the new Item:");
            newItem.ItemName = Console.ReadLine();

            Console.WriteLine("Please enter of description of the new item:");
            newItem.ItemDescription = Console.ReadLine();

            Console.WriteLine($"What ingredients do you use to make {newItem.ItemName}?");
            newItem.Ingredients = Console.ReadLine();

            Console.WriteLine("Finally, how much does the new item cost? (use 000.00 format)");
            newItem.ItemPrice = decimal.Parse(Console.ReadLine());

            _menuRepo.AddProductToMenu(newItem);
            Console.WriteLine("The item has been added to the menu. press enter to return to menu");
            Console.ReadKey();

        }
        private void PrintAllItems()
        {
            List<MenuItems> _menuList = _menuRepo.GetMenuList();

            foreach (MenuItems menuItem in _menuList)
            {
                Console.WriteLine($"{menuItem.ItemNumber} {menuItem.ItemName} {menuItem.ItemDescription} {menuItem.Ingredients} {menuItem.ItemPrice}");
            }
            Console.ReadKey();
        }
    }
}