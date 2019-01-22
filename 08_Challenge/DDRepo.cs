using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    class DDRepo
    {
        List<DriverData> _driver = new List<DriverData>();

        public void AddDriverToList(DriverData driver)
        {
            _driver.Add(driver);
        }

        public List<DriverData> GetDriverInfo()
        {
            return _driver;
        }

        public decimal CalculateDriverPremiumPartOne(DriverData driver)
        {
            decimal sLcharge = 0m;

            if (driver.OverSL > 9 && driver.OverSL < 30)
                sLcharge = 10m;
            else if (driver.OverSL > 29 && driver.OverSL < 60)
                sLcharge = 25m;
            else if (driver.OverSL > 59)
                sLcharge = 50m;
            else
                sLcharge = 0;

            return sLcharge;
        }

        public decimal CalculateDriverPremiumPartTwo(DriverData driver)
        {
            decimal swerveStat = 0m;

            if (driver.Swerve > 9 && driver.Swerve < 30)
                swerveStat = 10m;
            else if (driver.Swerve > 29 && driver.Swerve < 60)
                swerveStat = 25m;
            else if (driver.Swerve > 59)
                swerveStat = 50m;
            else
                swerveStat = 0;

            return swerveStat;
        }

        public decimal CalculateDriverPremiumPartThree(DriverData driver)
        {
            decimal rollStat = 0m;

            if (driver.RollSS > 9 && driver.RollSS < 30)
                rollStat = 10m;
            else if (driver.RollSS > 29 && driver.RollSS < 60)
                rollStat = 25m;
            else if (driver.RollSS > 59)
                rollStat = 50m;
            else
                rollStat = 0;

            return rollStat;

        }

        public decimal CalculateDriverPremiumPartFour(DriverData driver)
        {
            decimal tailgateStat = 0m;

            if (driver.Tailgate > 9 && driver.Tailgate < 30)
                tailgateStat = 10m;
            else if (driver.Tailgate > 29 && driver.Tailgate < 60)
               tailgateStat = 25m;
            else if (driver.Tailgate > 59)
               tailgateStat = 50m;
            else
                tailgateStat = 0;

            return tailgateStat;
        }
    }
}
