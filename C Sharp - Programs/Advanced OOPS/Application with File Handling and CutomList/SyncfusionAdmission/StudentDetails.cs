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
        
        // public StudentDetails(string studentName)
        // {
        //     Gender = Gender.Select;
        // }
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
        public StudentDetails(string student)
        {
            string[] values = student.Split(",");
            StudentID = values[0];
            s_studentID = int.Parse(values[0].Remove(0,2));
            StudentName = values[1];
            FatherName = values[2];
            DOB = DateTime.ParseExact(values[3], "dd/MM/yyyy", null);
            Gender = Enum.Parse<Gender>(values[4]);
            Physics = int.Parse(values[5]);
            Chemistry = int.Parse(values[6]);
            Maths = int.Parse(values[7]);
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