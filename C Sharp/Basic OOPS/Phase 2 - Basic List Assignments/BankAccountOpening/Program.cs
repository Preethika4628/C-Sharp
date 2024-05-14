using System;
using System.Collections.Generic;
namespace BankAccountOpening;
class Program
{
    static BankDetails currentLoginCustomer;
    public static void Main(string[] args)
    {
        List<BankDetails> BankList = new List<BankDetails>();
        bool flag = true;
        int option = 0;
        do
        {
            Console.WriteLine("Choose one of the option: 1.Registration 2.Login 3.Exit");
            switch (option)
            {
                case 1:
                    flag = false;
                    Console.WriteLine("Bank Account Opening Detrails:");
                    Console.WriteLine("Enter your name: ");
                    string customerName = Console.ReadLine();
                    Console.Write("Select your gender: 1.Male 2.Female 3.Transgender");
                    Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
                    Console.Write("Enter your phone number: ");
                    long phone = long.Parse(Console.ReadLine());
                    Console.Write("Enter your date of birth in dd//MM//yyyy: ");
                    DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    Console.Write("Enter your mailID: ");
                    string mailID = Console.ReadLine();
                    break;

                case 2:
                    flag = false;
                    Console.WriteLine("Login");
                    Console.Write("Enter your CustomerID: ");
                    string customerID = Console.ReadLine();
                    foreach (BankDetails i in BankList)
                    {
                        if (i.CustomerID == customerID)
                        {
                            currentLoginCustomer = i;
                            Console.WriteLine("Welcome " + i.CustomerName);
                            Console.WriteLine("Choose: \n1.Deposit \n2.Withdrawal \n3.Balance Check \n4.Exit");
                            int n = int.Parse(Console.ReadLine());
                            switch (n)
                            {
                                case 1:
                                    Console.WriteLine("Enter the amount: ");
                                    double amount = double.Parse(Console.ReadLine());
                                    double TotatlRAmount = i.Deposit(amount); //1500
                                    currentLoginCustomer.Balance = TotatlRAmount;
                                    Console.WriteLine("Total amount: " + amount);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the amount: ");
                                    double amount1 = double.Parse(Console.ReadLine());
                                    double TotatlRAmount1 = i.Withdrawal(amount1); //1500
                                    currentLoginCustomer.Balance = TotatlRAmount1;
                                    Console.WriteLine("Total amount: " + amount1);
                                    break;
                                case 3:
                                    Console.WriteLine($"The total amount in your balance is {i.Balance}");
                                    break;
                                case 4:
                                    Console.WriteLine("Exitting the Application");
                                    flag = false;
                                    break;
                            }
                        }
                    }
                    break;
            }

        } while (flag);
    }
}