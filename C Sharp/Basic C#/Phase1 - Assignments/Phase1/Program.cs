using System;
using System.Linq;
namespace Phase1;
class Program
{
    public static void Main(string[] args)
    {
        //Phase 1 Simple assignment - 1


        // // //Question 1:
        // // string s1 = Console.ReadLine();
        // // string s2 = s1.Trim(' ');
        // // Console.WriteLine(s2);

        // int[] array = new int[5];

        // for (int i = 0; i < array.Length; i++)
        // {
        // Console.WriteLine("Enter a number:");
        // int input = Convert.ToInt32(Console.ReadLine());
        // if (! array.Any(number => number == input))
        // {
        //     array[i] = input;
        //     Console.WriteLine("new\n");
        // }
        // else 
        // {
        //     Console.WriteLine("exists\n");
        // }
        // }

        // // Print the contents of array separated by ','
        // Console.WriteLine(string.Join(", ", array));
        // Console.ReadKey();

        // //ques 1: remove spaces, find length
        // string a = Console.ReadLine();
        // string[] mString = a.Split(' ');
        // string s1 = String.Join("",mString);
        // int n = mString.Length;
        // Console.WriteLine("Modified string: " + s1);
        // Console.WriteLine("Modified string: "+ n);

        // //ques 4: find whether k exists and k repeats
        // int n = int.Parse(Console.ReadLine());
        // string s = Console.ReadLine();
        // int k = int.Parse(Console.ReadLine());
        // string[] ch = s.Split(',');
        // int[] array = new int[n];
        // string[] result = new string[2];
        // string[] res = new string[1];
        // int count=0;
        // for(int i=0; i<n; i++)
        // {
        //     array[i] = int.Parse(ch[i]);
        // }
        // for(int i=0; i<n; i++)
        // {
        //     if(k == array[i])
        //     {
        //         result[0] = "yes";
        //         count++;
        //     }
        //     else
        //     {
        //         res[0] = "no";
        //     }
        // }
        // if(count>0)
        // {
        //     Console.WriteLine(result[0]+ " " + count);
        // }
        // else
        // {
        //     Console.WriteLine(res[0]);
        // }




        // int n = int.Parse(Console.ReadLine());
        // int rem, rev = 0;
        // while(n !=0 )
        // {
        //     rem = n%10;
        //     rev = rev*10+rem;
        //     n /= 10;          
        // }
        // Console.WriteLine(rev);

        

        
    }
}