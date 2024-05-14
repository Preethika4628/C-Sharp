using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdminstration
{
    public class PrincipalInfo : PersonalInfo
    {
        private static int s_principalID = 1000;
        public string PrincipalID {get;}
        public string Qualification {get; set;}
        public double YearsOfExperience {get; set;}
        public DateTime DateOfJoining {get; set;}
        public PrincipalInfo(string name, string fatherName, DateTime dob, long phone, string gender, string mailID, string qualification, double yrOfExp, DateTime dateOfJoining) : base( name, fatherName, dob, phone, gender, mailID)
        {
            s_principalID++;
            PrincipalID = "PID" + s_principalID;
            Qualification = qualification;
            YearsOfExperience = yrOfExp;
            DateOfJoining = dateOfJoining;
        }
        public string ShowDetails()
        {
            return ($"{PrincipalID} | {Qualification} | {YearsOfExperience} | {DateOfJoining}");
        }
    }
}