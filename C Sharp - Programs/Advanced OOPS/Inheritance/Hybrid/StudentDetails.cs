using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid
{
    public class StudentDetails : AadharDetails, IMarkDetails
    {
        private static int s_studentID = 1000;
        public string StudentID {get; set;}
        public string Standard {get; set;}
        public int Mark1 {get; set;}
        public int Mark2 {get; set;}
        public int Mark3 {get; set;}

        public StudentDetails(string birthID, string aadharID, string name, string fatherName, Gender gender, DateTime dob, 
        string address, string standard) : base( aadharID,  birthID,  name,  fatherName,  gender,  dob,  address)
        {
            s_studentID++;
            StudentID = "SID" + s_studentID;
            Standard = standard;
        }
        public void GetMarks(int mark1, int mark2, int mark3)
        {
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
        }
    }
}