using System;
namespace WhileLoopExe1;
class Program
{
    public static void Main(string[] args)
    {
        //Exercise 1
        Console.WriteLine("EXERCISE 1:");
        int i = 2;
        while(i<=25)
        {
            if((i % 2) == 0)
            {
                Console.WriteLine(i);
            }
            i++;   
        }

        Console.WriteLine();

        //Exercise 2
        Console.WriteLine("EXERCISE 2:");
        int output = 0;
        Console.Write("Enter a number: ");
        bool isValid = int.TryParse(Console.ReadLine(), out output);
        while( !isValid )
        {
            Console.Write("Invalid number. Please enter the input in number format: ");
            isValid = int.TryParse(Console.ReadLine(), out output);
        }
        Console.Write("The number is " + output);
    }
}