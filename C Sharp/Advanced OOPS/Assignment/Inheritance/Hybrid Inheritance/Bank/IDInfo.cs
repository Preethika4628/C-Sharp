using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank
{
    public class IDInfo : PersonalInfo
    {
        public string VoterID {get; set;}
        public string AadharID {get; set;}
        public string PANNumber {get; set;}
        public IDInfo(string name, Gender gender, DateTime dob, long phone, double balance, string voterID, string aadharID, string panNumber) : base( name,  gender,  dob,  phone,  balance)
        {
            VoterID = voterID;
            AadharID = aadharID;
            PANNumber = panNumber;
        }

    }
}