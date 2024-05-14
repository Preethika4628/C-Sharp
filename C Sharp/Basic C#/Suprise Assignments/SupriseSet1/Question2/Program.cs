using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum=0;
        for (int i = 1; i <= n; i++)
        {
            if (IsPrime(i))
            {
                int a = i%10;
                if(a==3)
                {
                    sum += i;
                }
            }
        }
        Console.WriteLine(sum);
    }
    static bool IsPrime(int n)
    {
        if (n == 1 || n == 0)
        {
            return false;
        }
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}