using System;
namespace IfStatment;
class Program
{
    public static void Main(string[] args)
    {
        // //1. print int in string
        // int num = int.Parse(Console.ReadLine());
        // if(num>0 && num<9)
        // {
        //     if(num == 1)
        //     {
        //         Console.WriteLine("one");
        //     }
        //     else if(num == 2)
        //     {
        //         Console.WriteLine("two");
        //     }
        //     else if(num == 3)
        //     {
        //         Console.WriteLine("three");
        //     }
        //     else if(num == 4)
        //     {
        //         Console.WriteLine("four");
        //     }
        //     else if(num == 5)
        //     {
        //         Console.WriteLine("five");
        //     }
        //     else if(num == 6)
        //     {
        //         Console.WriteLine("six");
        //     }
        //     else if(num == 7)
        //     {
        //         Console.WriteLine("seven");
        //     }
        //     else if(num == 8)
        //     {
        //         Console.WriteLine("eight");
        //     }
        //     else if(num == 9)
        //     {
        //         Console.WriteLine("nine");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Number is too big. Enter a number between 0 to 9");
        // }


        // //3. speed info classifier
        // int speed = int.Parse(Console.ReadLine());
        // if(speed>=0 && speed<=10)
        // {
        //     Console.WriteLine("slow");
        // }
        // else if(speed>10 && speed<=50)
        // {
        //     Console.WriteLine("average");
        // }
        // else if(speed>50 && speed<=150)
        // {
        //     Console.WriteLine("fast");
        // }
        // else if(speed>150 && speed<=1000)
        // {
        //     Console.WriteLine("ultra fast");
        // }
        // else if(speed>1000)
        // {
        //     Console.WriteLine("extremely fast");
        // }

        // // 4. Temperature
        // int temp = int.Parse(Console.ReadLine());
        // if(temp<0)
        // {
        //     Console.WriteLine("Freezing weather");
        // }
        // else if(temp>=0 && temp<=10)
        // {
        //     Console.WriteLine("Very cold weather");
        // }
        // else if(temp>11 && temp<=20)
        // {
        //     Console.WriteLine("Cold weather");
        // }
        // else if(temp>21 && temp<=30)
        // {
        //     Console.WriteLine("Normal in Temperature");
        // }
        // else if(temp>31 && temp<=40)
        // {
        //     Console.WriteLine("Its Hot");
        // }
        // else
        // {
        //     Console.WriteLine("Its Very Hot");
        // }

        // //5. Leap year
        // int year = int.Parse(Console.ReadLine());
        // if(year%400==0 || year%100!=0 && year%4==0)
        // {
        //     Console.WriteLine(year + " is a leap year.");
        // }
        // else
        // {
        //     Console.WriteLine(year + " is not a leap year.");
        // }

        // //6.Largest number
        // int a = int.Parse(Console.ReadLine());
        // int b = int.Parse(Console.ReadLine());
        // int c = int.Parse(Console.ReadLine());
        // if(a>b && a>c)
        // {
        //     Console.WriteLine(a);
        // }
        // else if(b>a && b>c)
        // {
        //     Console.WriteLine(b);
        // }
        // else
        // {
        //     Console.WriteLine(c);
        // }

        //7.number to text

        // //8.Range check
        // int N = int.Parse(Console.ReadLine());
        // int L = int.Parse(Console.ReadLine());
        // int R = int.Parse(Console.ReadLine());
        // if(N>L && N<R)
        // {
        //     Console.WriteLine("yes");
        // }
        // else
        // {
        //     Console.WriteLine("no");
        // }

        // //9. Odd r Even - Sum check
        // int a = int.Parse(Console.ReadLine());
        // int b = int.Parse(Console.ReadLine());
        // int sum = a+b;
        // if(sum%2==0)
        // {
        //     Console.WriteLine("Even");
        // }
        // else
        // {
        //     Console.WriteLine("Odd");
        // }

        // //10. Traingle r not
        // int a = int.Parse(Console.ReadLine());
        // int b = int.Parse(Console.ReadLine());
        // int c = int.Parse(Console.ReadLine());
        // if(a+b > c  &&  b+c > a  &&  c+a > b)
        // {
        //     Console.WriteLine("yes");
        // }
        // else
        // {
        //     Console.WriteLine("no");
        // }

        // //11.Stone, Paper, scissor
        // char choice1 = char.Parse(Console.ReadLine());
        // char choice2 = char.Parse(Console.ReadLine());
        // if((choice1=='P' && choice2=='R') || (choice1=='R' && choice2=='S') || (choice1=='S' && choice2=='P') || (choice1=='P' && choice2=='S') || (choice1=='R' && choice2=='P') || (choice1=='S' && choice2=='R'))
        // {
        //     Console.WriteLine("Winner: "+choice1);
        // }
        // else if(choice1 == choice2)
        // {
        //     Console.WriteLine("Winner: D");
        // }
        // else
        // {
        //     Console.WriteLine("Winner: "+choice2);
        // }

        //7. Number to text
        string[] onesDigit = new string[]{"zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "tweleve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
        string[] tenDigit = new string[]{"","ten","twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred"};
        int num = int.Parse(Console.ReadLine());
        if(num==0)
        {
            Console.WriteLine("Zero");
        }
        else if(num < 20)
        {
            Console.WriteLine(onesDigit[num]);
        }
        else
        {
            string temp = num % 10 == 0 ? "" : " " + onesDigit[num % 10];
            Console.WriteLine($"{tenDigit[num/10]}{temp}");
        }
    }
}