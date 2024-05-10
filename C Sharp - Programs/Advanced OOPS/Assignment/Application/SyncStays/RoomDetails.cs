using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncStays
{
    public enum RoomType {Select, Standard, Delux, Suit}
    public class RoomDetails
    {
        private static int s_roomID = 100;
        public string RoomID {get; set;}
        public RoomType RoomType {get; set;}
        public int NumberOfBeds {get; set;}
        public double PricePerDay {get; set;}
        public RoomDetails(RoomType roomType, int numberOfBeds, double pricePerDay)
        {
            s_roomID++;
            RoomID = "RID" + s_roomID;
            RoomType = roomType;
            NumberOfBeds = numberOfBeds;
            PricePerDay = pricePerDay;
        }
        public RoomDetails(string room)
        {
            string[] val = room.Split(",");
            RoomID = val[0];
            s_roomID = int.Parse(val[0].Remove(0,3));
            RoomType = RoomType.Parse<RoomType>(val[1]);
            NumberOfBeds = int.Parse(val[2]);
            PricePerDay = int.Parse(val[3]);
        }
    }
}