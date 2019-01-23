using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{
    public enum CustType { Potential, Current, Past }

    public class Customer
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public CustType CustType { get; set; }
        public string EmailText { get; set; }

        public Customer(string fName, string lName, CustType custType, string emailText)
        {
            FName = fName;
            LName = lName;
            CustType = custType;
            EmailText = emailText;

        }

        public Customer()
        {

        }
    }

    
}
