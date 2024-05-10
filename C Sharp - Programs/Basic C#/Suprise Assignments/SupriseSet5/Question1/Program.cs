using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        //SuperiseSet 5 - ques 1
        int n = int.Parse(Console.ReadLine());
        string s1 = Console.ReadLine();
        string[] s = s1.Split(',');
        int[] arr = new int[n];
        int result1 = 0, result2=0;
        for(int i=0; i<n; i++)
        {
            arr[i]= int.Parse(s[i]);
        }
        for(int i=0; i<3; i++)
        {
            result1 = result1 + arr[i];
        }
        for(int i=n-1; i>=n-3; i--)
        {
            result2 = result2 + arr[i];
        }
        if(result1==result2)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}