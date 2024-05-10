using System;
namespace IfCondition;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the mark: ");
        int mark = int.Parse(Console.ReadLine());
        if((mark > 80) && (mark <= 100))
        {
            Console.Write("Grade A");
        }
         else if((mark > 60) && (mark <= 80) )
        {
            Console.Write("Grade B");
        }
        else if((mark >= 36 )&&(mark <= 60))
        {
            Console.Write("Grade C");
        }
        else if((mark >= 0)&&(mark < 36))
        {
            Console.Write("Grade D");
        }
        else
        {
            Console.Write("Invalid Input");
        }
        
    }
}