using System;
namespace OnlineDTHRecharge
{
    public class UserDetails
    {
        public static int s_userID = 1000;
        public string UserID { get; }
        public string UserName { get; set; }
        public long MobileNumber { get; set; }
        public string EmailID { get; set; }
        public double WalletBalance { get; set; }

        public UserDetails(string userName, long mobileNumber, string emailID, double walletbalance)
        {
            s_userID++;
            UserID = "UID" + s_userID;
            UserName = userName;
            MobileNumber = mobileNumber;
            EmailID = emailID;
            WalletBalance = walletbalance;
        }

        public void Recharge(double amount)
        {
            double TotalAmount = WalletBalance + amount;
            Console.WriteLine($"Total amount in the Wallet: {TotalAmount}");
        }
    }
}