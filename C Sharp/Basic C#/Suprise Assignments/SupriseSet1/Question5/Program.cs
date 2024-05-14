using System;
using System.Linq;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string[] arr = str.Split(' ');
        string result, res, sample = "";
        int n = arr.Length;
        for(int i=0; i<n; i++)
        {
            result = arr[i];
            res = result.ToString();
            int n1 = res.Length;
            for(int j=n1-1; j>=0; j--)
            {
                if(j==0)
                {
                    sample = sample + res[j].ToString() + ' ';
                }
                else
                {
                    sample = sample + res[j].ToString();
                }
                
            }
            Console.WriteLine(sample.Trim());
        }
    }
}