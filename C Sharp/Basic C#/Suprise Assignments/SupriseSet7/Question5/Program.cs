using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        int[] arr = new int[n];
        string[] s1 = s.Split(' ');
        for(int i=0; i<n; i++)
        {
            arr[i] = int.Parse(s1[i]);
        }
        Array.Sort(arr);
        if(arr[1] == arr[2])
        {
            if(arr[2]<arr[3])
            {
                Console.WriteLine(arr[3]);
            }
        }
        else if(arr[1]<arr[2])
        {
            Console.WriteLine(arr[2]);
        }
    }
}