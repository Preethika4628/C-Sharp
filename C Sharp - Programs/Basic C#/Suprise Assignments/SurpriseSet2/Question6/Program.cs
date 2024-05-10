using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        int n1 = s1.Length;
        int n2 = s2.Length;
        int num = 1;
        int count = 0;
        if (n1 == n2)
        {
            count = 1;
        }
        else if (n1 < n2)
        {
            for (int i = n1; i < n2; i++)
            {
                s1 = s1 + num;
                num++;
            }
            count = 1;
        }
        else if (n1 > n2)
        {
            for (int i = n2; i < n1; i++)
            {
                s2 = s2 + num;
                num++;
            }
            count = 1;
        }
        int n = s1.Length;
        string result = "";
        if (count == 1)
        {
            for (int i = 0; i < n; i++)
            {
                result = result + s1[i] + s2[i];
            }
            Console.WriteLine(result);
        }
    }
}