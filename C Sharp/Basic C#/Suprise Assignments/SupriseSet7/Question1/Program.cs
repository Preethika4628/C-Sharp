using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 1;
        for(int r=1; r<=n; r++)
        {
            int num = count;
            for(int c=1; c<=r ; c++)
            {
                Console.Write(num);
                Console.Write(' ');
                num += n-c;
            }
            count++;
            Console.WriteLine();
        }
    }
}