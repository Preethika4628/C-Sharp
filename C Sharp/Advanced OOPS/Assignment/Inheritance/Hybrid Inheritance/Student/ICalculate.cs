using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student
{
    public interface ICalculate
    {
        public int ProjectMarks {get; set;}
        void CalculateUG();
    }
}