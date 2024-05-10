using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        string[] arr = s.Split(',');
        int[] a1 = new int[n];
        int sum =0 ;
        for(int i=0; i<n; i++)
        {
            a1[i] = int.Parse(arr[i]);
        }
        for(int j=0; j<n ; j++)
        {
            sum = sum + a1[j];
        }
        if((sum%2==0) && (sum%3==0) && (sum%5==0))
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}