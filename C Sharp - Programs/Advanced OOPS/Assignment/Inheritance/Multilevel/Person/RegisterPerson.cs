using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInhertiance
{
    public class RegisterPerson : PersonalInfo, IShowData, IFamilyInfo
    {
        private static int s_registerNumber = 1000;
        public string RegisterNumber { get; }
        public DateTime DateOfRegistration { get; set; }
        public string Fathername { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NumberOfSibling { get; set; }
        public RegisterPerson(string name, Gender gender, DateTime dob, long phone, Marital marital, string fatherName, string motherName, string address, int numberOfSibling, DateTime dateOfRegistration) : base(name, gender, dob, phone, marital)
        {
            s_registerNumber++;
            RegisterNumber = "RID" + s_registerNumber;
            DateOfRegistration = dateOfRegistration;
            Fathername = fatherName;
            MotherName = motherName;
            HouseAddress = address;
            NumberOfSibling = numberOfSibling; 

        }

        public new string ShowInfo()
        {
            return Name + " | " + Gender +" | "+DOB.ToString("dd/MM/yyyy") +" | "+Phone+" | "+Marital +" | "+ Fathername +" | "+ MotherName +" | "+HouseAddress +" | "+ RegisterNumber +" | "+ NumberOfSibling +" | "+ DateOfRegistration;
        }
    }
}