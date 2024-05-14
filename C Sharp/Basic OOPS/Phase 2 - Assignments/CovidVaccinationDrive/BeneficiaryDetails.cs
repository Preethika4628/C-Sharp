using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccinationDrive
{
    public enum Gender
    {
        Select, Male, Female, Others
    }
    public class BeneficiaryDetails
    {
        private static int s_registrationID = 1000;
        public string RegistrationID {get;}
        public string Name {get; set;}
        public int Age {get; set;}
        public Gender Gender {get; set;}
        public long MobileNumber {get; set;}
        public string City {get; set;}

        public BeneficiaryDetails(string name,int age, Gender gender, long mobileNumber, string city)
        {
            s_registrationID++;
            RegistrationID = "BID" + s_registrationID;
            Name = name;
            Age = age;
            Gender = gender;
            MobileNumber = mobileNumber;
            City = city;
        }
        public BeneficiaryDetails()
        {
            Gender = Gender.Select;
        }
    }
}