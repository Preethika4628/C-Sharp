using System;
using System.Linq;
namespace Phase1;
class Program 
{
    public static void Main(string[] args)
    {
        // // //Phase 1 Simple assignment 1 - Ques 7
        // int i = 0;
        // int large = 0;
        // int n = int.Parse(Console.ReadLine());
        // int[] arr = new int[n];
        // for (i = 0; i < arr.Length; i++) {
        //     arr[i] = int.Parse(Console.ReadLine());
        // }
        // large = arr[0];
        // for (i = 1; i < arr.Length; i++) {
        //     if (large < arr[i])
        //     large = arr[i];
        // }
        // Console.WriteLine(large);


        // //Phase 1 Simple assignment 1 - Ques 10
        // int i,len;
        // String myStr = Console.ReadLine();
        // len = myStr.Length;
        // for(i=0; i<len; i++) {
        //     if(myStr[i] =='a' || myStr[i]=='e' || myStr[i]=='i' || myStr[i]=='o' || myStr[i]=='u' || myStr[i]=='A' || myStr[i]=='E' || myStr[i]=='I' || myStr[i]=='O' || myStr[i]=='U') {
        //         Console.Write(myStr[i]);
        //     } else {
        //         continue;
        //     }
        // }


        // //Phase 1 Simple assignmnet - Ques 11
        // int num, i, ctr = 0;
        // num = int.Parse(Console.ReadLine());
        // for (i = 2; i <= num; i++)
        // {
        //     if (num % i == 0)
        //     {
        //         ctr++;
        //         break;
        //     }
        // }
        // if (ctr == 0 && num != 1)
        // {
        //     Console.Write("{0} is a prime number", num);
        // }
        // else
        // {
        //     Console.Write("{0} is not a prime number", num);
        // }

        // //Phase 1 Simple assignmnet - Ques 12
        // DateTime dt = DateTime.Parse(Console.ReadLine());
        // Console.WriteLine("The day of the week for {0:d} is {1}", dt.ToString("MM/dd/yyyy"), dt.DayOfWeek);


        // //Phase 1 Simple assignmnet - Ques 14
        // int Count = 0; 
        // string str = Console.ReadLine();
        // str = str.ToLower();            
        // for(int i = 0; i < str.Length; i++)
        // {
        //     if(str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u') 
        //     {
        //         Count++;  
        //     }
        // }
        // Console.WriteLine(Count);


        // int columns = int.Parse(Console.ReadLine());
        // int rows = int.Parse(Console.ReadLine());
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


        // int i = 0;
        // int n = int.Parse(Console.ReadLine());
        // string s1 = Console.ReadLine();
        // int[] arr = new int[n];
        // for (i = 0; i < s1.Length; i++) {
        //     arr[i] = int.Parse(s1);
        // }
        // int max = arr[0];
        // for (i = 1; i < arr.Length; i++)
        //     if (arr[i] > max)
        //         max = arr[i];
        // Console.WriteLine(max);

        //  //diamond star print
        // int i, j, count = 1; 
        //    int n = int.Parse(Console.ReadLine());  
        //    count = n - 1;  
        //    for (j = 1; j <= n; j++)  
        //    {  
        //        for (i = 1; i <= count; i++)  
        //            Console.Write(" ");  
        //        count--;  
        //        for (i = 1; i <= 2 * j - 1; i++)  
        //            Console.Write("*");  
        //        Console.WriteLine();  
        //    }  
        //    count = 1;  
        //    for (j = 1; j <= n - 1; j++)  
        //    {  
        //        for (i = 1; i <= count; i++)  
        //            Console.Write(" ");  
        //        count++;  
        //        for (i = 1; i <= 2 * (n - j) - 1; i++)  
        //            Console.Write("*");  
        //        Console.WriteLine();  
        //    }


        // // Phase 1 - Simple assignments: ques 10-
        // int n = int.Parse(Console.ReadLine());
        // for(int i=1; i<=n; i++)
        // {
        //     for(int j=1; j<=i; j++)
        //     {
        //         Console.Write(i);
        //     }
        //     Console.WriteLine();
        // }



        // //ques 7. print the largest number in the array
        // int n = int.Parse(Console.ReadLine());
        // string s1 = Console.ReadLine();
        // string[] s2 = s1.Split(' ');
        // int[] arr = new int[n];
        // for(int i=0; i<n ; i++)
        // {
        //     arr[i] = int.Parse(s2[i]);
        // }
        // Array.Sort(arr);
        // int max = arr[n-1];
        // Console.WriteLine(max);

        // //ques 8. display odd r even of the given numbers
        // int n = int.Parse(Console.ReadLine());
        // string s1 = Console.ReadLine();
        // string[] str = s1.Split(' ');
        // int[] arr = new int[n];
        // string[] newStr = new string[n];
        // for(int i=0; i<n; i++)
        // {
        //     arr[i] = int.Parse(str[i]);            
        // }
        // for(int i=0; i<n; i++)
        // {
        //     if(arr[i] % 2 == 0)
        //     {
        //         str[i] = "even";
        //     }
        //     else
        //     {
        //         str[i] = "odd";
        //     }
        // }
        // string N = String.Join(' ',str);
        // Console.WriteLine(N);

        // //9. SUm of the number in array is odd r even
        // int n = int.Parse(Console.ReadLine());
        // string s1 = Console.ReadLine();
        // string[] str = s1.Split(',');
        // int[] arr = new int[n];
        // string[] newStr = new string[n];
        // int sum = 0;
        // for(int i=0; i<n; i++)
        // {
        //     arr[i] = int.Parse(str[i]);            
        // }
        // for(int i=0; i<n; i++)
        // {
        //     sum += arr[i];
        // }
        // if(sum % 2 == 0)
        // {
        //     Console.WriteLine("even");
        // }
        // else
        // {
        //     Console.WriteLine("odd");
        // }
                //7.
                int n = int.Parse(Console.ReadLine());
                int s = int.Parse(Console.ReadLine());
                int result = 0;
                int product=1;
                if(s==1)
                {
                    Console.WriteLine(n);
                }
                else if(s==0 || s<0)
                {
                    Console.WriteLine("1");
                }
                else if(s==2)
                {
                    for(int i=s; s>0; s--)
                    {
                        result = n*n;
                    }
                    Console.WriteLine(result);
                }
                else if(s==3)
                {
                    for(int i=s; s>0; s--)
                    {
                        result = n*n*n;
                    }
                    Console.WriteLine(result);
                }
                else
                {
                    for(int i=0; i<s; s++)
                    {
                        product *= n;
                    }
                    Console.WriteLine(product);
                }

            
    }
}