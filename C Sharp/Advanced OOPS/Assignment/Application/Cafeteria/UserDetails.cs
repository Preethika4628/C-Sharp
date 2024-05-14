using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class UserDetails : PersonalDetails, IBalance
    {
        private static int s_userID = 1000;
        public string UserID { get; }
        public string WorkStationNumber { get; set; }
        private double _balance { get; set; }
        public double WalletBalance {get{ return _balance;}}
        public UserDetails(string name, string fatherName, long mobile, string emailID, Gender gender, string workstationNumber, double walletBalance) : base(name, fatherName, mobile, emailID, gender)
        {
            s_userID++;
            UserID = "SF" + s_userID;
            WorkStationNumber = workstationNumber;
            _balance = walletBalance;
        }
        public void WalletRecharge(double amount)
        {
            _balance += amount;
        }
        public void DeductAmount(double amount)
        {
           _balance -= amount;                
        }
        public UserDetails(string user)
        {
            string[] values = user.Split(",");
            s_userID = int.Parse(values[0].Remove(0,2));
            UserID = values[0];
            Name = values[1];
            FatherName = values[2];
            Mobile = long.Parse(values[3]);
            EmailID = values[4];
            Gender = Enum.Parse<Gender>(values[5], true);
            WorkStationNumber = values[6];
            _balance = double.Parse(values[7]);
        }
    }
}