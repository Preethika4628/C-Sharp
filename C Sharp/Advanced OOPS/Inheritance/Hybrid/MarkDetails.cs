using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid
{
    public interface IMarkDetails
    {
        //property and methods - interface
        int Mark1 {get; set;}
        int Mark2 {get; set;}
        int Mark3 {get; set;}
        void GetMarks(int mark1, int mark2, int mark3);
    }
}