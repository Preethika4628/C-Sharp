using System;
namespace DoWhile;
class Program
{
    public static void Main(string[] args)
    {
        // int num = int.Parse(Console.ReadLine());
        // int rem=0, sum=0;
        // do
        // {
        //     rem = num % 10;
        //     sum = sum + rem;
        //     num = num / 10;

        // }while(!(num==0));
        // Console.WriteLine(sum);

        // //4. Do While
        // int num1 = int.Parse(Console.ReadLine());
        // int num2 = int.Parse(Console.ReadLine());
        // int result=0;
        // do
        // {
        //     for(int i=1; i<num1 || i<=num2; i++)
        //     {
        //         if((num1%i==0)&&(num2%i==0))
        //         {
        //             result = i;
        //         }
        //     }

        // }while(!(num1==0)&&(num2==0));
        // Console.WriteLine(result);

        // //6. Do While loop
        // int num = int.Parse(Console.ReadLine());
        // int rem, sum = 0;
        // do
        // {
        //     rem = num % 10;
        //     if(rem%2 != 0)
        //     {
        //         sum = sum + rem;
        //     }
        //     num = num/10;
        // }while(!(num==0));
        // if(sum%2==0)
        // Console.WriteLine("even");
        // else
        // Console.WriteLine("odd");

        //7. While loop
        //     long N = Convert.ToInt64(Console.ReadLine());
        //     long k = Convert.ToInt32(Console.ReadLine());
        //     long rem;
        //    int count=0, flag=0;
        //             while(N != 0)
        //             {
        //                 for(int i=0; i<=k; i++)
        //                 {
        //                     rem = N%10;
        //                     if(rem<=k)
        //                     count++;
        //                     else
        //                     flag++;
        //                     N = N/10;
        //                 }
        //             }
        //             if(flag>=1)
        //             Console.WriteLine("no");
        //             else
        //             Console.WriteLine("yes");

        // //8. While loop
        // int x = int.Parse(Console.ReadLine());
        //             int y = int.Parse(Console.ReadLine());
        //             if(x!=0 && y!=0)
        //             {
        //                 while(x != y)
        //                 {
        //                     if(x>y)
        //                         x=x-y;
        //                     else
        //                         y=y-x;
        //                 }
        //                 Console.WriteLine(x);
        //             }
        //             else if(x==0 && y==0)
        //             {
        //                 Console.WriteLine("-1");
        //             }

        // //10. While loop
        // int n = int.Parse(Console.ReadLine());
        // int n1 = n+1;
        // int count=0;
        // while(n != 0)
        // {
        //     for (int i = 1; count<3; i++)
        //         {
        //             if (n1 % i == 0)
        //             {
        //                 Console.WriteLine(n1);
        //                 count++;
        //                 n1++;
        //             }
        //         }

        // }


        // int rem, temp, sum = 0;
        // int number = int.Parse(Console.ReadLine());  

        //     temp = number;  
        //     while (number > 0)  
        //     {  
        //         rem = number % 10;  
        //         sum =sum+(rem*rem*rem);  
        //         number= number/ 10;  
        //     }  

        //     if (temp == sum)  
        //         Console.WriteLine(temp + " Is A Armstrong Number");  
        //     else  
        //         Console.WriteLine(temp + " Is Not A Armstrong Number");  
        //     Console.ReadKey();  


        // //10. Do while
        // int i, r, sum, temp;
        // int n = Convert.ToInt32(Console.ReadLine());
        // for (i = 0; i <= n; i++)
        // {
        //     temp = i;  
        //     sum = 0;  
        //     while (temp != 0)
        //     {
        //         r = temp % 10; 
        //         temp = temp / 10;  
        //         sum = sum + (r * r * r); 
        //     }
        //     if (sum == i)
        //         Console.WriteLine("{0} ", i); 
        // }
        // Console.Write("\n"); 

        // //6.Do while
        // double n = double.Parse(Console.ReadLine());
        // double sum=0;
        // do
        // {
        //     for(int i=1; i<=n;i++)
        //     {
        //         sum = sum + (1/i);
        //     }
        // }while(n!=0);
        // Console.WriteLine(sum);

        // //9. while loop
        // int n = int.Parse(Console.ReadLine());
        // int count = 0;
        // if (n > 0 && (n & (n - 1)) == 0)
        //     Console.WriteLine(n);
        // while(n != 0)
        // {
        //     n >>= 1;
        //     count += 1;
        // }
        // Console.WriteLine(1 << count);

        // //While - 10.return the array of three prime numbers comes next to n
        // int num = int.Parse(Console.ReadLine());
        // int count=0;
        // while(count<3)
        // {
        //     if(num<0)
        //     {
        //         num=1;
        //     }
        //     num++;
        //     for (int i = 2; i <num; i++) 
        //     {
        //         if(num%i == 0) 
        //         {
        //             num++;
        //             i=2;
        //         } 
        //         else
        //         {
        //             continue;
        //         }
        //     }
        // count++;
        // Console.WriteLine(num);
        // }

        // //DoWhile - ques 4. Printing patterns
        // int n = int.Parse(Console.ReadLine()); //5
        // int a = 1;
        // do
        // {
        //     for (int i = 1; i <= (n*2)-(a*2); i++)
        //     {
        //         Console.Write(' ');
        //     }
        //     for (int j = 1; j <= 2 * a - 1; j++)
        //     {
        //         Console.Write(a);
        //     }
        //     Console.WriteLine();
        //     a++;
        // }while(a<=n);

        //DoWhile - ques 5: Armstrong in the given range of numbers
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (IsArmstrong(i))
            {
                Console.WriteLine(i);
            }
        }
    }
        static Boolean IsArmstrong(int n)
        {
            int digit = 0;
            int sum = 0;
            Boolean res = false;
            int temp = n;
            while (temp > 0)
            {
                temp /= 10;
                digit++;
            }
            temp = n;
            while (temp > 0)
            {
                int t = temp % 10;
                sum += (int)Math.Pow(t, digit);
                temp /= 10;
            }
            if (sum == n)
            {
                res = true;
            }
            return res;
        }






        // int n = num+ 1;
        // int flag = 0;
        // int count = 0;
        // if(count<=3)
        // {
        //     for(int i=2; i<=11 ; i++)
        //     {
        //         if (n % i == 0) 
        //         { 
        //             flag = 0; 
        //             break; 
        //         }
        //     }
        // }




        //     for (int i = 2; i <= num / 2; i++) 
        //     { 
        //         if (num % i == 0) { 
        //             flag = 0; 
        //             break; 
        //         } 
        //     } 
        //     if (flag==1) { 
        //         Console.WriteLine("{0} is a prime number", num);
        //     } 
        //     else { 
        //         Console.WriteLine("{0} is not a prime number", num);
        //     }
    }
