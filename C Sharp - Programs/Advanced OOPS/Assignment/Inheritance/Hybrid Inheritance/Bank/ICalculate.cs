using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank
{
    public interface ICalculate
    {
        double Deposit(double amount);
        double Withdraw(double amount);
        double BalanceCheck();
    }
}