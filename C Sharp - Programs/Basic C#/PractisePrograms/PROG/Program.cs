using System;
namespace PROG;
class Program 
{
    public static void Main(string[] args)
    {
        {
            int i = 0;
            int digitCount = 0;
            int[] digitArray = new int[10];
            double sum = 0;
            int number = int.Parse(Console.ReadLine());
            int temporaryNumber = number;
            while (number > 0)
            {
                digitArray[i++] = number % 10;
                number = number / 10;
                digitCount++;
            }
            for (i = 0; i < digitCount; i++)
            {
                sum += Math.Pow(digitArray[i], digitCount);
            }
            if (sum == temporaryNumber)
            {
                Console.WriteLine($"The Number {temporaryNumber} is armstrong");
            }
            else
            {
                Console.WriteLine($"The Number {temporaryNumber} is not armstrong");
            }

            Console.ReadLine();
        }
    }
}