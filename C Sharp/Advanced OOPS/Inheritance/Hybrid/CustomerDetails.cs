using System;
using System.Collections.Generic;

namespace Hybrid
{
    public class CustomerDetails : PersonalDetails
    {
        private static int s_customerID = 1000;
        public string CustomerID {get;}
        public double Balance {get; set;}
        public CustomerDetails(string name, string fatherName, Gender gender, DateTime dob, double balance) : base(name, fatherName, gender, dob)
        {
            s_customerID++;
            CustomerID = "CID" + s_customerID;
            Balance = balance;

        }
    }
}