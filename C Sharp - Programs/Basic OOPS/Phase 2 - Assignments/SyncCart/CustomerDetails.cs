using System;
namespace SyncCart
{
    public class CustomerDetails
    {
        private static int s_customerID = 3000;
        public string CustomerID { get; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public long PhoneNumber { get; set; }
        public double WalletBalance { get; set; }
        public string EmailID { get; set; }

        public CustomerDetails(string customerName, string city, long phoneNumber, double walletBalance, string emailID)
        {
            s_customerID++;
            CustomerID = "CID" + s_customerID;
            CustomerName = customerName;
            City = city;
            PhoneNumber = phoneNumber;
            WalletBalance = walletBalance;
            EmailID = emailID;
        }
        
        public void Recharge(double amount)
        {
            double TotalAmount = WalletBalance + amount;
            Console.WriteLine($"Total amount in the Wallet: {TotalAmount}");
        }
        public void DeductAmount(double TotalAmount)
        {
            WalletBalance = WalletBalance - TotalAmount;
            // Console.WriteLine($"Total amount in the Wallet: {TotalAmount}");
        }
    }
}