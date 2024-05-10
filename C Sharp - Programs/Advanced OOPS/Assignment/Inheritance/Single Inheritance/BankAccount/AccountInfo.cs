using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BankAccount
{
    public class AccountInfo : PersonalInfo
    {
        public long AccountNumber {get; set;}
        public string BranchName {get; set;}
        public string IFSCCode {get; set;}
        public double Balance {get; set;}
        public AccountInfo(string name, string fatherName, long phone, string mail, DateTime dob, string gender, long accountNumber, string branchName, string ifscCode, double balance) : base (name, fatherName, phone, mail, dob, gender)
        {
            AccountNumber = accountNumber;
            BranchName = branchName;
            IFSCCode = ifscCode;
            Balance = balance;
        }
        public string ShowInfo()
        {
            return ($"{AccountNumber} | {BranchName} | {IFSCCode} | {Balance}");
        }
        public double Deposit(double amount)
        {
            double totalBalance = Balance + amount;
            Balance = totalBalance;
            return totalBalance;

        }
        public double WithDraw(double amount)
        {
            double totalAmount = Balance - amount;
            Balance = totalAmount;
            return totalAmount;

        }
        public double Showbalance()
        {
            return Balance;
        }
    }
}