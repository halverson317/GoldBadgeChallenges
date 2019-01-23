using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{
    public class _05_ProgramUI
    {

        Customer _customer = new Customer();
        CustRepo _custRepo = new CustRepo();
        
        

        public void Run()
        {
            ////set bool for while loop
            bool running = true;
            ///start while loop
            while (running)
            {
                Console.Clear();
                Console.WriteLine("KOMODO INSURANCE \n" +
                    "Please selecting from the following:\n" +
                    "1. Add Customer:\n" +
                    "2. Delete Customer:\n" +
                    "3. Update Customer:\n" +
                    "4. View Customers and which email they will recieve:\n" +
                    "5. Exit");

                int choice = ParseInput();

                switch (choice)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        RemoveCustomer();
                        break;
                    case 3:
                        UpdateCustomer();
                        break;
                    case 4:
                        DisplayCustomerList();
                        break;
                    case 5:
                        running = false;
                        break;
                }
            }
        }




        //Display and PrintList MEthods//
        private void DisplayCustomerList()
        {
            {
                Console.Clear();
                Console.WriteLine("To see a view a lis of all customers, press enter:");
                Console.ReadKey();
                PrintAllItems();
                Console.WriteLine("Press enter again to return to the main menu");
                Console.ReadKey();

            }
        }

        private void PrintAllItems()
        {
            List<Customer> _customerList = _custRepo.ListCustomers();

            var sortedList = _customerList.OrderBy(x => x.LName).ThenBy(x => x.FName).ToList();


            // Evaluate our query.
            foreach (Customer customer in sortedList)
            {
                Console.WriteLine($"First Name: {customer.FName}\n" +
                    $"Last Name: {customer.LName}\n" +
                    $"Type: {customer.CustType}\n" +
                    $"Email: {customer.EmailText}\n" +
                    "                         \n" +
                    $"///////////////////");
            }
            Console.ReadKey();
        }

        //Method to Add Outings//
        private void AddCustomer()
        {

            Console.Clear();
            Console.WriteLine("Press enter to Add a new customer.");
            Console.ReadKey();

            Console.WriteLine("What type of customer is this?\n" +
                "1. Potential \n" +
                "2. Current \n" +
                "3. Past \n");
            int input = ParseInput();

            CustType custType;
            switch (input)
            {
                default:
                case 1:
                    custType = CustType.Potential;
                    break;
                case 2:
                    custType = CustType.Current;
                    break;
                case 3:
                    custType = CustType.Past;
                    break;
            }

            Console.WriteLine("Whats the customers first name");
            string fName = Console.ReadLine();

            Console.WriteLine("Whats the customers last name?");
            string lName = Console.ReadLine();

            Console.WriteLine($"Please type the email they will recieve?");
            string emailText = Console.ReadLine();

            Customer newCustomer = new Customer(fName, lName, custType, emailText);
            _custRepo.AddCustomerToList(newCustomer);

            Console.WriteLine("This customer has been added to the database. press enter to return to menu.");
            Console.ReadKey();
        }

        //Method to parse input on (switch) menus
        private int ParseInput()
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 1 || input > 5)
            {
                Console.WriteLine("Your input was invalid, please enter a valid menu number.");
                input = ParseInput();
            }
            return input;
        }

        private void RemoveCustomer()
        {
            Console.Clear();
            PrintAllItems();

            Console.WriteLine("What is the first name for the customer would you like to remove?");
            string fName = Console.ReadLine();

            Console.WriteLine("What is the last name of the customer?");
            string lName = Console.ReadLine();

            CustType custType = CustType.Current;
            string emailText = "yo";


            bool success = _custRepo.RemoveCustomerBySpecifications(fName, lName, custType, emailText);
            if (success == true)
            {
                Console.WriteLine($"{fName} {lName} was sucfcessfully removed.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{fName} {lName} was unable to be removed at this time.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void UpdateCustomer()
        {
                 Console.WriteLine("Enter the first name:");
                _customer.FName = Console.ReadLine();

                Console.WriteLine("Enter the last name:");
            _customer.LName = Console.ReadLine();

                Console.WriteLine("Enter customer type: \n" +
                    "1. Potential \n" +
                    "2. Current\n" +
                    "3. Past");
                string typeAsString = Console.ReadLine().ToLower();
                switch (typeAsString)
                {
                    case "Potential":
                    case "1":
                        _customer.CustType = CustType.Potential;
                        break;
                    case "Current":
                    case "2":
                        _customer.CustType = CustType.Current;
                        break;
                    case "Past":
                    case "3":
                    default:
                        _customer.CustType = CustType.Past;
                        break;
                }

            }
    }
}
