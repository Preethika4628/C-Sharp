using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncStays
{
    public class RoomSelection
    {
        private static int s_selection = 1000;
        public string SelectionID {get; set;}
        public string BookingID {get; set;}
        public string RoomID {get; set;}
        public DateTime StayingDateFrom {get; set;}
        public DateTime StayingDateTo {get; set;}
        public double Price {get; set;}
        public double NumberOfDays {get; set;}
        public BookingStatus BookingStatus {get; set;}
        public RoomSelection(string bookingID, string roomID, DateTime stayingDateFrom, DateTime stayingDateTo, double price, double numberOFDays, BookingStatus bookingStatus)
        {
            s_selection++;
            SelectionID = "SID" + s_selection;
            BookingID = bookingID;
            RoomID = roomID;
            StayingDateFrom = stayingDateFrom;
            StayingDateTo = stayingDateTo;
            Price = price;
            NumberOfDays = numberOFDays;
            BookingStatus = bookingStatus;
        }
        public RoomSelection(string selection)
        {
            string[] val = selection.Split(",");
            SelectionID = val[0];
            s_selection =int.Parse(val[0].Remove(0,3));
            BookingID = val[1];
            RoomID = val[2];
            StayingDateFrom = DateTime.Parse(val[3]);
            StayingDateTo = DateTime.Parse(val[4]);
            Price = double.Parse(val[5]);
            NumberOfDays = double.Parse(val[6]);
            BookingStatus = Enum.Parse<BookingStatus>(val[7]);
        }
    }
}