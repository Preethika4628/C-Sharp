using System;
namespace BankAccountOpening
{
    public enum Gender
    {
        Select, Male, Female, TransGender
    }
    public class BankDetails
    {
        private static int s_customerID = 1001;
        public string CustomerID { get; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }
        public Gender Gender { get; set; }
        public long Phone { get; set; }
        public DateTime DOB { get; set; }
        public string MailID { get; set; }

        public BankDetails(string CustomerName)
        {
            Gender = Gender.Select;
        }
        public BankDetails(string customerName, double balance, Gender gender, long phone, DateTime dob, string mailID)
        {
            s_customerID++;
            CustomerID = "HDFC" + s_customerID;
            CustomerName = customerName;
            Balance = balance;
            Gender = gender;
            Phone = phone;
            DOB = dob;
            MailID = mailID;
        }

        public double Deposit(double amount)
        {
            double balance = Balance += amount;
            return balance;
        }
        public double Withdrawal(double amount)
        {
            double balance = Balance -= amount;
            return balance;
        }
    }
}