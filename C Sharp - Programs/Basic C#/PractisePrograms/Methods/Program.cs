using System;
using System.Diagnostics.Metrics;
using System.Globalization;
namespace Methods;
class Program 
{
    // public static void Main(string[] args)
    // {     
    //     int result = Add(1, 2);
    //     Sub(9, 2);
    //     Sub(10, 5);
    //     int output = Mul();
    //     Division();
    //     Console.WriteLine(result);
    // }
    // static int Add(int num1, int num2)
    //     {
    //         int result = num1 + num2;
    //         return num2;
    //     }
    
    // static void Sub(int num1, int num2)
    // {
    //     int result = num1-num2;
    //     Console.WriteLine(result);
    // }
    // static int Mul()
    // {
    //     int num1 = 10;
    //     int num2 = 2; 
    //    return num1 * num2;
    // }
    // static void Division()
    // {
    //     int num1 = 10;
    //     int num2 = 2; 
    //     Console.WriteLine("Result "+num1/num2);
    // }




    // public static void Main(string[] args)                                  //for Add
    // {
    //     int a = 10;
    //     int b = 20;
    //     int result = Add(a, b);
    //     Console.WriteLine(result);

    //     // int Add(int a, int b)
    //     // {
    //     //     int c = a+b;
    //     //     return c;
    //     // }
        
