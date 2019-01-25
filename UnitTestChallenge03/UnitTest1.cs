using System;
using _03_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestChallenge03
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddOutingsShouldReturnCorrectCount()
        {   //Arrange
            OutingRepo _outingRepo = new OutingRepo();
            OutingInfo outing = new OutingInfo();
            OutingInfo outingTwo = new OutingInfo();
            OutingInfo outingThree = new OutingInfo();

            _outingRepo.AddOutingToList(outing);
            _outingRepo.AddOutingToList(outingTwo);
            _outingRepo.AddOutingToList(outingThree);
            //Act
            int actual = _outingRepo.GetOutingInfo().Count;
            int expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddCostShouldReturnCorrectValue()
        {
            OutingRepo _outingRepo = new OutingRepo();
            OutingInfo outing = new OutingInfo(OutingType.Golf, 10, "03/01/18", 20.00m, 200.00m);
            OutingInfo outingTwo = new OutingInfo(OutingType.Golf, 10, "03/01/18", 20.00m, 200.00m);
            OutingInfo outingThree = new OutingInfo(OutingType.Golf, 10, "03/01/18", 20.00m, 200.00m);

            _outingRepo.AddOutingToList(outing);
            _outingRepo.AddOutingToList(outingTwo);
            _outingRepo.AddOutingToList(outingThree);

            decimal actual = _outingRepo.AddCostofOneType(OutingType.Golf);
            decimal expected = 600m;

            Assert.AreEqual(expected, actual);





        }
    }
}
