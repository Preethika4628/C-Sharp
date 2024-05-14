using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInhertiance
{
    public enum Gender {Select, Male, Female, Transgender}
    public enum Marital { Select, Married, Single}
    public class PersonalInfo : IShowData
    {
        public string Name {get; set;}
        public Gender Gender {get; set;}
        public DateTime DOB {get; set;}
        public long Phone {get; set;}
        public Marital Marital {get; set;}
        public PersonalInfo (string name, Gender gender, DateTime dob, long phone, Marital marital)
        {
            Name = name;
            Gender = gender;
            DOB = dob;
            Phone = phone;
            Marital = marital;
        }
        public string ShowInfo()
        {
            return Name + " | " + Gender +" | "+DOB.ToString("dd/MM/yyyy") +" | "+Phone+" | "+Marital;
        }

    }
}