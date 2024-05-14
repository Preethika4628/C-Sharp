using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
    public class PersonalInfo
    {
        public string Name {get; set;}
        public string Fathername {get; set;}
        public long Phone {get; set;}
        public string Mail {get; set;}
        public DateTime DOB {get; set;}
        public string Gender {get; set;}
        public PersonalInfo(string name, string fatherName, long phone, string mail, DateTime dob, string gender)
        {
            Name = name;
            Fathername = fatherName;
            Phone = phone;
            Mail = mail;
            DOB = dob;
            Gender = gender;
        }
    }
}