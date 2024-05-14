using System;
using System.Collections.Generic;

namespace Hybrid
{

    public class BirthRegistration : PersonalDetails
    {
        private static int s_birthID = 1000;
        public string BirthID { get; }

        public BirthRegistration(string name, string fatherName, Gender gender, DateTime dob) : base(name, fatherName, gender, dob)
        {
            s_birthID++;
            BirthID = "BID" + s_birthID;

        }
        public BirthRegistration(string birthID, string name, string fatherName, Gender gender, DateTime dob) : base(name, fatherName, gender, dob)
        {
            BirthID = birthID;
        }

    }
}