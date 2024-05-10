using System;
namespace BankAccount;
class Program 
{
    public static void Main(string[] args)
    {
        AccountInfo account = new AccountInfo("Preethika", "Sathish", 987456321, "preethi@gmail.com", new DateTime(2000, 11, 01), "Female", 5412639879517, "Chinnamplayam", "SBI0548", 50000);
        Console.WriteLine(account.ShowInfo());
        Console.Write("Enter the amount to be deposited: ");
        double amount = double.Parse(Console.ReadLine());
        Console.WriteLine(account.Deposit(amount));
        Console.Write("Enter the amount to be withdrawn: ");
        double cash = double.Parse(Console.ReadLine());
        Console.WriteLine(account.WithDraw(cash));
        Console.WriteLine(account.Showbalance());




    }
}