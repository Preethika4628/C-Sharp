using System;
namespace medium;
class Program 
{
    public static void Main(string[] args)
    {
        // int rows = 6, columns = 20;
        // print_rectangle(rows, columns);

        // static void print_rectangle(int n, int m)
        // {
        //     int i, j;
        //     for (i = 1; i <= n; i++)
        //     {
        //     for (j = 1; j <= m; j++)
        //     {
        //         if (i == 1 || i == n || 
        //             j == 1 || j == m)            
        //         Console.Write("*");            
        //         else
        //         Console.Write(" ");            
        //     }
        //     Console.WriteLine();
        //     }
        // }

        // double N = double.Parse(Console.ReadLine());
        // double W = double.Parse(Console.ReadLine());
        // double L = double.Parse(Console.ReadLine());
        // double M = double.Parse(Console.ReadLine());
        // double O = double.Parse(Console.ReadLine());
        // double square = N * N;
        // double tile = W * L;
        // double bench = O * M;
        // double TotalArea = square - bench;
        // double area = TotalArea / tile;
        // double TotalTime = 0.2 * area;
        // Console.WriteLine("Number of tiles needed "+ area);
        // Console.WriteLine("Total time for changing " + Math.Round(TotalTime));

        // //7.check whether the given date is holiday or not
        // DateTime dt1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        // int n = int.Parse(Console.ReadLine());
        // DateTime[] dateArr = new DateTime[n];
        // int flag = 0;
        // for(int i=0; i<n; i++)
        // {
        //     dateArr[i] = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        // }
        // string FDay = dt1.DayOfWeek.ToString();
        
        // if(FDay == "Sunday" || FDay == "Saturday")
        // {
        //     flag=1;
        // }
        // else if(n>0)
        // {
        //     for(int i=0; i<n; i++)
        //     {
        //         if(dt1 == dateArr[i])
        //         {
        //             flag=1;
        //         }
        //     }
        // }
        // else
        // {
        //     flag=2;
        // }

        // if(flag==1)
        // {
        //     Console.WriteLine("Holiday:-)");
        // }
        // else
        // {
        //     Console.WriteLine("Not an Holiday:-(");
        // }

        //10.Count total number of alpha, digits, special characters
        string str = Console.ReadLine();
        char[] s1 = str.ToCharArray();
        // int n = s1.Length;
        // Console.WriteLine("The number of Alphabets in the string is: "+ CountAlpha(s1));
        // Console.WriteLine("The number of Digits in the string is: "+ CountStr());
        // Console.WriteLine("The number of Special characters in the string is: "+ CountSpl());
          

    }

    static void CountAlpha(string s1)
    {
        for(int i=0; i<s1.Length; i++)
        {
            if((s1[i]>='a' && s1[i]<='z') || (s1[i]>='A' && s1[i]<='Z'))
            {

            }
        }
    }
}