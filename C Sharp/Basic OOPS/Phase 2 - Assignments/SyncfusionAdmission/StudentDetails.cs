using System;
namespace SyncfusionAdmission
{
    public enum Gender
    {
        Select, Male, Female, Transgender
    }
    public class StudentDetails
    {
        private static int s_studentID = 3000;
        public string StudentID {get;}
        public string StudentName {get; set;}
        public string FatherName {get; set;}
        public DateTime DOB {get; set;}
        public Gender Gender {get; set;}
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        
        public StudentDetails(string studentName)
        {
            Gender = Gender.Select;
        }
        public StudentDetails(string studentName, string fatherName, DateTime dob, Gender gender, 
                int physics, int chemistry, int maths)
        {
            s_studentID++;
            StudentID = "SF" + s_studentID;
            StudentName = studentName;
            FatherName = fatherName;
            DOB = dob;
            Gender = gender;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }

        public double Average()
        {
            double average = (double)(Physics + Chemistry + Maths) / 3;
            return average;
        }
        public bool IsEligibile(double cutOff)
        {
            if (Average() >= cutOff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}