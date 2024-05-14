using System;

namespace Interface
{
    public interface IMarkDetails
    {
        //only prop and method and declaration allowed
        //by default public accedd modifiers
        int Mark1 {get; set;}
        int Mark2 {get; set;}
        int Mark3 {get; set;}
        void GetMarks(int mark1, int mark2, int mark3);
    }
}