using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCard
{
    public class BinarySearch
    {
        public static UserDetails LoginSearch(string searchElement)
        {
            CustomList<UserDetails> userList = Operations.userList;
            int left = 0; int right = userList.Count - 1;
            while (left <= right)
            {
                int middle = left + ((right - left) / 2);
                if (userList[middle].CardNumber == searchElement)
                {
                    return userList[middle];
                }
                else if (string.Compare(userList[middle].CardNumber, searchElement) < 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return null;
        }
        public static TicketFairDetails TicketFairSearch(string searchElement)
        {
            CustomList<TicketFairDetails> ticketList = Operations.ticketList;
            int left = 0; int right = ticketList.Count - 1;
            while (left <= right)
            {
                int middle = left + ((right - left) / 2);
                if (ticketList[middle].TicketID == searchElement)
                {
                    return ticketList[middle];
                }
                else if (string.Compare(ticketList[middle].TicketID, searchElement) < 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return null;
        }
        public static TravelDetails TravelSearch(string searchElement)
        {
            CustomList<TravelDetails> travelList = Operations.travelList;
            int left = 0; int right = travelList.Count - 1;
            while (left <= right)
            {
                int middle = left + ((right - left) / 2);
                if (travelList[middle].CardNumber == searchElement)
                {
                    return travelList[middle];
                }
                else if (string.Compare(travelList[middle].CardNumber, searchElement) < 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return null;
        }
    }
}