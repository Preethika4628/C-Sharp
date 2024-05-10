using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadWrite
{
    public enum Gender {Select, male, Female, Transgender}
    public class Student
    {
        public string Name {get; set;}
        public string Fathername {get; set;}
        public Gender Gender {get; set;}
        public DateTime DOB {get; set;}
        public int TotalMarks {get; set;}
    }
}