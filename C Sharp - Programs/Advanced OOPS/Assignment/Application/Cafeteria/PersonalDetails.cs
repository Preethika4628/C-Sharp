using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public enum Gender{ Select, Male, Female, Transgender }
    public class PersonalDetails
    {
        public string Name {get; set;}
        public string FatherName {get; set;}
        public long Mobile {get; set;}
        public string EmailID {get; set;}
        public Gender Gender {get; set;}

        public PersonalDetails(string name, string fatherName, long mobile, string emailID, Gender gender)
        {
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
            EmailID = emailID;
            Gender = gender;
        }
        public PersonalDetails()
        {
            
        }
    }
}