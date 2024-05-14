using System;
namespace EBBillCalculation
{
    public class UserDetails
    {
        private static int s_meterID = 1001;
        public string MeterID { get; }
        public string UserName { get; set; }
        public long PhoneNumber { get; set; }
        public string MailID { get; set; }
        public int UnitUsed { get; set; }

        public UserDetails( string userName, long phoneNumber, string mailID, int unitUsed)
        {
            s_meterID++;
            MeterID = "EB" + s_meterID;
            UserName = userName;
            PhoneNumber = phoneNumber;
            MailID = mailID;
            UnitUsed = unitUsed;

        }

        public double CalculateAmount()
        {
            return UnitUsed*5;
        }
    }
}