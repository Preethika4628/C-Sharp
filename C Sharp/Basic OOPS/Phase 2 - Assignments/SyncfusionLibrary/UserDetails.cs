using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncfusionLibrary
{
    public enum Gender
    {
        Select, Male, Female
    }
    public enum DepartmentType
    {
        Select, ECE, EEE, CSE
    }
    public class UserDetails
    {
        public static int s_userID = 3000;
        public string UserID { get; }
        public string UserName { get; set; }
        public Gender Gender { get; set; }
        public DepartmentType Department { get; set; }
        public long MobileNumber { get; set; }
        public string MailID { get; set; }
        public double WalletBalance { get; set; }

        public UserDetails()
        {
            Department = DepartmentType.Select;
        }
        public UserDetails(string userName, Gender gender, DepartmentType department, long mobileNumber, string mailID, double walletBalance)
        {
            s_userID++;
            UserID = "SF" + s_userID;
            UserName = userName;
            Gender = gender;
            Department = department;
            MobileNumber = mobileNumber;
            MailID = mailID;
            WalletBalance = walletBalance;
        }
        public void Recharge(double amount)
        {
            double TotalAmount = WalletBalance + amount;
            Console.WriteLine($"Total amount in the Wallet: {TotalAmount}");
        }
    }
}