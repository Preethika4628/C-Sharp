using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank
{
    public enum Gender {Select, Male, Female, Transgender}
    public class PersonalInfo
    {
        public string Name {get; set;}
        public Gender Gender {get; set;}
        public DateTime DOB {get; set;}
        public long Phone {get; set;}
        public double Balance {get; set;}
        public PersonalInfo (string name, Gender gender, DateTime dob, long phone, double balance)
        {
            Name = name;
            Gender = gender;
            DOB = dob;
            Phone = phone;
            Balance = balance;
        }
    }
}