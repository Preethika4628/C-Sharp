using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeReg
{
    public sealed class EmployeeInfo
    {
        private static int s_userID = 1000;
        public string UserID {get;}
        public int KeyInfo = 100;
        public string Password {get; set;}
        public EmployeeInfo(string password)
        {
            Password = password;
        }
        public void UpdateInfo()
        {

        }
        public void DisplayInfo()
        {

        }
    }
}