using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCard
{
    public class UserDetails : PersonalDetails, IBalance
    {
        private static int s_cardNumber = 1000;
        public string CardNumber {get;}
        public double Balance {get; set;}
        public UserDetails(string userName, long phoneNumber, double balance) : base(userName, phoneNumber)
        {
            s_cardNumber++;
            CardNumber = "CMR" + s_cardNumber;
            Balance = balance;
        }
        public void WalletRecharge(double amount)
        {
            Balance += amount;
        }
        public void DeductBalance(double amount)
        {
            Balance -= amount;
        }
        public UserDetails(string user)
        {
            string[] values = user.Split(",");
            s_cardNumber = int.Parse(values[0].Remove(0,3));
            CardNumber = values[0];
            UserName = values[1];
            PhoneNumber = long.Parse(values[2]);
            Balance = double.Parse(values[3]);
        }
        
    }
}