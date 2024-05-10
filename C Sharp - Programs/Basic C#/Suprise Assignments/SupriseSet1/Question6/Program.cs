using System;
namespace Question6;
class Program 
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int num = n;
        for (int r = n; r >= 1; r--)
        {
            for (int c = 1; c <= n; c++)
            {
                if(c>r-1)
                {
                    Console.Write(c);
                }                
            }
            Console.WriteLine();
        }

    }
}