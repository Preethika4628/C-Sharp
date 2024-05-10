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
        
    }
}