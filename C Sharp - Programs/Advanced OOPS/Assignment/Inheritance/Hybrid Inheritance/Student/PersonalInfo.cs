using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student
{
    public enum Gender {Select, Male, Female, Transgender}
    public class PersonalInfo
    {
        private static int s_regNumber = 1000;
        public string RegNumber { get; set;}
        public string Name {get; set;}
        public string FatherName {get; set;}
        public long Phone {get; set;}
        public DateTime DOB {get; set;}
        public Gender Gender {get; set;}
        public PersonalInfo(string name, string fatherName, long phone, DateTime dob, Gender gender)
        {
            s_regNumber++;
            RegNumber = "RID" + s_regNumber;
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            DOB = dob;
            Gender = gender;
        }
    }
}