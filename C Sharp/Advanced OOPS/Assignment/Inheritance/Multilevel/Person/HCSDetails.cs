using System;

namespace Person
{
    public class HCSDetails : StudentInfo
    {
        public int HSCMarksheetNumber {get; set;}
        public int Physics {get; set;}
        public int Chemistry {get; set;}
        public int Maths {get; set;}
        public int Total {get; set;}
        public int PercentageMarks {get; set;}
        public HCSDetails(string name, string fatherName, long phone, string mail, DateTime dob, Gender gender, int registerNumber, string standard, string branch, int academicYear, 
            int hscMarksheetNumber, int physics, int chemistry, int maths, int total, int percentageMarks) : base(name, fatherName, phone, mail, dob, gender, registerNumber, standard, branch, academicYear)
            {
                HSCMarksheetNumber = hscMarksheetNumber;
                Physics = physics;
                Chemistry = chemistry;
                Maths = maths;
                Total = total;
                PercentageMarks = percentageMarks;
            }
        
        public int GetMarks()
        {
            return Physics+Chemistry+Maths;
        }
        public int Calculate()
        {
            int Total =  Physics+Chemistry+Maths;
            int PercentageMarks = Total/300 * 100;
            return PercentageMarks;
        }
    }
}