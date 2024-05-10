using System;
namespace OnlineDTHRecharge
{
    public class PackDetails
    {
        public string PackID { get; set;}
        public string PackName { get; set;}
        public int Price { get; set;}
        public int Validity { get; set;}
        public int NumberOfChannels { get; set;}

        public PackDetails(string packID, string packName, int price, int validity, int numberOfChannels)
        {
            PackID = packID;
            PackName = packName;
            Price = price;
            Validity = validity;
            NumberOfChannels = numberOfChannels;
        }
    }
}