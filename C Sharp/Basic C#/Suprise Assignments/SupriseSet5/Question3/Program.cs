using System;
using System.Linq;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();
        string[] s1 = str1.Split(',');
        string[] s2 = str2.Split(',');
        bool flag = true;
        for(int i=0; i<n; i++)
        {
            if (!(s1[i] == s2[n-i-1]))
            {
                flag=false;
            }
        }
        if(flag)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }




        // for(int i=0; i<n; i++)
        // {
        //     while(arr[i]!=0)
        //     {
        //         rem = arr[i] % 10;
        //         rev = rem;
        //         arr[i] /= 10;
        //     }
        //     if(j<n)
        //     {
        //         ch[j] = rev.ToString();
        //         j++;
        //     }
        // }
        // Console.WriteLine(string.Join(',', ch));
        
        
        
    }
}