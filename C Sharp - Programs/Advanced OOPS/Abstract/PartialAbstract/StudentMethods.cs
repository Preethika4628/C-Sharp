using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PartialAbstract
{
    public class StudentMethods
    {
        public partial void GetBalance(int amount)
        {
            _balance += amount;
        }
        public int ShowBalance()
        {
            return _balance;
        }
    }
}