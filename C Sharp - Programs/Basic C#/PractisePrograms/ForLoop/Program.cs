using System;
namespace ForLoop;
class Program  
{
    public static void Main(string[] args)
    {
        // int n = int.Parse(Console.ReadLine());
        // int sum = 0;
        // for(int i = 1; i <= n; i++)
        // {
        //     sum += 2*i;
        // }
        // Console.WriteLine(sum);

        // int n = int.Parse(Console.ReadLine());
        // int sum = 0;
        // for(int i =1; i<=n ; i++)
        // {
        //     Console.WriteLine("{0}", i);
        //     sum += i;
        // }
        // Console.WriteLine(sum);

        // // while - q1
        // int[] arr = new int[10]{10, 20, 30, 40, 50, 60, 70, 80, 90,100};
        // int n = int.Parse(Console.ReadLine());
        // int i = 0;
        // while(n > arr[i])
        // {
        //     Console.WriteLine(arr[i]);
        //     i++;
        // } 

        // //while q2
        // int num = int.Parse(Console.ReadLine());
        // int rev = 0,rem;
        // while(num!=0)
        // {
        //     rem = num % 10;
        //     rev = rev * 10 + rem;
        //     num = num/10;
        // }
        // Console.WriteLine(rev);

        // //while q3
        // int n = int.Parse(Console.ReadLine());
        // int n1 = 0;
        // int n2 = 1;
        // int n3 = 0;
        // Console.WriteLine(n1);
        // Console.WriteLine(n2);
        // while(n3 < n)
        // {
        //     n3 = n1 + n2;
        //     Console.WriteLine(n3);
        //     n1 = n2;
        //     n2 = n3;
        // }


        // //6.ForLoop
        // int n = int.Parse(Console.ReadLine());
        // for(int i=1; i<=n; i++)
        // {
        //     Console.WriteLine(i*i*i);
        // }

        // //10. ForLoop
        // int n = int.Parse(Console.ReadLine());
        // for(int i=1; i<=n; i++)
        // {
        //     for(int j=1; j<=i; j++)
        //     {
        //         Console.Write(i + " ");
        //     }
        //     Console.WriteLine();
        // }

        // //9. For loop
        // int n = int.Parse(Console.ReadLine());
        // for(int i=1; i<=n; i++)
        // {
        //     for(int j=1; j<=n-i; j++)
        //     {
        //         Console.Write(' ');
        //     }
        //     for(int j=1; j<=2*i-1; j++)
        //     {
        //         Console.Write('*');
        //     }
        //     Console.WriteLine();
        // }

        // // 7.ForLoop
        // double n = double.Parse(Console.ReadLine());
        // double sum=0;
        // for(float i=1; i<=n; i++)
        // {
        //     sum += (1/i);
        //     Console.WriteLine(sum);
        // }

        // // 4.ForLoop
        // int n = int.Parse(Console.ReadLine());
        // double sum=0;
        // for(float i=1; i<=n; i++)
        // {
        //     sum += 1/i*(1/i);
        // }
        // Console.WriteLine(sum);

        // //8. ForLoop
        // int n = int.Parse(Console.ReadLine());
        // int sum=0, j=1;
        // for(int i=1; i<=n; i++)
        // {
        //     sum = sum + j;
        //     j = j*10 +1;
        // }
        // Console.WriteLine(sum);

        // //2. Shuffle cards
        // long n = Convert.ToInt32(Console.ReadLine());
        // long result = 1;
        // for(long i=n; i>=1; i--)
        // {
        //     result = result * i;
        // }
        // Console.WriteLine(result);

        //5. Sum of 2 number is equal to n
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for(int a=1; a<n; a++)
        {
            for(int b=1; b<n; b++)
            {
                if((a+b)==n)
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);

        



    }
}