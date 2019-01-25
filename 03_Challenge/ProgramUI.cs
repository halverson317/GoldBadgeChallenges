using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public class ProgramUI
    {
        //add a field to call on repository
        OutingRepo _outingRepo = new OutingRepo();



        public void Run()
        {
            ////set bool for while loop
            bool running = true;
            ///start while loop
            while (running)
            {
                Console.Clear();
                Console.WriteLine("KOMODO OUTINGS \n" +
                    "Please selecting from the following:\n" +
                    "1. View all outings:\n" +
                    "2. Add a specific outing:\n" +
                    "3. View total cost of all outings:\n" +
                    "4. View total cost per each catagory of outings:\n" +
                    "5. Exit");

                int choice = ParseInput();

                switch (choice)
                {
                    case 1:
                        DisplayOutings();
                        break;
                    case 2:
                        AddOuting();
                        break;
                    case 3:
                        TotalCostOfAllOutings();
                        break;
                    case 4:
                        TotalCostOfOneType();
                        break;
                    case 5:
                        running = false;
                        break;
                }
            }
        }

        //Display and PrintList MEthods//
        private void DisplayOutings()
        {
            {
                Console.Clear();
                Console.WriteLine("To see a list of all outings, press enter:");
                Console.ReadKey();
                PrintAllItems();
                Console.WriteLine("Press enter again to return to the main menu");
                Console.ReadKey();

            }
        }

        private void PrintAllItems()
        {
            List<OutingInfo> _outingList = _outingRepo.GetOutingInfo();

            foreach (OutingInfo outing in _outingList)
            {
                Console.WriteLine($"TYPE: {outing.OutingType}\n" +
                    $"DATE: {outing.Date}\n" +
                    $"#ofPeople: {outing.NumberOfPeople}\n" +
                    $"CostPerPerson: {outing.TotalCostPerPerson}\n" +
                    $"TotalCostOfEvent: {outing.TotalCostByEvent}\n" +
                    $"///////////////////");
            }
            Console.ReadKey();
        }

        //Method to Add Outings//
        private void AddOuting()
        {
            // OutingType, Date, NoOfPEople, Total Cost Per Person, Total Cost Event

            Console.Clear();
            Console.WriteLine("Press enter to Add a new outing.");
            Console.ReadKey();

            Console.WriteLine("What did you do on the Outing?\n" +
                "1. Golf \n" +
                "2. Bowling \n" +
                "3. Amusement Park \n" +
                "4. Concert \n");
            int input = ParseInput();

            OutingType type;
            switch (input)
            {
                default:
                case 1:
                    type = OutingType.Golf;
                    break;
                case 2:
                    type = OutingType.Bowling;
                    break;
                case 3:
                    type = OutingType.AmmusmentPark;
                    break;
                case 4:
                    type = OutingType.Concert;
                    break;
            }

            Console.WriteLine("What was the date of the trip? (MM/DD/YY)");
            string date = Console.ReadLine();

            Console.WriteLine("How many people attended?");
            int numberOfPeople = int.Parse(Console.ReadLine());

            Console.WriteLine($"What was the cost per person?");
            decimal totalCostPerPerson = decimal.Parse(Console.ReadLine());

            Console.WriteLine("What was the total cost of the event?");
            decimal totalCostByEvent = decimal.Parse(Console.ReadLine());

            OutingInfo  newOuting = new OutingInfo(type, numberOfPeople, date, totalCostPerPerson, totalCostByEvent);
            _outingRepo.AddOutingToList(newOuting);

            Console.WriteLine("This Outing has been added to the database. press enter to return to menu.");
            Console.ReadKey();
        }

        //Methods to do math on outings
        private void TotalCostOfAllOutings()
        {
            Console.Clear();

            decimal golf = _outingRepo.AddCostofOneType(OutingType.Golf);
            decimal bowling = _outingRepo.AddCostofOneType(OutingType.Bowling);
            decimal amusmentPark = _outingRepo.AddCostofOneType(OutingType.AmmusmentPark);
            decimal concert = _outingRepo.AddCostofOneType(OutingType.Concert);

            decimal totalCost = golf + bowling + amusmentPark + concert;

            Console.WriteLine($"Currently, the total cost of all trips = {totalCost}.\n" +
                $"press enter to return to menu.");
            Console.ReadKey();
        }

        private void TotalCostOfOneType()
        {
            Console.Clear();

            decimal golf = _outingRepo.AddCostofOneType(OutingType.Golf);
            decimal bowling = _outingRepo.AddCostofOneType(OutingType.Bowling);
            decimal amusmentPark = _outingRepo.AddCostofOneType(OutingType.AmmusmentPark);
            decimal concert = _outingRepo.AddCostofOneType(OutingType.Concert);
            Console.WriteLine($"Here is a breakdown of the cost per event type:\n" +
                $"Golf = {golf}\n" +
                $"Bowling = {bowling}\n" +
                $"Amusement Parks = {amusmentPark}\n" +
                $"Concerts = {concert}\n");
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
    }
}

