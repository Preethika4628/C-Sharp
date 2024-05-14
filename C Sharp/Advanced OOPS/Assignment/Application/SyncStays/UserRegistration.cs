using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncStays
{
    public class UserRegistration : PersonalDetails, IWalletManager
    {
        private static int s_userID = 1000;
        public string UserID {get; set;}
        private double _balance {get; set;}
        public double WalletBalance {get{ return _balance;}}
        public UserRegistration(string userName, long mobileNumber, long aadharNumber, string address, FoodType foodType, Gender gender, double walletBalance) : base ( userName,  mobileNumber,  aadharNumber,  address,  foodType,  gender)
        {
            s_userID++;
            UserID = "SF" + s_userID;
            _balance = walletBalance; 
        }
        public UserRegistration(string user)
        {
            string[] val = user.Split(",");
            UserID = val[0];
            s_userID = int.Parse(val[0].Remove(0,2));
            UserName = val[1];
            MobileNumber = long.Parse(val[2]);
            AadharNumber = long.Parse(val[3]);
            Address = val[4];
            FoodType = Enum.Parse<FoodType>(val[5], true);
            Gender = Enum.Parse<Gender>(val[6], true);
            _balance = double.Parse(val[7]);
        }
         
        public void WalletRecharge(double amount)
        {
            _balance += amount;
        }

        public void DeductBalance(double amount)
        {
            _balance -= amount;
        }
    }
}