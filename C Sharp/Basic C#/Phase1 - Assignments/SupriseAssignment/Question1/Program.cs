using System;
using System.Globalization;
using System.Linq;
namespace Question1;

class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        char[] ch = str.ToCharArray();
        int j = 0;
        string[] s1 = str.Split(',');
        // int arr[] = str.Split(',').Select(int.Parse).ToArray();
        // Console.WriteLine(ch[0]);
        for(int i=0;i<ch.Length; i=i+2)
        {
            for (j = 2; j < ch.Length; j=j+2) 
            {
                if (ch[i] > ch[i+j])
                {
                    Console.WriteLine(ch[j]);
                }
            }

        }
        // Console.WriteLine(large);
            


        // int large = 0;
        // // int n = int.Parse(Console.ReadLine());
        // int[] arr = new int[n];
        // // for (i = 0; i < arr.Length; i++) {
        // //     arr[i] = int.Parse(Console.ReadLine());
        // // }
        // large = arr[0];
        // // for (i = 1; i < arr.Length; i++) {
        // //     if (large < arr[i])
        // //     large = arr[i];
        // }
        // // Console.WriteLine(large);


    }
}