using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class Operation
    {
        public static List<UserDetails> userList = new List<UserDetails>();
        public static List<FoodDetails> foodList = new List<FoodDetails>();
        public static List<CartItem> cartList = new List<CartItem>();
        public static List<OrderDetails> orderList = new List<OrderDetails>();
        public static UserDetails currentLoginUser;
        public static void AddDefaultData()
        {
            UserDetails user1 = new UserDetails("Ravichandran", "Ettapparajan", 8857777575, "ravi@gmail.com", Gender.Male, "WS101", 400);
            userList.Add(user1);
            UserDetails user2 = new UserDetails("Baskaran", "Sethurajan", 9577747744, "baskaran@gmail.com", Gender.Male, "WS105", 500);
            userList.Add(user2);

            FoodDetails food1 = new FoodDetails("Coffee", 20, 100);
            foodList.Add(food1);
            FoodDetails food2 = new FoodDetails("Tea", 15, 100);
            foodList.Add(food2);
            FoodDetails food3 = new FoodDetails("Biscuit", 20, 100);
            foodList.Add(food3);
            FoodDetails food4 = new FoodDetails("Juice", 20, 100);
            foodList.Add(food4);
            FoodDetails food5 = new FoodDetails("Puff", 20, 100);
            foodList.Add(food5);
            FoodDetails food6 = new FoodDetails("Milk", 20, 100);
            foodList.Add(food6);
            FoodDetails food7 = new FoodDetails("Popcorn", 20, 20);
            foodList.Add(food7);

            CartItem cart1 = new CartItem("OID1001", "FID101", 20, 1);
            cartList.Add(cart1);
            CartItem cart2 = new CartItem("OID1001", "FID103", 10, 1);
            cartList.Add(cart2);
            CartItem cart3 = new CartItem("OID1001", "FID105", 40, 1);
            cartList.Add(cart3);
            CartItem cart4 = new CartItem("OID1002", "FID103", 10, 1);
            cartList.Add(cart4);
            CartItem cart5 = new CartItem("OID1002", "FID104", 50, 1);
            cartList.Add(cart5);
            CartItem cart6 = new CartItem("OID1002", "FID105", 40, 1);
            cartList.Add(cart6);

            OrderDetails order1 = new OrderDetails("SF1001", new DateTime(2022, 06, 15), 70, OrderType.Ordered);
            orderList.Add(order1);
            OrderDetails order2 = new OrderDetails("SF1002", new DateTime(2022, 06, 15), 100, OrderType.Ordered);
            orderList.Add(order2);

            Console.WriteLine("User Details:-");
            foreach (UserDetails user in userList)
            {
                Console.WriteLine($"{user.UserID,-8}  |  {user.Name,-15}  |  {user.FatherName,-15}  |  {user.Mobile,-10}  |  {user.EmailID,-20}  |  {user.Gender}  |  {user.WorkStationNumber,-6}  |  {user.WalletBalance,-8}");
            }
            Console.WriteLine("Food Details:-");
            foreach (FoodDetails food in foodList)
            {
                Console.WriteLine($"{food.FoodID,-8}  |  {food.FoodName,-8}  |  {food.Price,-4}  |  {food.AvailableQuantity,-8}");
            }
            Console.WriteLine("Cart Items:-");
            foreach (CartItem item in cartList)
            {
                Console.WriteLine($"{item.ItemID,-9}  |  {item.OrderID,-9}  |  {item.FoodID,-8}  |  {item.OrderPrice,-4}  |  {item.OrderQuantity,3}");
            }
            Console.WriteLine("Order Details:-");
            foreach (OrderDetails order in orderList)
            {
                Console.WriteLine($"{order.OrderID,-10} | {order.UserID,-8} | {order.OrderDate.ToString("dd/MM/yyyy"),10} | {order.TotalPrice,5} | {order.OrderStatus,10}");
            }
        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Choose:  1.Register  2.Login  3.Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        UserRegistration();
                        break;
                    case 2:
                        UserLogin();
                        break;
                    case 3:
                        Console.WriteLine("Exit selected");
                        flag = false;
                        break;
                    default:
                        flag = false;
                        break;
                }
            } while (flag);
        }
        public static void UserRegistration()
        {
            Console.WriteLine("USER REGISTRATION FORM:");
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your father name: ");
            string fatherName = Console.ReadLine();
            Console.Write("Enter your Mobile number: ");
            long mobileNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter your E-Mail ID: ");
            string emailID = Console.ReadLine();
            Console.Write("Select your gender: 1.Male 2.Female 3.Transgender ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            Console.Write("Enter your Work station number: ");
            string workstationNum = Console.ReadLine();
            Console.Write("Enter your Balance: ");
            double balance = double.Parse(Console.ReadLine());

            UserDetails user = new UserDetails(userName, fatherName, mobileNumber, emailID, gender, workstationNum, balance);
            Console.WriteLine("Student Registered Successfully and Student-ID is  " + user.UserID);
            userList.Add(user);
        }
        public static void UserLogin()
        {
            Console.Write("Enter the UserID: ");
            string id = Console.ReadLine().ToUpper();
            currentLoginUser = Search.BinarySearch(id);
            if (currentLoginUser != null)
            {
                Console.WriteLine("Logged in successfully..!");
                // currentLoginUser = Search.BinarySearch(id);
                SubMenu();
            }
            else
            {
                Console.WriteLine("User-ID is invalid");
            }

        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Choose:  1.Show My Profile   2.Food Order   3.Modify Order  4.Cancel Order  5.Order History   6.Wallet Recharge   7.Show Wallet Balance  8.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ShowMyProfile();
                        break;
                    case 2:
                        FoodOrder();
                        break;
                    case 3:
                        ModifyOrder();
                        break;
                    case 4:
                        CancelOrder();
                        break;
                    case 5:
                        OrderHistory();
                        break;
                    case 6:
                        WalletRecharge();
                        break;
                    case 7:
                        ShowWalletBalance();
                        break;
                    default:
                        flag = false;
                        break;
                }
            } while (flag);
        }
        public static void ShowMyProfile()
        {
            Console.WriteLine("User Details:-");
            foreach (UserDetails user in userList)
            {
                if(currentLoginUser.UserID == user.UserID)
                {
                    Console.WriteLine($"{user.UserID,-8}  |  {user.Name,-15}  |  {user.FatherName,-15}  |  {user.Mobile,-10}  |  {user.EmailID,-20}  |  {user.Gender}  |  {user.WorkStationNumber,-6}  |  {user.WalletBalance,-8}");
                }
            }
        }
        public static void FoodOrder()
        {
            // 1.	Create a temporary local carItemtList.
            List<CartItem> localCarts = new List<CartItem>();
            // 2.	Create an Order object with current UserID, Order date as current DateTime, total price as 0, Order status as “Initiated”.
            OrderDetails order = new OrderDetails(currentLoginUser.UserID, DateTime.Now, 0, OrderType.Intiated);
            // 3.	Ask the user to pick a product using FoodID, quantity required and calculate price of food.
            double totalPrice = 0;
            string option = "";
            do
            {
                foreach (FoodDetails food in foodList)
                {
                    Console.WriteLine($"{food.FoodID,-8}  |  {food.FoodName,-8}  |  {food.Price,-4}  |  {food.AvailableQuantity,-8}");
                }
                Console.Write("Enter the foodID: ");
                string foodID = Console.ReadLine();
                Console.Write("Enter the quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                bool flag = true;
                double price;
                foreach (FoodDetails food1 in foodList)
                {
                    if (foodID == food1.FoodID)
                    {
                        if (food1.AvailableQuantity >= quantity)
                        {
                            // / 4.	If the food and quantity available, reduce the quantity from the food object’s “AvailableQuantity” then create CartItems object using the available data.
                            flag = false;
                            price = food1.Price * quantity;
                            food1.AvailableQuantity -= quantity;
                            totalPrice += price;
                            // 5.	Add that object it to local CartItemsList to add it to cart wish list.
                            CartItem item = new CartItem(order.OrderID, foodID, price, quantity);
                            localCarts.Add(item);
                        }
                        else
                        {
                            Console.WriteLine("Quantity not avaibale");
                        }
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Invalid foodID");
                }
                // 6.	Ask the user whether he want to pick another product. 
                Console.Write("Do you want pick another product: yes/no");
                option = Console.ReadLine().ToLower();
                // 7.	If “Yes” then show the updated Food Details and repeat from step “3”.
                // 8.	Repeat the process until the user enters “No”.

            } while (option == "yes");
            // 9.	If He says No then, 
            // 10.	Ask the user whether he confirm the wish list to purchase. 
            //      If he says “No” then traverse the local CartItemList and get the Items one by one and
            //      reverse the quantity to the FoodItem’s objects in the foodList.
            Console.Write("Do you wish to purchase the product in the wish list: ");
            string choice = Console.ReadLine().ToLower();
            if (choice == "yes")
            {
                // 11.	If he says “Yes” then, Calculate the total price of the food items selected using the local 
                //   CartItemList information and check the balance from the user details whether it has sufficient balance to purchase.
                // 12.	If he has enough balance, then deduct the respective amount from the user’s balance. 
                bool temp = false;
                do
                {
                    if (totalPrice <= currentLoginUser.WalletBalance)
                    {
                        temp = false;
                        // 13.	Append the local CartItemList to global CartItemList.
                        cartList.AddRange(localCarts);
                        // 14.	Modify Order object created at step 1’s total price as total OrderPrice and OrderStatus as “Ordered”. 
                        order.OrderStatus = OrderType.Ordered;
                        order.TotalPrice = totalPrice;
                        currentLoginUser.DeductAmount(totalPrice);
                        orderList.Add(order);
                        Console.WriteLine("Order placed successfully");
                    }
                    // 17.	If he doesn’t have enough balance show “In sufficient balance to purchase.” Ask him “Are you willing to recharge.”
                    else
                    {

                        Console.WriteLine("In sufficient balance to purchase");
                        Console.Write("Are you willing to recharge: yes/no: ");
                        string choice1 = Console.ReadLine().ToLower();
                        if (choice1 == "yes")
                        {
                            temp = true;
                            Console.Write("Enter the amount to be recharged: ");
                            double amount = double.Parse(Console.ReadLine());
                            currentLoginUser.WalletRecharge(amount);
                            Console.WriteLine("Your current balance is " + currentLoginUser.WalletBalance);
                        }
                        else
                        {
                            temp = false;
                            foreach (CartItem item in localCarts)
                            {
                                foreach (FoodDetails food in foodList)
                                {
                                    if (item.FoodID == food.FoodID)
                                    {
                                        food.AvailableQuantity += item.OrderQuantity;
                                        break;
                                    }
                                }
                            }

                        }
                    }

                } while (temp);
            }
            else
            {
                foreach (CartItem item in localCarts)
                {
                    foreach (FoodDetails food in foodList)
                    {
                        if (item.FoodID == food.FoodID)
                        {
                            food.AvailableQuantity += item.OrderQuantity;
                            break;
                        }
                    }
                }

            }
        }
        public static void ModifyOrder()
        {
            //  1.	Show the Order details of current logged in user to pick an Order detail by using OrderID and whose status is “Ordered”. 
            //          Check whether the order details is present. If yes then,
            Console.WriteLine("Order Details:-");
            foreach (OrderDetails order in orderList)
            {
                if (currentLoginUser.UserID == order.UserID && order.OrderStatus == OrderType.Ordered)
                {
                    Console.WriteLine($"{order.OrderID,-10} | {order.UserID,-8} | {order.OrderDate.ToString("dd/MM/yyyy"),10} | {order.TotalPrice,5} | {order.OrderStatus,10}");
                }
            }
            Console.Write("Enter the order ID you want to modify: ");
            string orderID = Console.ReadLine();
            bool flag = true;
            foreach (OrderDetails order1 in orderList)
            {
                if (order1.OrderID == orderID && order1.OrderStatus == OrderType.Ordered)
                {
                    flag = false;
                    // 2.	Show list of Cart Item details and ask the user to pick an Item id.
                    foreach (CartItem item in cartList)
                    {
                        if (item.OrderID == orderID)
                        {
                            Console.WriteLine($"{item.ItemID,-9}  |  {item.OrderID,-9}  |  {item.FoodID,-8}  |  {item.OrderPrice,-4}  |  {item.OrderQuantity,3}");
                        }
                    }
                    // 3.	Ensure the ItemID is available and 

                    Console.Write("Enter the item ID you want to modify: ");
                    string itemID = Console.ReadLine();
                    bool temp = true;
                    foreach (CartItem item in cartList)
                    {
                        if (itemID == item.ItemID && order1.OrderID == orderID)
                        {
                            temp = false;
                            // ask the user to enter the new quantity of the food. 
                            Console.Write("Enter the quantity of the food: ");
                            int quantity1 = int.Parse(Console.ReadLine());
                            // bool temp1 = true;
                            //      Calculate the Item price and update in the OrderPrice.
                            foreach (FoodDetails food in foodList)
                            {
                                if (food.FoodID == item.FoodID)
                                {
                                    if (food.AvailableQuantity >= quantity1)
                                    {
                                        // temp1 = false;
                                        int finalQuantityCheck = quantity1 - item.OrderQuantity;
                                        if (finalQuantityCheck == 0)
                                        {
                                            Console.WriteLine("Same quantity entered");
                                        }
                                        else if (finalQuantityCheck < 0)
                                        {
                                            // reduce item count
                                            item.OrderQuantity += finalQuantityCheck;
                                            //calculate returning price
                                            double returnAmount = -finalQuantityCheck * food.Price;
                                            order1.TotalPrice -= returnAmount;

                                            //recharge to user
                                            currentLoginUser.WalletRecharge(returnAmount);
                                            //Increase food item stock count
                                            food.AvailableQuantity += -finalQuantityCheck;
                                            // 5.	Show Order modified successfully.
                                            Console.WriteLine("Order modified successfully");
                                        }
                                        else
                                        {
                                            //calculate subtracting price
                                            double returnAmount = finalQuantityCheck * food.Price;
                                            if (currentLoginUser.WalletBalance > returnAmount)
                                            {
                                                //increase item count
                                                item.OrderQuantity += finalQuantityCheck;
                                                order1.TotalPrice += returnAmount;
                                                //deduct from user
                                                currentLoginUser.DeductAmount(returnAmount);
                                                //decrease food item stock count
                                                food.AvailableQuantity -= finalQuantityCheck;
                                                // 5.	Show Order modified successfully.
                                                Console.WriteLine("Order modified successfully");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Insufficient balance to modify order. Recharge and proceed again");
                                            }
                                        }
                                    }
                                }

                            }
                            // if (temp1)
                            // {
                            //     Console.WriteLine("Quantity not avaiable");
                            // }

                        }
                    }
                    if (temp)
                    {
                        Console.WriteLine("Invalid Item ID");
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid order ID");
            }
        }
        public static void CancelOrder()
        {
            bool flag2 = false;
            bool flag1 = true;
            // 1.	Show the Order details of the current user who’s Order status is “Ordered”.
            Console.WriteLine("Order Details:-");
            foreach (OrderDetails order in orderList)
            {
                if (currentLoginUser.UserID == order.UserID && order.OrderStatus == OrderType.Ordered)
                {
                    flag1 = false;
                    flag2 = true;
                    Console.WriteLine($"{order.OrderID,-10} | {order.UserID,-8} | {order.OrderDate.ToString("dd/MM/yyyy"),10} | {order.TotalPrice,5} | {order.OrderStatus,10}");
                }
            }
            if (flag1)
            {
                Console.WriteLine("No order hsitory");
            }
            if (flag2)
            {
                // 2.	Ask the user to pick an OrderID to cancel.
                Console.Write("Enter the Order ID you want to cancel: ");
                string orderID = Console.ReadLine();
                bool flag = true;
                // 3.	Check the OrderID is valid. If not, then show “Invalid OrderID”.
                foreach (OrderDetails order1 in orderList)
                {
                    if (currentLoginUser.UserID == order1.UserID && order1.OrderStatus == OrderType.Ordered)
                    {
                        flag = false;
                        // 4.	If valid, then Return the Order total amount to current user.
                        currentLoginUser.WalletRecharge(order1.TotalPrice);
                        // 5.	Return product orderQuantity to Foodtem list’s FoodQuantity. 
                        foreach (CartItem item in cartList)
                        {
                            if (item.OrderID == order1.OrderID)
                            {
                                foreach (FoodDetails food in foodList)
                                {
                                    if (item.FoodID == food.FoodID)
                                    {
                                        food.AvailableQuantity += item.OrderQuantity;
                                        break;
                                    }
                                }
                            }
                        }
                        // 6.	Change the OrderStatus as Cancelled.
                        order1.OrderStatus = OrderType.Cancelled;
                        // 7.	Show “Order cancelled successfully” and product returned to cart.
                        Console.WriteLine("Order cancelled successfully");
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Invalid Order ID");
                }
            }
        }
        public static void OrderHistory()
        {
            bool flag = true;
            foreach (OrderDetails order in orderList)
            {
                if (currentLoginUser.UserID == order.UserID)
                {
                    flag = false;
                    Console.WriteLine($"{order.OrderID,-10} | {order.UserID,-8} | {order.OrderDate.ToString("dd/MM/yyyy"),10} | {order.TotalPrice,5} | {order.OrderStatus,10}");
                }
            }
            if (flag)
            {
                Console.WriteLine("No Order history");
            }
        }
        public static void WalletRecharge()
        {
            // Ask the customer whether he wish to recharge the wallet.
            Console.Write("Do you want to recharge? yes/no : ");
            string choice = Console.ReadLine().ToLower();
            if (choice == "yes")
            {
                // If “Yes” then ask for the amount to be recharged
                Console.Write("Enter the amount that is needed to be recharged: "); //500
                double amount = double.Parse(Console.ReadLine()); //1000
                if (amount > 0)
                {
                    // double TotatlRAmount = currentLoginCustomer.Recharge(amount); //1500
                    // update the amount in the wallet and display the updated wallet balance.
                    currentLoginUser.WalletRecharge(amount);
                    Console.WriteLine($"Total amount in the Wallet: {currentLoginUser.WalletBalance}");
                }
                else
                {
                    Console.WriteLine("Enter the amount in Positive above 0");
                    WalletRecharge();
                }
            }
            else
            {
                SubMenu();
            }
        }
        public static void ShowWalletBalance()
        {
            Console.WriteLine($"Current Balance in your user ID is {currentLoginUser.WalletBalance}");
        }
    }
}