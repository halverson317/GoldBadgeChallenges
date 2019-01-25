using System;
using _05_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestChallenge05
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CustomerRepository_AddAndRemoveCustomer_ShouldBeCorrectCount()
        {
            //Arrange
            CustRepo _custRepo = new CustRepo();
            Customer customerOne = new Customer();
            Customer customerTwo = new Customer();
            Customer customerThree = new Customer();

            _custRepo.AddCustomerToList(customerOne);
            _custRepo.AddCustomerToList(customerTwo);
            _custRepo.AddCustomerToList(customerThree);

            _custRepo.RemoveCustomer(customerThree);
            //Act
            int actual = _custRepo.ListCustomers().Count;
            int expected = 2;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        
        
    }
}
