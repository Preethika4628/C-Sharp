using System;
namespace OnlineDTHRecharge;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("******ONLINE DTH RECHARGE******");
        Operation.AddDefaultData();
        Operation.MainMenu();
    }
}