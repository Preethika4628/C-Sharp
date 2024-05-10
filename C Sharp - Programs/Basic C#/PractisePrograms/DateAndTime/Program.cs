using System;
using System.Data;
namespace DateAndTime;
class Program
{
    public static void Main(string[] args)
    {
        DateTime dob = new DateTime(2000,11,01); //object declaration syntax  //reference data type
                                        // year, month, date, hours, mins, sec
        Console.WriteLine(dob);
        Console.WriteLine(dob.ToString("dd/mm/yyyy"));
        Console.WriteLine(dob.ToString("dd/mm/yyyy hh:mm:ss ")); //12 hr format
        Console.WriteLine(dob.ToString("dd/mm/yyyy HH:mm:ss ")); //24 hr format
        Console.WriteLine(dob.ToString("dd/mm/yyyy")); //24 hr format
        Console.WriteLine(dob.ToString("tt ss:mm:hh yyyy/mm/dd"));

        //printing data indivually
        Console.WriteLine(dob.Day);
        Console.WriteLine(dob.Month);
        Console.WriteLine(dob.Year);
        Console.WriteLine(dob.DayOfWeek);

        //detailed data
        Console.WriteLine(dob.ToLongDateString());
        Console.WriteLine(dob.ToShortDateString());

        DateTime newData = dob.AddDays(11);
        Console.WriteLine(newData);

        DateTime today = DateTime.Now;

        // Console.Write(" Enter date in the mentioned format - dd/mm/yy : ");
        DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yy HH:mm:ss:fff tt", null);  
        Console.Write(data);

        // Console.Write(" Enter date in the mentioned format - dd/mm/yy : ");
        // DateTime data1 = DateTime.TryParseExact(Console.ReadLine(), "dd/mm/yyyy", null, System.Globalization.DateTimeStyles.None, out data1);
        // Console.Write(data);

        //timespan
        DateTime db = new DateTime(1999,10,11);
        TimeSpan span = today - dob;
        Console.WriteLine("Days" + span.TotalDays);
        Console.WriteLine("Hours" + span.TotalHours);
        Console.WriteLine("Minutes" + span.TotalMinutes);
        int age = span.Days/365;


        // //Practice Ass - ques 1 display day properties
        // DateTime dt = DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd HH:mm:ss.fff", null);
        // Console.WriteLine($"year = {dt.Year}");
        // Console.WriteLine($"month = {dt.Month}");
        // Console.WriteLine($"day = {dt.Day}");
        // Console.WriteLine($"hour = {dt.Hour}");
        // Console.WriteLine($"minute = {dt.Minute}");
        // Console.WriteLine($"second = {dt.Second}");
        // Console.WriteLine($"millisecond = {dt.Millisecond}");


        // //Practise Ass - ques 2 date after 40 days
        // DateTime dt = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);
        // DateTime newDate = dt.AddDays(40);
        // Console.WriteLine($"Date:{newDate.Date.ToString("dd/MM/yyyy")}");
        // Console.WriteLine($"Day:{newDate.DayOfWeek}");


        // //Practice Ass - ques 3 display past and future 15 years from the date mentioned
        // DateTime dt = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        // DateTime past = dt.AddYears(-15);
        // DateTime future = dt.AddYears(15);
        // Console.WriteLine("15 years before date is: "+past.ToString("dd/MM/yyyy"));
        // Console.WriteLine("After the date is: "+future.ToString("dd/MM/yyyy"));


        // //Practice ass - ques 4:
        // DateTime dt1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        // DateTime dt2 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        // if(dt1<dt2)
        // {
        //     Console.WriteLine("Past-Day");
        // }
        // else if(dt2>dt1)
        // {
        //     Console.WriteLine("Future-Day");
        // }
        // else
        // {
        //     Console.WriteLine("Today");
        // }
        

        // //Practice Ass - ques 5: number of days on specified month and year
        // //3. number of day in that month nd year
        // int month = int.Parse(Console.ReadLine());
        // int year = int.Parse(Console.ReadLine());
        // if(year%4==0 && year%100!=0)
        // {
        //     if(month==2)
        //     {
        //         Console.WriteLine(29);
        //     }
        // }
        // else if(month==1 || month==3 || month==5 || month==7 || month==8 || month==10 || month==12)
        // {
        //     Console.WriteLine(31);
        // }
        // else if(month==4 || month==6 || month==9 || month==11)
        // {
        //     Console.WriteLine(30);
        // }
        // else if(month==2)
        // {
        //     Console.WriteLine(28);
        // }
        // else
        // {
        //     Console.WriteLine(0);
        // }
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


        // //Practice prog - 6.leap year
        // int start = int.Parse(Console.ReadLine());
        // int end = int.Parse(Console.ReadLine());
        // for(int i=start; i<=end; i++ )
        // {
        //     if(((i%4==0) && !(i%100==0))||(i%400==0))
        //     {
        //         Console.WriteLine(i);
        //     }
            
        // }

        // //Practice prog - 7.Difference between two dates
        // DateTime dt1 = DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy", null);
        // DateTime dt2 = DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy", null);
        // TimeSpan resultDate = dt2.Subtract(dt1);
        // Console.WriteLine(resultDate.Days);

        // //Practice prog - 8.Salary calculation
        // int month = int.Parse(Console.ReadLine());
        // int year = int.Parse(Console.ReadLine());
        // int days = DateTime.DaysInMonth(year, month);
        // int salary = 500 * days;
        // Console.WriteLine(salary);

        // //Practice prog - 9.total min calculations
        // DateTime dt1 = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss", null);
        // DateTime dt2 = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss", null);
        // TimeSpan resultDate = dt2.Subtract(dt1);
        // Console.WriteLine(Math.Truncate(resultDate.TotalMinutes));

        //Practice prog - 10. Print the month name from the mentioned date
        DateTime dt = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);
        for (int i = 0; i < 12; i++)
	    {
	        Console.WriteLine(" {0}",dt.ToString("MMMM"));
	        dt = dt.AddMonths(1);
	    }
        



        // double n = double.Parse(Console.ReadLine());
        //         double sum=0;
        //         do
        //         {
        //             for(double i=1; i<=n;i++)
        //             {
        //                 sum = sum + (1/i);
        //             }
        //         }while(n==0);
        //         Console.WriteLine(sum);





    }
}