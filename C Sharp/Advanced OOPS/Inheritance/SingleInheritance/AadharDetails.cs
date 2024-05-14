using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public class AadharDetails : BirthRegistration
    {
        private static int s_aadharID = 2000;
        public string AadharID {get;}
        public string Address {get; set;}

        public AadharDetails(string name, string fatherName, Gender gender, DateTime dob, string address) : base(name, fatherName, gender, dob)
        {
            s_aadharID++;
            AadharID = "AID" + s_aadharID;
            Address = address; 
        }
        
    }
}