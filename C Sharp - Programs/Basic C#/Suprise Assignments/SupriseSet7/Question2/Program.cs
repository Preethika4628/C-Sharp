using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for(int i=1; i<=n ; i++)
        {
            for(int j=1; j<=n; j++)
            {
                if(i==j || i+j==n+1)
                {
                    Console.Write("M ");
                }
                else if (i == 1 || j == 1 || i == n || j == n)
                {
                    Console.Write("F ");
                }
                else
                {
                    Console.Write("C ");
                }
                
            }
            Console.WriteLine();
        }
    }
}