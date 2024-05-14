using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncfusionLibrary
{
    public enum Status
    {
        Default, Borrowed, Returned
    }
    public class BorrowDetails
    {
        public static int s_borrowerID = 2000;
        public string BorrowerID {get; set;}
        public string UserID {get; set;}
        public string BookID {get; set;}
        public DateTime BorrowedDate {get; set;}
        public int BorrowerBookCount {get; set;}
        public Status Status {get; set;}
        public int PaidFineAmount {get; set;}
        public BorrowDetails(string userID, string bookID, DateTime borrowDate, int borrowerBookDate, Status status, int paidFineAmount)
        {
            s_borrowerID++;
            BorrowerID = "LB" + s_borrowerID;
            UserID = userID;
            BookID = bookID;
            BorrowedDate = borrowDate;
            BorrowerBookCount = borrowerBookDate;
            Status = status;
            PaidFineAmount = paidFineAmount;            
        }
    }
}