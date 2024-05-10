using System;

namespace Hybrid
{
    public enum Gender { Select, Male, Female, Transgender }
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public PersonalDetails(string name, string fatherName, Gender gender, DateTime dob)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            DOB = dob;
        }

    }
}