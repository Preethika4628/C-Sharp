using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncStays
{
    public enum BookingStatus { Default, Initated, Booked, Cancelled}
    public class BookingDetails
    {
        private static int s_bookingID = 100;
        public string BookingID {get; set;}
        public string UserID {get; set;}
        public double TotalPrice {get; set;}
        public DateTime DateOfBooking {get; set;}
        public BookingStatus BookingStatus {get; set;}
        public BookingDetails(string userID, double totalPrice, DateTime dateOfBooking, BookingStatus bookingStatus)
        {
            s_bookingID++;
            BookingID = "BID" + s_bookingID;
            UserID = userID;
            TotalPrice = totalPrice;
            DateOfBooking = dateOfBooking;
            BookingStatus = bookingStatus;
        }
        public BookingDetails(string booking)
        {
            string[] val = booking.Split(",");
            BookingID = val[0];
            s_bookingID =int.Parse(val[0].Remove(0,3));
            UserID = val[1];
            TotalPrice = double.Parse(val[2]);
            DateOfBooking = DateTime.ParseExact(val[3],"dd/MM/yyyy",null);
            BookingStatus = BookingStatus.Parse<BookingStatus>(val[4]);
        }

    }
}