using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCard
{
    public class TicketFairDetails
    {
        private static int s_ticketID = 3000;
        public string TicketID { get; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public double Fair {get; set;}
        public TicketFairDetails(string fromLocation, string toLocation, double fair)
        {
            s_ticketID++;
            TicketID = "MR" + s_ticketID;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            Fair = fair;
        }
        public TicketFairDetails(string ticket)
        {
            string[] values = ticket.Split(",");
            s_ticketID = int.Parse(values[0].Remove(0,2));
            TicketID = values[0];
            FromLocation = values[1];
            ToLocation = values[2];
            Fair = double.Parse(values[3]);
        }
    }
}