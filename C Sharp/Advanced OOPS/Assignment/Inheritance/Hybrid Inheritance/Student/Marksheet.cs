using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student
{
    public class Marksheet : TheoryExamMarks, ICalculate
    {
        private static int s_marksheetNum = 2000;
        public string MarksheetNum {get; set;}
        public DateTime DateOfIssue {get; set;}
        public int Total {get; set;}
        public int Percentage {get; set;}
        public int ProjectMarks {get; set;}
    
        public Marksheet (DateTime dateOfIssue, int total, int percentage) : base ()
        {
            s_marksheetNum++;
            MarksheetNum = "MID" + s_marksheetNum;
            DateOfIssue = dateOfIssue;
            Total = total;
            Percentage = percentage;
        }
        public void CalculateUG()
        {
            
        }
    }
}