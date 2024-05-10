using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string s1 = Console.ReadLine();
        string[] s = s1.Split(',');
        int[] arr = new int[n];
        // int[] arr1 = new int[n];
        string str = " ";
        string[] newA = new string[n];
        for(int i=0; i<n; i++)
        {
            arr[i]= int.Parse(s[i]);
        }
        int j=0;
        for(int i=0; i<n; i++)
        {
            if(arr[i] == i)
            {
                str = str + arr[i] + " ";
                j++;
            }
        }
        // for(int i=0; i<n; i++)
        // {
        //     Console.Write(arr1[i]+ " ");
        // }
        // for(int i=0; i<n; i++)
        // {
            Console.Write(str.Trim());
        // }
    }
}