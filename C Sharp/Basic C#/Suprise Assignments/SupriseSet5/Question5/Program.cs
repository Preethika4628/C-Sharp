using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        string[] arr = new string[n];
        arr = str.Split(',');
        int count=0;
        for(int i=0; i<n; i++)
        {
            if(arr[i] == "P")
            count++;
        }
        int result = count/n;
        if(count>=result-1 && count>1)
        {
            Console.WriteLine("Not Blacklisted");
        }
        else
        {
            Console.WriteLine("Blacklisted");
        }
    }
}
