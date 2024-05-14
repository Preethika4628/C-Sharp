using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdminstration
{
    public class Teacher :PersonalInfo
    {
        private static int s_teacherID = 1000;
        public string TeacherID {get;}
        public string Department {get; set;}
        public string SubTeaching {get; set;}
        public string Qualification {get; set;}
        public double YearsOfExperience {get; set;}
        public DateTime DateOfJoining {get; set;}
        public Teacher(string name, string fatherName, DateTime dob, long phone, string gender, string mailID, string department, string subTeaching, string qualification, double yrOfExp, DateTime dateOfJoining) : base( name, fatherName, dob, phone, gender, mailID)
        {
            s_teacherID++;
            TeacherID = "TID" + s_teacherID;
            Department = department;
            SubTeaching = subTeaching;
            Qualification = qualification;
            YearsOfExperience = yrOfExp;
            DateOfJoining = dateOfJoining;
        }
    }
}