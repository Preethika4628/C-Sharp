using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public enum Gender { Select, Male, Female, Transgender }
    public class PersonalInfo
    {
        public string Name {get; set;}
        public string FatherName {get; set;}
        public long Phone {get; set;}
        public string Mail {get; set;}
        public DateTime DOB {get; set;}
        public Gender Gender {get; set;}
        public PersonalInfo(string name, string fatherName, long phone, string mail, DateTime dob, Gender gender)
        {
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            Mail = mail;
            DOB = dob;
            Gender = gender;
        }
    }
}