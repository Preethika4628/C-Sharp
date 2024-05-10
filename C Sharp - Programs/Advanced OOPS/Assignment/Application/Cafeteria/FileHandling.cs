using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class FileHandling
    {
        public static void Create()
        {
            if(!Directory.Exists("Cafeteria"))
            {
                Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("Cafeteria");
            }
            //files for user details
            if(!File.Exists("Cafeteria/UserDetails.csv"))
            {
                Console.WriteLine("Creating file..");
                File.Create("Cafeteria/UserDetails.csv").Close();
            }
            //file for food details
            if(!File.Exists("Cafeteria/FoodDetails.csv"))
            {
                Console.WriteLine("Creating file..");
                File.Create("Cafeteria/FoodDetails.csv").Close();
            }
            //file for cart details
            if(!File.Exists("Cafeteria/CartItems.csv"))
            {
                Console.WriteLine("Creating file..");
                File.Create("Cafeteria/CartItems.csv").Close();
            }
            //file for order details
            if(!File.Exists("Cafeteria/OrderDetails.csv"))
            {
                Console.WriteLine("Creating file..");
                File.Create("Cafeteria/OrderDetails.csv").Close();
            }
        }
        public static void WriteToCSV()
        {
            //user details
            string[] users = new string[Operation.userList.Count];
            for(int i=0; i<Operation.userList.Count; i++)
            {
                users[i] = Operation.userList[i].UserID + "," + Operation.userList[i].Name + "," + Operation.userList[i].FatherName + "," + Operation.userList[i].Mobile + "," + Operation.userList[i].EmailID+ "," + Operation.userList[i].Gender + "," + Operation.userList[i].WorkStationNumber + "," + Operation.userList[i].WalletBalance;
            }
            File.WriteAllLines("Cafeteria/UserDetails.csv", users);

            //food details
            string[] foods = new string[Operation.foodList.Count];
            for(int i=0; i<Operation.foodList.Count; i++)
            {
                foods[i] = Operation.foodList[i].FoodID + "," + Operation.foodList[i].FoodName + "," +Operation.foodList[i].Price +","+ Operation.foodList[i].AvailableQuantity;
            }
            File.WriteAllLines("Cafeteria/FoodDetails.csv", foods);

            //cart items details
            string[] carts = new string[Operation.cartList.Count];
            for(int i=0; i<Operation.cartList.Count; i++)
            {
                carts[i] = Operation.cartList[i].ItemID + "," + Operation.cartList[i].OrderID + "," + Operation.cartList[i].FoodID + "," + Operation.cartList[i].OrderPrice + "," + Operation.cartList[i].OrderQuantity;
            }
            File.WriteAllLines("Cafeteria/CartItems.csv", carts);

            //order details
            string[] orders = new string[Operation.orderList.Count];
            for(int i=0; i<Operation.orderList.Count; i++)
            {
                orders[i] = Operation.orderList[i].OrderID + "," + Operation.orderList[i].UserID + "," +Operation.orderList[i].OrderDate.ToString("dd/MM/yyyy") + "," + Operation.orderList[i].TotalPrice + "," + Operation.orderList[i].OrderStatus;
            }
            File.WriteAllLines("Cafeteria/OrderDetails.csv", orders);
        }
        public static void ReadFromCSV()
        {
            //user details
            string[] users = File.ReadAllLines("Cafeteria/UserDetails.csv");
            foreach (string user in users)
            {
                UserDetails user1 = new UserDetails(user);
                Operation.userList.Add(user1);
            }

            //food details
            string[] foods = File.ReadAllLines("Cafeteria/FoodDetails.csv");
            foreach(string food in foods)
            {
                FoodDetails food1 = new FoodDetails(food);
                Operation.foodList.Add(food1);
            }

            //cart details
            string[] carts = File.ReadAllLines("Cafeteria/CartItems.csv");
            foreach (string cart in carts)
            {
                CartItem carts1 = new CartItem(cart);
                Operation.cartList.Add(carts1);
            }

            //order details
            string[] orders = File.ReadAllLines("Cafeteria/OrderDetails.csv");
            foreach (string order in orders)
            {
                OrderDetails order1 = new OrderDetails(order);
                Operation.orderList.Add(order1);
            }
        }
    }
}