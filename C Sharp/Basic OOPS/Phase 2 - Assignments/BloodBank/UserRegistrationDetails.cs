using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public enum BloodType
    {
        Select, A_Positive, B_Positive, O_Positive, AB_Positive
    }
    public class UserRegistrationDetails
    {
        public static int s_donarID = 1000;
        public string DonarID {get;}
        public string DonarName {get; set;}
        public long MobileNumber {get; set;}
        public BloodType BloodGroup {get; set;}
        public int Age {get; set;}
        public DateTime LastDonationDate {get; set;}
        public UserRegistrationDetails()
        {
            BloodGroup = BloodType.Select;
        }

        public UserRegistrationDetails(string donarName, long mobileNumber, BloodType bloodGroup, int age, DateTime lastDonationDate)
        {
            s_donarID++;
            DonarID = "UID" + s_donarID;
            DonarName = donarName;
            MobileNumber = mobileNumber;
            BloodGroup = bloodGroup;
            Age = age;
            LastDonationDate = lastDonationDate;
        }
    }
}