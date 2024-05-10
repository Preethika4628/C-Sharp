using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int a = n;
        for (int r = 1; r < n; r++)
        {
            for (int c = 1; c <= a; c++)
            {

                if (r == 1)
                {
                    Console.Write(c);
                }
                else if (c == 1)
                {
                    Console.Write(c);
                }
                Console.Write(c);
            }
            Console.WriteLine();
            a--;
        }
        // for (int j = i; j <= n; j++)
        // {
        //     if (i == 1 || j == i || j == n)
        //         Console.Write(j + " ");
        //     else
        //         Console.Write(" ");
        // }
        // Console.WriteLine();
    }
}