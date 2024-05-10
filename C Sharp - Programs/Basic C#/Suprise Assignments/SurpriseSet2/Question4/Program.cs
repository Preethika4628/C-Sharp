using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char ch = 'A';
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(' ');
            }
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
            ch = (char)(ch + 2);
        }
    }
}