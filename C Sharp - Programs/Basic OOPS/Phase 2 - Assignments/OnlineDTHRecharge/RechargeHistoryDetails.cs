using System;
namespace OnlineDTHRecharge
{
    public class RechargeHistoryDetails
    {
        public int s_rechargeID = 101;
        public string RechargeID {get;}
        public string UserID {get; set;}
        public string PackID {get; set;}
        public DateTime RechargeDate {get; set;}
        public int RechargeAmount {get; set;}
        public DateTime ValidTill {get; set;}
        public int NumberOfChannels {get; set;}

        public RechargeHistoryDetails(string userID, string packID, DateTime rechargeDate, int rechargeAmount, DateTime validTime, int numberOfChannels)
        {
            s_rechargeID = 101;
            RechargeID = "RP" + s_rechargeID;
            UserID = userID;
            PackID = packID;
            RechargeDate = rechargeDate;
            RechargeAmount = rechargeAmount;
            ValidTill = validTime;
            NumberOfChannels = numberOfChannels;
        }
    }
}