    // }
    // static int Add(int a, int b) //method with arg and return
    //     {
    //         int c = a+b;
    //         return c;
    //     }

   
   
//    //method - ques 1
//    public static void Main(string[] args)
//    {
//     int a = int.Parse(Console.ReadLine());
//     int b = int.Parse(Console.ReadLine());
//     int result = add(a,b);
//     Console.WriteLine(result);

//     static int add(int a, int b)
//     {
//         int c = a+b;
//         return c;
//     }
//    }


// //method - ques 2
// public static void Main(string[] args)
// {
//     string s1 = Console.ReadLine();
//     int num = counter(s1);
//     Console.WriteLine(num);

//     static int counter(string s1)
//     {
//         int n = s1.Split(' ').Length-1;
//         return n;
//     }
// }


// //method - ques 3
// public static void Main(string[] args)
// {
//     int n = int.Parse(Console.ReadLine());
//     int[] arr = new int[n];
//     for(int i=0; i<arr.Length;i++)
//     {
//         arr[i] = int.Parse(Console.ReadLine());
//     }
//     int result = Add(arr);
//     Console.WriteLine(result);


//     static int Add(int[] arr)
//     {
//         int sum=0;
//         for(int i=0; i<arr.Length;i++)
//         {
//             sum = sum + arr[i];
//         }
//         return sum;
//     }
// }


// // method - ques 4 - swap
// public static void Main(string[] args)
// {
//     int a = int.Parse(Console.ReadLine());
//     int b = int.Parse(Console.ReadLine());
//     swap(a, b);

//     static void swap(int x, int y)
//     {
//         int temp = y;
//         y = x;
//         x = temp;
//         // (x, y) = (y, x);
//         Console.WriteLine("First number: "+x);
//         Console.WriteLine("Second number: "+y);
//     }

// }


public static void Main(string[] args)
{
    int num = int.Parse(Console.ReadLine());
    prime(num);

    static void prime(int num)
    {
        int flag = 1;
        if((num == 0) || (num == 1) || (num < 0))
        {
            Console.WriteLine("{0} is not a Prime Number", num);
        }
        else
        {
            for (int i = 2; i <= num / 2; i++) 
            { 
                if (num % i == 0) { 
                    flag = 0; 
                    break; 
                } 
            } 
            if (flag==1) { 
                Console.WriteLine("{0} is a prime number", num);
            } 
            else { 
                Console.WriteLine("{0} is not a prime number", num);
            }
        }
        
    }
}

// }

// //max and percentage of marks
// public static void Main(string[] args)
// {
//     double mark1 = double.Parse(Console.ReadLine());
//     double mark2 = double.Parse(Console.ReadLine());
//     double mark3 = double.Parse(Console.ReadLine());
//     percentage(mark1, mark2, mark3);
//     MaxMark(mark1, mark2, mark3);
// }
// static void percentage(double mark1, double mark2, double mark3)
// {
//     double sum = mark1+mark2+mark3;
//     double avg = sum/300;
//     double percent = avg * 100;
//     Console.WriteLine(percent);
// }
// static void MaxMark(double mark1, double mark2, double mark3)
// {
//     double result;
//     if(mark1>mark2 && mark1>mark3)
//     {
//         result = mark1;
//     }
//     else if(mark2>mark1 && mark2>mark3)
//     {
//         result = mark2;
//     }
//     else 
//     {
//         result = mark3;
//     }
//     Console.WriteLine(result);
// }



// public static void Main(string[] args)
// {
//     //Phase 1 Simple assignmnet - Ques 11
//         int N = int.Parse(Console.ReadLine());
//         Console.WriteLine(PrimeCheck(N));

//         static int PrimeCheck(int num)
//         {
//             int N = int.Parse(Console.ReadLine());
//             int flag = 1; 
//             for (int i = 2; i <= N / 2; i++) { 
//                 if (N % i == 0) { 
//                     flag = 0; 
//                     break; 
//                 } 
//             } 
//             if (flag==1) { 
//                 Console.WriteLine("{0} is not a prime number", N);
//             } 
//             else { 
//                 Console.WriteLine("{0} is not a prime number", N);
//             }
//         }
// }


// //Phase 1 Simple assignment - Ques 15 - Get the name from teh user and print the wecome msg using methods
// public static void Main(string[] args)
// {
//     string name = Console.ReadLine();
//     Console.WriteLine(first(name)+second());

//     static string first(string name)
//     {
//         string str1 = "Welcome ";
//         return str1 + name + ". ";
//     }

//     static string second()
//     {
//         return "Have a nice day!";
//     }
// }


// public static void Main(string[] args)
// {
//     int n1 = int.Parse(Console.ReadLine());
//     int n2 = int.Parse(Console.ReadLine());
    
//     static int swap(int a, int b)
//     {
        
//     }
// }


//calculation operator
// public static void Main(string[] args)
// {
//     int num1 = int.Parse(Console.ReadLine());
//     int num2 = int.Parse(Console.ReadLine());
//     char option = char.Parse(Console.ReadLine());
//     switch(option)
//     {
//         case '+':
//             Add(num1, num2);
//             break;
//         case '-':
//             Sub(num1, num2);
//             break;
//         case '*':
//             Mul(num1, num2);
//             break;
//         case '/':
//             Div(num1, num2);
//             break;
//         default:
//             Console.WriteLine("Select a valid symbol");
//             break;
//     }

// }
//     static void Add(int num1, int num2)
//     {
//         int result = num1+num2;
//         Console.WriteLine(result);
//     }
//     static void Sub(int num1, int num2)
//     {
//         int result = num1-num2;
//         Console.WriteLine(result);
//     }
//     static void Mul(int num1, int num2)
//     {
//         int result = num1*num2;
//         Console.WriteLine(result);
//     }
//     static void Div(int num1, int num2)
//     {
//         int result = num1/num2;
//         Console.WriteLine(result);
//     }


// //Practice Prog - 8.Find Nth digit
// public static void Main(string[] args)
// {
//     string number = Console.ReadLine();
//     int index = int.Parse(Console.ReadLine());
//     int digit = FindDigit(number, index);
//     Console.WriteLine(digit);
// }
// static int FindDigit(string number, int index)
//     {
//         if(index<1 || index>number.Length)
//         {
//             Console.WriteLine(0);
//         }
//         char[] ch = number.ToCharArray();
//         Array.Reverse(ch);
//         string reverse = new string(ch);
//         char digitChar = reverse[index-1];
//         int digit = int.Parse(digitChar.ToString());
//         return digit;
//     }

}