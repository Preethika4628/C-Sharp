using System;
using System.Collections.Generic;
namespace BinarySearchStr;
class Program
{
    public static void Main(string[] args)
    {
        List<string> StrList = new List<string>();
        // string[] str = { "SF1001", "SF1002", "SF1003", "SF1004", "SF1005", "SF1006", "SF1007", "SF1008", "SF1009", "SF1010", "SF1011", "SF1012", "SF1013", "SF10014", "SF1015", "SF1016", "SF1017", "SF1018", "SF1019", "SF1020" };
        Console.WriteLine("Initial list:");
        foreach (string str in StrList)
        {
            Console.WriteLine(str);
        }
        StrList.Sort();

    }
}