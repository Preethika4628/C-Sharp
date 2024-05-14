using System;
using System.Collections.Generic;
namespace EBBillCalculation;
class Program
{
    public static void Main(string[] args)
    {
        List<UserDetails> userList = new List<UserDetails>();
        int n;
        do
        {
            Console.WriteLine("****EB BILL CALCULATION****");
            Console.WriteLine("Choose: 1.Registration 2.Login 3.Exit");
            n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    string option = "";
                    option = option.ToLower();
                    do
                    {
                        Console.WriteLine("REGISTRATION FORM:");
                        Console.Write("Enter your name: ");
                        string userName = Console.ReadLine();
                        Console.Write("Enter your Phone number: ");
                        long phoneNumber = long.Parse(Console.ReadLine());
                        Console.Write("Enter your mailID: ");
                        string mailID = Console.ReadLine();
                        Console.Write("Enter the number of unit used: ");
                        int unitUsed = int.Parse(Console.ReadLine());

                        UserDetails user = new UserDetails(userName, phoneNumber, mailID, unitUsed);
                        Console.WriteLine("You have registered successfully");
                        Console.WriteLine("Your EB meterID is " + user.MeterID);
                        userList.Add(user);
                        Console.Write("Do you want to continue? ");
                        option = Console.ReadLine();

                    } while (option == "yes");
                    break;
                case 2:
                    bool flag = true;
                    Console.WriteLine("LOGIN:");
                    Console.Write("Enter meterID: ");
                    string meterID = Console.ReadLine();
                    foreach (UserDetails i in userList)
                    {

                        if (i.MeterID == meterID)
                        {
                            flag = false;
                            Console.WriteLine("Welcome " + i.UserName);
                            Console.WriteLine("Choose: 1.Calculate amount  2.Display user details  3.Exit");
                            int input = int.Parse(Console.ReadLine());
                            switch (input)
                            {
                                case 1:
                                    Console.WriteLine("EB bill");
                                    Console.WriteLine("User name: " + i.UserName);
                                    double amount = i.CalculateAmount();
                                    Console.WriteLine("Total amount need to pay for EB bill: " + amount);
                                    break;
                                case 2:
                                    Console.WriteLine("User Details");
                                    Console.WriteLine("User Name: " + i.UserName);
                                    Console.WriteLine("Phone number: " + i.PhoneNumber);
                                    Console.WriteLine("Mail ID: " + i.MailID);
                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.WriteLine("Invalid input");
                                    break;
                            }
                        }
                    }
                    if(flag)
                        {
                            Console.WriteLine("Invalid");
                            break;
                        }
                    break;
                case 3:
                    break;
            }
        } while (n != 3);
    }
}