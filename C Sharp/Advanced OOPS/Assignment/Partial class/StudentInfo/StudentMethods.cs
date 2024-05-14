using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo
{
    public partial class StudentInfo
    {
        public void Calculate()
        {
            Marks = Physics + Chemistry + Maths;
            Percentage = Marks / 300 * 100;
        }
        public double Display()
        {
            return Marks;
        }
    }
}