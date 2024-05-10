using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string s1 = Console.ReadLine();
        string[] temp = s1.Split(' ');
        int[] arr = new int[n];
        int[] nArr = new int[n];
        for(int i=0; i<n ; i++)
        {
            arr[i] = int.Parse(temp[i]);
        }
        int x=0;
        for(int j=0; j<n; j++)
        {
            if(arr[j]>0)
            {
                nArr[x] = arr[j];
                x++;
            }
        }
        for(int y=0; y<n; y++)
        {
            if(y==n-1)
            {
                Console.Write(nArr[y]);
            }
            else
            {
                Console.Write(nArr[y]+" ");
            }
        }
    }
}