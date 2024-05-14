using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdminstration
{
    public class PersonalInfo
    {
        public string Name {get; set;}
        public string FatherName {get; set;}
        public DateTime DOB {get; set;}
        public long Phone {get; set;}
        public string Gender {get; set;}
        public string MailID {get; set;}
        public PersonalInfo(string name, string fatherName, DateTime dob, long phone, string gender, string mailID)
        {
            Name = name;
            FatherName = fatherName;
            DOB = dob;
            Phone = phone;
            Gender = gender;
            MailID = mailID;
        }
        
    }
}