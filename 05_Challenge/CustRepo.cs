using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{
    class CustRepo
    {
        List<Customer> _customers = new List<Customer>();

        public void AddCustomerToList(Customer customer)
        {
            _customers.Add(customer);
        }

        public List<Customer> ListCustomers()
        {
            return _customers;
        }

        public void RemoveCustomer(Customer customer)
        {
            _customers.Remove(customer);
        }

        public bool RemoveCustomerBySpecifications(string fName, string lName, CustType custType, string emailText)
        {
            bool successful = false;
            foreach (Customer customer in _customers)
            {
                if (customer.FName == fName && customer.LName == lName)
                {
                    RemoveCustomer(customer);
                    successful = true;
                    break;
                }
            }
            return successful;
        }
    }
}
