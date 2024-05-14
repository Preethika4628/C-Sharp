using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierachical
{
    public class AadharDetails : BirthRegistration
    {
        private static int s_aadharID = 2000;
        public string AadharID { get; }
        public string Address { get; set; }

        public AadharDetails(string birthID, string name, string fatherName, Gender gender, DateTime dob, string address) : base(birthID, name, fatherName, gender, dob)
        {
            s_aadharID++;
            AadharID = "AID" + s_aadharID;
            Address = address;
        }

    }
}