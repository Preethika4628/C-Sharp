using System;
using System.IO;

namespace BloodBank
{
    public static class FileHandling
    {
        public static void Create()
        {
            //creating directory
            if(!Directory.Exists("BloodBank"))
            {
                Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("BloodBank");
            }
            else
            {
                Console.WriteLine("Directory Already exists");
            }

            //file for user registration
            if(!File.Exists("BloodBank/UserRegistrationDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("BloodBank/UserRegistrationDetails.csv").Close();
            }
            else
            {
                Console.WriteLine("File already exists");
            }

            //file for donation
            if(!File.Exists("BloodBank/DonationDetails.csv"))
            {
                Console.WriteLine("Creating File");
                File.Create("BloodBank/DonationDetails.csv").Close();
            }
            else
            {
                Console.WriteLine("File already exists");
            }

        }
        public static void WriteToCSV()
        {
            //user registration
            string[] donar = new string[Operation.userRegistrationList.Count];
            for(int i=0; i<Operation.userRegistrationList.Count; i++)
            {
                donar[i] = Operation.userRegistrationList[i].DonarID + "," + Operation.userRegistrationList[i].DonarName + "," + Operation.userRegistrationList[i].MobileNumber + "," + Operation.userRegistrationList[i].BloodGroup + "," + Operation.userRegistrationList[i].Age + "," + Operation.userRegistrationList[i].LastDonationDate.ToString("dd/MM/yyyy");
            }
            File.WriteAllLines("BloodBank/UserRegistrationDetails.csv", donar);

            //donation
            string[] donation = new string[Operation.donationList.Count];
            for(int i=0; i<Operation.donationList.Count; i++)
            {
                donation[i] = Operation.donationList[i].DonationID + "," + Operation.donationList[i].DonarID + "," + Operation.donationList[i].DonationDate.ToString("dd/MM/yyyy") + "," + Operation.donationList[i].Weight + "," + Operation.donationList[i].BloodPressure + "," + Operation.donationList[i].Hemoglobin + "," + Operation.donationList[i].BloodGroup;
            }
            File.WriteAllLines("BloodBank/DonationDetails.csv", donation);
        }
        public static void ReadFromCSV()
        {
            //donar
            string[] donars = File.ReadAllLines("BloodBank/UserRegistrationDetails.csv");
            foreach(string donar in donars)
            {
                UserRegistrationDetails donar1 = new UserRegistrationDetails(donar);
                Operation.userRegistrationList.Add(donar1);
            }

            //donation
            string[] donations = File.ReadAllLines("BloodBank/DonationDetails.csv");
            foreach(string donation in donations)
            {
                DonationDetails donation1 = new DonationDetails(donation);
                Operation.donationList.Add(donation1);
            }

        }
    }
}