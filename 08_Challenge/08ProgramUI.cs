using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    class _08ProgramUI
    {
        //add a field to call on repository
        DDRepo _driver = new DDRepo();



        public void Run()
        {
            Console.WriteLine("WELCOME TO SMARTCAR INSURANCE CALCULATOR.\n" +
                "Lets use some driver information to calculate an insurance premium.\n" +
                "First, I will need some driver data. You should already pulled this info from the smartcar's computer.\n" +
                "If you have the information, and wish to proceed, press enter:\n");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Please enter the driver's SmartCarID #");
            int smartCarID = int.Parse(Console.ReadLine());
            Console.WriteLine("How often did the driver drive over the speed limit (response will be in the form of %, round decimals up to next number):");
            int overSL = int.Parse(Console.ReadLine());
            Console.WriteLine("How often did the driver swerve?");
            int swerve= int.Parse(Console.ReadLine());
            Console.WriteLine("How often did the driver roll through stop signs?");
            int rollSS = int.Parse(Console.ReadLine());
            Console.WriteLine("How often did the driver tailgate other drivers?");
            int tailgate = int.Parse(Console.ReadLine());

            //public DriverData(int smartCarID, int overSL, int swerve, int rollSS, int Talgate)
            DriverData driver = new DriverData(smartCarID, overSL, swerve, rollSS, tailgate);
            _driver.AddDriverToList(driver);
            decimal totalCost = _driver.TotalPremiumCost(driver);

            Console.Clear();

            Console.WriteLine($"The total insurance premium for this driver based on performance is {totalCost}.");
            Console.WriteLine("Thank you.");
            Console.ReadKey();
        }
    }
}
