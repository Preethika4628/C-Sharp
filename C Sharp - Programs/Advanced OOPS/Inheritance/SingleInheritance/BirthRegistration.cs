using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public enum Gender { Select, Male, Female, Transgender }
    public class BirthRegistration
    {
        private static int s_birthID = 1000;
        public string BirthID {get;}
        public string Name {get; set;}
        public string FatherName {get; set;}
        public Gender Gender {get; set;}
        public DateTime DOB {get; set;}

        public BirthRegistration(string name, string fatherName, Gender gender, DateTime dob)
        {
            s_birthID++;
            BirthID = "BID" + s_birthID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            DOB = dob;
        }
        
    }
}