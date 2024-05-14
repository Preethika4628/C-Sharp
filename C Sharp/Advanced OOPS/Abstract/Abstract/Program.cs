using System;
using System.Collections.Generic;
namespace Abstract;
class Program
{
    public static void Main(string[] args)
    {
        Syncfusion syncfusion = new Syncfusion("SF4628", "Preethi", "Syncfusion");
        TCS tcs = new TCS("TS4512", "Chandaran", "TCS");
        List<Salary> salary = new List<Salary>();
        salary.Add(syncfusion);
        salary.Add(tcs);

    }
}