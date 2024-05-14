using System;
namespace DoWhile;
class Program
{
    public static void Main(string[] args)
    {
        string option = "";
        int num;
        do
        {
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            //Odd or Even
            if((num % 2) == 0)
            {
                Console.WriteLine($"{num} is an even number");
            }
            else
            {
                Console.WriteLine($"{num} is an odd number");
            }

            //yes or no
            while(true)
            {
                Console.WriteLine("Whether to repeat the process with another number? yes / no");
                option = Console.ReadLine();
                if(option.ToLower()=="yes" || option.ToLower()=="no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid, Only valid input is accepted");
                }
            }
        }while(option == "yes");
    }
}