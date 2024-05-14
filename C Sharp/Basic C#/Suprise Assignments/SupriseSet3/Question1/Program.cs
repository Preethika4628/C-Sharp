using System;
using System.Linq;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string s1 = Console.ReadLine();
        string[] temp = s1.Split(' ');
        int[] arr = new int[n];
        int[] nArr = new int[n-1];
        for(int i=0; i<n ; i++)
        {
            arr[i] = int.Parse(temp[i]);
        }
        for(int a=0; a<n-1; a++)
        {
            if(arr[a]>arr[a+1])
            {
                nArr[a] = arr[a];
            }
            else
            {
                nArr[a] = arr[a+1];
            }

        }
        for(int x=0; x<n-1; x++)
        {
            if(x==n-2)
            {
                Console.Write(nArr[x]);
            }
            else
            {
                Console.Write(nArr[x]+ " ");
            }
        }
    }
}