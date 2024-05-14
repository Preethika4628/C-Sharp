using System;

namespace CollegeAdmission
{
    public enum Gender
    {
        Select, Male, Female, TransGender
    }
    public class StudentDetails
    {
        //class conatins fields, properties, events, indexers, constructors, destructors, methods
        //Field
        private static int s_studentID = 1000;  //static bcz to create a unique id for each person
        //Properties
        //autoProperty
        public string StudentID { get; } //can't access outside - remove set property
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public long Phone { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }

        //Constructors
        public StudentDetails(string studentName)
        {
            Gender = Gender.Select;
        }
        //paramaterixed constructor
        public StudentDetails(string studentName, string fatherName, Gender gender, DateTime dob, long phone,
                int physics, int chemistry, int maths)
        {
            //assign paramter values to properties
            s_studentID++;
            StudentID = "SF" + s_studentID;
            StudentName = studentName;
            FatherName = fatherName;
            Gender = gender;
            DOB = dob;
            Phone = phone;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }

        //destructor
        ~StudentDetails()
        {
            Console.WriteLine("Destructed");
        }
        

        //methods
        public bool CheckEligibilty(double cutoff)
        {
            double average = (Physics + Chemistry + Maths) / 3;
            if (average > cutoff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // //Methods
        // public double Average()
        // {
        //     return (double)(Physics + Chemistry + Maths) / 3;
        // }
        // public bool IsEligibilty(double cutoff)
        // {
        //     if (Average() > cutoff)
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }
    }
}
