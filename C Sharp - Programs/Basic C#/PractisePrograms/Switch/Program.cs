using System;
using System.Globalization;
using System.Reflection;
namespace Switch;
class Program 
{
    public static void Main(string[] args)
    {
        // //1. Grade
        // char g = char.Parse(Console.ReadLine());
        // string g1 = Char.ToString(g);
        // string grade = g1.ToUpper();

        // switch(grade)
        // {
        //     case "E":
        //         Console.WriteLine("Excellent");
        //         break;
        //     case "V":
        //         Console.WriteLine("Very Good");
        //         break;
        //     case "G":
        //         Console.WriteLine("Good");
        //         break;
        //     case "A":
        //         Console.WriteLine("Average");
        //         break;
        //     case "F":
        //         Console.WriteLine("Fail");
        //         break;
        //     default:
        //         Console.WriteLine("Invalid Grade");
        //         break;
        // }

        //2.Odd r Even
        // int num = int.Parse(Console.ReadLine());
        // int option;
        // if (num % 2 == 0)
        // {
        //     option = 1;
        // }
        // else
        // {
        //     option = 2;
        // }


        // switch(option)
        // {
        //     case 1:
        //         Console.WriteLine("Even Number");
        //         break;
            
        //     case 2:
        //         Console.WriteLine("Odd Number");
        //         break;
        // }

        // // 4. perform calculation with menus
        // int num1 = int.Parse(Console.ReadLine());
        // int num2 = int.Parse(Console.ReadLine());
        // int choice = int.Parse(Console.ReadLine());
        // switch(choice)
        // {
        //     case 1:
        //         Console.WriteLine(num1 + num2);
        //         break;
        //     case 2:
        //         Console.WriteLine(num1 - num2);
        //         break;
        //     case 3:
        //         Console.WriteLine(num1 * num2);
        //         break;
        //     case 4:
        //         Console.WriteLine(num1 / num2);
        //         break;
        //     default:
        //          Console.Writeline(0);
        //          break;
        // }

        
        // //5. Vowels r not
        // char alpha = char.Parse(Console.ReadLine());
        // string a1 = Char.ToString(alpha);
        // string letter = a1.ToUpper();

        // switch(letter)
        // {
        //     case "A":
        //         Console.WriteLine("The alphabet is a vowel.");
        //         break;
        //     case "E":
        //         Console.WriteLine("The alphabet is a vowel.");
        //         break;
        //     case "I":
        //         Console.WriteLine("The alphabet is a vowel.");
        //         break;
        //     case "O":
        //         Console.WriteLine("The alphabet is a vowel.");
        //         break;
        //     case "U":
        //         Console.WriteLine("The alphabet is a vowel.");
        //         break;
        //     default:
        //         Console.WriteLine("The alphabet is not a vowel.");
        //         break;
        // }


        // //3. number of day in that month nd year
        // int month = int.Parse(Console.ReadLine());
        // int year = int.Parse(Console.ReadLine());
        // // if(year%4==0 && year%100!=0)
        // // {
        // //     if(month==2)
        // //     {
        // //         Console.WriteLine(29);
        // //     }
        // // }
        // // else if(month==1 || month==3 || month==5 || month==7 || month==8 || month==10 || month==12)
        // // {
        // //     Console.WriteLine(31);
        // // }
        // // else if(month==4 || month==6 || month==9 || month==11)
        // // {
        // //     Console.WriteLine(30);
        // // }
        // // else if(month==2)
        // // {
        // //     Console.WriteLine(28);
        // // }
        // // else
        // // {
        // //     Console.WriteLine(0);
        // // }
        // switch(month)
        // {
        //     case 1:
        //     case 3:
        //     case 5:
        //     case 7:
        //     case 8:
        //     case 10:
        //     case 12:
        //         Console.WriteLine(31);
        //         break;
        //     case 4:
        //     case 6:
        //     case 9:
        //     case 11:
        //         Console.WriteLine(30);
        //         break;
        //     case 2:
        //         if(((year%4==0) && !(year%100==0))||(year%400==0))
        //         {
        //             Console.WriteLine(29);
        //             break;
        //         }
        //         else
        //         {
        //             Console.WriteLine(28);
        //             break;
        //         }

        //     default:
        //         Console.WriteLine(0);
        //         break;
        // }


        // //6.maximun number
        // int num1 = int.Parse(Console.ReadLine());
        // int num2 = int.Parse(Console.ReadLine());
        // int option;
        // if(num1>num2)
        // {
        //     option = 1;
        // }
        // else if(num1<num2)
        // {
        //     option = 2;
        // }
        // else
        // {
        //     option=3;
        // }
        // switch(option)
        // {
        //     case 1:
        //         Console.WriteLine(num1);
        //         break;
        //     case 2:
        //         Console.WriteLine(num2);
        //         break;
        //     case 3:
        //         Console.WriteLine("Numbers are equal");
        //         break;
        // }

        // //7.Days of teh week
        // int day = int.Parse(Console.ReadLine());
        // switch(day)
        // {
        //     case 1:
        //         Console.WriteLine("Sunday");
        //         break;
        //     case 2:
        //         Console.WriteLine("Monday");
        //         break;
        //     case 3:
        //         Console.WriteLine("Tuesday");
        //         break;
        //     case 4:
        //         Console.WriteLine("Wednesday");
        //         break;
        //     case 5:
        //         Console.WriteLine("Thursday");
        //         break;
        //     case 6:
        //         Console.WriteLine("Friday");
        //         break;
        //     case 7:
        //         Console.WriteLine("Saturday");
        //         break;
        //     default:
        //         Console.WriteLine("Invalid number");
        //         break;
        // }

        // //8.Season of the given month
        // string s1 = Console.ReadLine();
        // string month = s1.ToLower();
        // switch(month)
        // {
        //     case "january":
        //     case "february":
        //     case "december":
        //         Console.WriteLine("Winter");
        //         break;
        //     case "march":
        //     case "april":
        //     case "may":
        //         Console.WriteLine("Spring");
        //         break;
        //     case "june":
        //     case "july":
        //     case "august":
        //         Console.WriteLine("Summer");
        //         break;
        //     case "september":
        //     case "october":
        //     case "november ":
        //         Console.WriteLine("Rainfall");
        //         break;
        //     default:
        //         Console.WriteLine("Unknown");
        //         break;
        // }

        // //9.Character - upper r lower case
        // char c = char.Parse(Console.ReadLine());
        // if(c>='a' && c<='z')
        // {
        //     Console.WriteLine("The character is a lowercase character.");
        // }
        // else if(c>='A' && c<='Z')
        // {
        //     Console.WriteLine("The character is an uppercase character.");
        // }
        // else
        // {
        //     Console.WriteLine("The character is not an alphabet.");
        // }

        // //10. Character - alphabet/digit/number
        // char c = char.Parse(Console.ReadLine());
        // int count = 0;
        // if((c>='a' && c<='z') || (c>='A' && c<='Z'))
        // {
        //     count = 1;
        // }
        // else if(c>='0' && c<='9')
        // {
        //     count = 2;
        // }
        // else
        // {
        //     count = 3;
        // }
        // switch(count)
        // {
        //     case 1:
        //         Console.WriteLine("The character is an alphabet.");
        //         break;
        //     case 2:
        //         Console.WriteLine("The character is a digit.");
        //         break;
        //     case 3:
        //         Console.WriteLine("The character is a special character.");
        //         break;
        // }

    }
}