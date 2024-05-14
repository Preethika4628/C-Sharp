using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncStays
{
    public class Search
    {
        public static UserRegistration BinarySearch(string searchElement)
        {
            List<UserRegistration> userList = Operations.userList;
            int left = 0;
            int right = userList.Count -1;
            while(left <= right)
            {
                int middle = left + ((right - left) / 2);
                if(userList[middle].UserID == searchElement)
                {
                    return userList[middle];
                }
                else if(String.Compare(userList[middle].UserID, searchElement) < 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle -1;
                }
            }
            return null;
        }
    }
}