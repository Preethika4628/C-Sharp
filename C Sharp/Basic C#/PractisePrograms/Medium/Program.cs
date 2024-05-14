using System;
using System.Diagnostics;
using System.Linq;
namespace Medium;
class Program
{
    public static void Main(string[] args)
    {

        //Phase 1 assignment-1 : 1.remove the whitespaces and return the length
        string a = Console.ReadLine(); 
        string[] mString = a.Split(' ');
        Console.WriteLine(mString);
        int n = mString.Length;
        Console.WriteLine("Modified string: " + mString);
        Console.WriteLine("Modified string: "+ n);





        // int n = int.Parse(Console.ReadLine());
        // for(int i=4; i<n; i++)
        // {
        //     if(i%2==0 && i%4==0)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }

        // int start = int.Parse(Console.ReadLine());
        // int dif = int.Parse(Console.ReadLine());
        // int n = int.Parse(Console.ReadLine());
        // int result = 0;
        // int count = 1;
        // for(int i=start; count<=n ; i=i+dif)
        // {
        //     result = result+i;
        //     count++;
        // }
        // Console.WriteLine(result);

        // long n = long.Parse(Console.ReadLine());
        // long result = 1;
        // for(long i=n; i>0; i--)
        // {
        //     result = result * i;
        // }
        // Console.WriteLine(result);

        // int basic = int.Parse(Console.ReadLine());
        // int hra = basic * 20/100;
        // int da = basic * 80/100;
        // int ASalary = basic + hra + da;
        // int tax = ASalary;


        // int basic = int.Parse(Console.ReadLine());
        // if(basic <= 10000)
        // {
        //     int hra = basic * 20/100;
        //     int da = basic * 80/100;
        //     int MSalary = basic + hra + da;
        //     int aSalary = MSalary * 12;
        //     int tax = aSalary * 6/100;
        //     int insu = aSalary * 1/100;
        //     int TSalary = aSalary - tax - insu;
        //     Console.WriteLine("Annual Gross Salary: " + aSalary);
        //     Console.WriteLine("Annual Take-Home Salary: " + TSalary);
        // }
        // else if(basic <= 20000)
        // {
        //     int hra = basic * 25/100;
        //     int da = basic * 90/100;
        //     int MSalary = basic + hra + da;
        //     int aSalary = MSalary * 12;
        //     int tax = aSalary * 6/100;
        //     int insu = aSalary * 1/100;
        //     int TSalary = aSalary - tax - insu;
        //     Console.WriteLine("Annual Gross Salary: " + aSalary);
        //     Console.WriteLine("Annual Take-Home Salary: " + TSalary);
        // }
        // else if(basic > 20000)
        // {
        //     int hra = basic * 30/100;
        //     int da = basic * 95/100;
        //     int MSalary = basic + hra + da;
        //     int aSalary = MSalary * 12;
        //     int tax = aSalary * 6/100;
        //     int insu = aSalary * 1/100;
        //     int TSalary = aSalary - tax - insu;
        //     Console.WriteLine("Annual Gross Salary: " + aSalary);
        //     Console.WriteLine("Annual Take-Home Salary: " + TSalary);
        // }
        // else
        // {
        //     Console.WriteLine("Enter valid amount");
        // }

        
        // float salary = float.Parse(Console.ReadLine());
        // float month = float.Parse(Console.ReadLine());
        // float year = float.Parse(Console.ReadLine());
        // float leave = float.Parse(Console.ReadLine());
        // if(year%4==0 && year%100==0 && month==2)
        // {
        //     if(month==2)
        //     {
        //         float dSalary = salary/29;
        //         float lsalary =leave * dSalary;
        //         float TSalary = salary - lsalary;
        //         Console.WriteLine("Take-Home Salary: " + Math.Round(TSalary, 2));
        //     }
        // }
        // else
        // {
        //     if(month==2)
        //     {
        //         float dSalary = salary/28;
        //         float lsalary =leave * dSalary;
        //         float TSalary = salary - lsalary;
        //         Console.WriteLine("Take-Home Salary: " + Math.Round(TSalary, 2));
        //     }
        //     else if(month==1 || month==3 || month==5 || month==7 || month==8 || month==10 || month==12)
        //     {
        //         float dSalary = salary/31;
        //         float lsalary =leave * dSalary;
        //         float TSalary = salary - lsalary;
        //         Console.WriteLine("Take-Home Salary: " + Math.Round(TSalary, 2));
        //     }
        //     else if(month==4 || month==6 || month==9 || month==11)
        //     {
        //         float dSalary = salary/30;
        //         float lsalary =leave * dSalary;
        //         float TSalary = salary - lsalary;
        //         Console.WriteLine("Take-Home Salary: " + Math.Round(TSalary, 2));
        //     }
        // }



        // int n = int.Parse(Console.ReadLine());
        // string s1 = n.ToString();
        // int len = s1.Length;
        // int rem, num = n;
        // int result = 0;
        // Console.WriteLine(len);
        // for(int i=len;i>0;i--)
        // {
        //     rem = num%10;
        //     Console.WriteLine(rem);
        //     result = result + rem*len;
        //     num = num/10;
        // }
        // Console.WriteLine(result);


        // DateTime date1 = DateTime.Parse(Console.ReadLine());
        // DateTime date2 = DateTime.Parse(Console.ReadLine());
        // // Console.WriteLine(date1.ToString("dd/mm/yyyy HH:mm:ss"));
        // // Console.WriteLine(date2);
        // // TimeSpan age = date2.Subtract(date1);
        // double s1 = date2.Year;
        // double s2 = date1.Year;
        // double age = s1-s2-1;
        // TimeSpan mon = (date2.Hour) - (date1.Hour);
        // Console.WriteLine(mon);
        // // Console.WriteLine("Age : " + age);
        // // Console.WriteLine("Day : " + date2.DayOfWeek);
        // // Console.WriteLine("Number of days : " + Math.Round(age*377.26));
        // // Console.WriteLine("Number of hours : " + Math.Round(age*377.26*24));
        // // Console.WriteLine("Number of minutes : " + Math.Round(age*377.26*24*60));
        
        // // Console.WriteLine("Number of days : " + Math.Round(age*365));
        // // Console.WriteLine("Number of hours : " + Math.Round(age*365*24));
        // // Console.WriteLine("Number of minutes : " + Math.Round(age*365*24*60));


    }
}