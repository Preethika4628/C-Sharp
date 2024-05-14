using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeReg
{
    public class PersonalInfo
    {
        public string Name {get; set;}
        public string FatherName {get; set;}
        public string MailID {get; set;}
        public DateTime DOB {get; set;}
        public string Gender {get; set;}
        public PersonalInfo(string name, string fatherName, string mailID, DateTime dob, string gender)
        {
            Name = name;
            FatherName = fatherName;
            MailID = mailID;
            DOB = dob;
            Gender = gender;
        }
    }
}