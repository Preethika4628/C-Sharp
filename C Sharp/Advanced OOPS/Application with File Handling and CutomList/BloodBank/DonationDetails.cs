using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public class DonationDetails
    {
        private static int s_donationID = 1000;
        public  string DonationID {get;}
        public string DonarID {get; set;}
        public DateTime DonationDate {get; set;}
        public int Weight {get; set;}
        public int BloodPressure {get; set;}
        public double Hemoglobin {get; set;}
        public BloodType BloodGroup {get; set;}
        public DonationDetails(string donarID, DateTime donationDate, int weight, int bloodPressure, double hemoglobin, BloodType bloodGroup)
        {
            s_donationID++;
            DonationID = "DID" + s_donationID;
            DonarID = donarID;
            DonationDate = donationDate;
            Weight = weight;
            BloodPressure = bloodPressure;
            Hemoglobin = hemoglobin;
            BloodGroup = bloodGroup;
        }
        public DonationDetails( string donation)
        {
            string[] values = donation.Split(",");
            DonationID = values[0];
            s_donationID = int.Parse(values[0].Remove(0,3));
            DonarID = values[1];
            DonationDate = DateTime.ParseExact(values[2], "dd/MM/yyyy", null);
            Weight = int.Parse(values[3]);
            BloodPressure = int.Parse(values[4]);
            Hemoglobin = double.Parse(values[5]);
            BloodGroup = Enum.Parse<BloodType>(values[6]);
        }
        
    }
}