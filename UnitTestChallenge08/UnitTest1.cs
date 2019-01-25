using System;
using _08_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestChallenge08
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DDRepo_CalculateDriverPremiumPartOne_ShouldReturnCorrectValue()
        {
            //Arrange
            DDRepo _ddRepo = new DDRepo();
            DriverData driver = new DriverData();
            driver.OverSL = 10;

            //Act
            decimal actual = _ddRepo.CalculateDriverPremiumPartOne(driver);
            decimal expected = 10m;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DDRepo_CalculateDriverPremiumPartTwo_ShouldReturnCorrectValue()
        {
            //Arrange
            DDRepo _ddRepo = new DDRepo();
            DriverData driver = new DriverData();
            driver.Swerve = 20;

            //Act
            decimal actual = _ddRepo.CalculateDriverPremiumPartTwo(driver);
            decimal expected = 10m;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DDRepo_CalculateDriverPremiumPartThree_ShouldReturnCorrectValue()
        {
            //Arrange
            DDRepo _ddRepo = new DDRepo();
            DriverData driver = new DriverData();
            driver.RollSS = 10;

            //Act
            decimal actual = _ddRepo.CalculateDriverPremiumPartThree(driver);
            decimal expected = 10m;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DDRepo_CalculateDriverPremiumPartFour_ShouldReturnCorrectValue()
        {
            //Arrange
            DDRepo _ddRepo = new DDRepo();
            DriverData driver = new DriverData();
            driver.Tailgate = 90;

            //Act
            decimal actual = _ddRepo.CalculateDriverPremiumPartFour(driver);
            decimal expected = 50m;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DDRepo_TotalPremiumCost_ShouldReturnCorrectValue()
        {
            //Arrange
            DDRepo _ddRepo = new DDRepo();
            DriverData driver = new DriverData();
            driver.OverSL = 10;
            driver.Swerve = 10;
            driver.RollSS = 5;
            driver.Tailgate = 90;

            //Act
            decimal actual = _ddRepo.TotalPremiumCost(driver);
            decimal expected = 90m;

            //Assert
            Assert.AreEqual(expected, actual);
        }



    }
    }

