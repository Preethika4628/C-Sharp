using System;
namespace Bank;
class Program
{
    public static void Main(string[] args)
    {
        SavingAccount account = new SavingAccount("Preethika", Gender.Female, DateTime.Today, 987456321, 50000, "VID987453", "AID28963741", "PID9874123456", 98745619632, AccountType.Savings);
        Console.WriteLine(account.BalanceCheck());
        Console.WriteLine(account.Deposit(500));
        Console.WriteLine(account.Withdraw(20000));
        
    }
}