using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank
{
    public enum AccountType {Savings, Balance}
    public class SavingAccount : IDInfo, ICalculate, IBankInfo
    {
        public long AccountNumber {get; set;}
        public AccountType AccountType {get; set;}
        public string BankName {get; set;}
        public string IFSC {get; set;}
        public string Branch {get; set;}
        
        public SavingAccount( string name, Gender gender, DateTime dob, long phone, double balance, string voterID, string aadharID, string panNumber, long accountNumber, AccountType accountType) : base( name,  gender,  dob,  phone,  balance,  voterID,  aadharID,  panNumber)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
        }
        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }
        public double Withdraw(double amount)
        {
            Balance -= amount;
            return Balance;
        }
        public double BalanceCheck()
        {
            return Balance;
        }
    }
}