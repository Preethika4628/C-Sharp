using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public enum OrderType{ Default, Intiated, Ordered, Cancelled}
    public class OrderDetails
    {
        private static int s_orderID = 1000;
        public string OrderID {get;}
        public string UserID {get; set;}
        public DateTime OrderDate {get; set;}
        public double TotalPrice {get; set;}
        public OrderType OrderStatus {get; set;}
        public OrderDetails(string userID, DateTime orderDate, double totalPrice, OrderType orderStatus)
        {
            s_orderID++;
            OrderID = "OID" + s_orderID;
            UserID = userID;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            OrderStatus = orderStatus;
        }
        public OrderDetails(string order)
        {
            string[] values = order.Split(",");
            s_orderID = int.Parse(values[0].Remove(0,3));
            OrderID = values[0];
            UserID = values[1];
            OrderDate = DateTime.ParseExact(values[2],"dd/MM/yyyy",null);
            TotalPrice = double.Parse(values[3]);
            OrderStatus =Enum.Parse<OrderType>(values[4]);
        }
    }
}