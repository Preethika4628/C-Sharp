using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        string[] arr = str.Split(',');
        int[] a1 = new int[n];
        int [] a2 = new int[n];
        for(int i=0; i<n; i++)
        {
            a1[i] = int.Parse(arr[i]);
        }
        for(int i=0; i<n; i++)
        {
            a2[i] = int.Parse(arr[i]);
        }
        Array.Sort(a1);
        int max = a1[0];
        for(int i=0; i<n; i++)
        {
            if(max == a2[i])
            {
                Console.WriteLine("Dealer " + i);
            }
        }
    }
}