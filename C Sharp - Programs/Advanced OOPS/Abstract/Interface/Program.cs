using System;
using System.Collections.Generic;
namespace Interface;
class Program 
{
    public static void Main(string[] args)
    {
        // IMarkDetails mark = new IMarkDetails(); //Object can't be created for abstract type
        StudentDetails student = new StudentDetails(70, 80, 90);

        IMarkDetails mark = new StudentDetails(70, 50, 80);
        Console.WriteLine(mark.Mark1);
        IMarkDetails mark1 = new MarkSheet(50, 80, 60);
        Console.WriteLine(mark1.Mark1);

        List<IMarkDetails> markDetails = new List<IMarkDetails>();
        markDetails.Add(student);
        markDetails.Add(mark);
        markDetails.Add(mark1);

    }
}