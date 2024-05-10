using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading;
namespace SyncCart
{
    public static class Operation
    {
        static List<CustomerDetails> customerList = new List<CustomerDetails>();
        static List<ProductDetails> productList = new List<ProductDetails>();
        static List<OrderDetails> orderList = new List<OrderDetails>();
        static CustomerDetails currentLoginCustomer; //cookie value

        public static void AddDefaultData()
        {
            // Console.WriteLine("Adding default data");
            //create list for all classes
            //create objects
            //add to list
            //traverse and show the added data
            CustomerDetails customer1 = new CustomerDetails("Ravi", "Chennai", 9885858588, 50000, "ravi@mail.com");
            customerList.Add(customer1);
            CustomerDetails customer2 = new CustomerDetails("Baskaran", "Chennai", 9888475757, 60000, "baskaran@mail.com");
            customerList.Add(customer2);

            ProductDetails product1 = new ProductDetails("Mobile (Samsung)", 10, 10000, 3);
            productList.Add(product1);
            ProductDetails product2 = new ProductDetails("Tablet (Lenovo)", 5, 15000, 2);
            productList.Add(product2);
            ProductDetails product3 = new ProductDetails("Camara (Sony)", 3, 20000, 4);
            productList.Add(product3);
            ProductDetails product4 = new ProductDetails("iPhone", 5, 50000, 6);
            productList.Add(product4);
            ProductDetails product5 = new ProductDetails("Laptop (Lenovo I3))", 3, 40000, 3);
            productList.Add(product5);
            ProductDetails product6 = new ProductDetails("HeadPhone (Boat)", 5, 1000, 2);
            productList.Add(product6);
            ProductDetails product7 = new ProductDetails("Speakers (Boat)", 4, 500, 2);
            productList.Add(product7);

            OrderDetails order1 = new OrderDetails("CID3001", "PID2001", 20000, DateTime.Now, 2, OrderStatus.Ordered);
            orderList.Add(order1);
            OrderDetails order2 = new OrderDetails("CID3002", "PID2003", 41000, DateTime.Now, 2, OrderStatus.Ordered);
            orderList.Add(order2);

            Console.WriteLine("Customer Details:");
            foreach (CustomerDetails customer in customerList)
            {
                Console.WriteLine($"|  {customer.CustomerID,-10}  |  {customer.CustomerName,-15}  |  {customer.City,-12}  |  {customer.PhoneNumber - 15}  |  {customer.WalletBalance,-10}  |  {customer.EmailID,-10}");
            }
            Console.WriteLine("Product Details:");
            foreach (ProductDetails product in productList)
            {
                Console.WriteLine($"|  {product.ProductID,-10}  |  {product.ProductName,-20}  |  {product.Stock,-10}  |  {product.Price,-10}  |  {product.ShippingDuration,-10}");
            }
            Console.WriteLine("Order Details:");
            foreach (OrderDetails order in orderList)
            {
                Console.WriteLine($"|  {order.OrderID,-10}  |  {order.CustomerID,-10}  |  {order.ProductID,-10}  |  {order.TotalPrice,-10}  |  {order.PurchaseDate.ToString("dd/MM/yyyy"),-15} |   {order.OrderStatus,-15}");
            }
        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                Console.Write("Choose:  1.Customer regsitraion  2.Login  3.Exit  : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            Login();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Exit Selected");
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Application exited..");
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void Registration()
        {
            Console.WriteLine("CUSTOMER REGISTRSTION FORM: ");
            Console.Write("Enter you name: ");
            string customerName = Console.ReadLine();
            Console.Write("Enter your city: ");
            string city = Console.ReadLine();
            Console.Write("Enter you mobile number: ");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter your wallet balance: ");
            double walletBalance = double.Parse(Console.ReadLine());
            Console.Write("Enter your E-mail ID: ");
            string emailID = Console.ReadLine().ToLower();

            CustomerDetails customer = new CustomerDetails(customerName, city, phoneNumber, walletBalance, emailID);
            customerList.Add(customer);
            Console.WriteLine($"Your customer ID is {customer.CustomerID}");

        }
        public static void Login()
        {
            //get customerID
            //traverse customerList
            //find whether customer ID present
            //if not present, show invalid id
            //if present, store the current login in cookie object globally
            //show the submenu
            Console.Write("Enter the Customer ID: ");
            string customerID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (CustomerDetails customer in customerList)
            {
                if (customer.CustomerID == customerID)
                {
                    Console.WriteLine("Logged in successfuly");
                    currentLoginCustomer = customer;
                    flag = false;
                    Submenu();
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Customer ID not found");
            }

        }
        public static void Submenu()
        {
            bool flag = true;
            do
            {
                Console.Write("Choose:  1.Purchase  2.Order History  3.Cancel Order  4.Wallet Balance  5.Wallet Recharge : ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Purchase();
                            break;
                        }
                    case 2:
                        {
                            OrderHistory();
                            break;
                        }
                    case 3:
                        {
                            CancelOrder();
                            break;
                        }
                    case 4:
                        {
                            WalletBalance();
                            break;
                        }
                    case 5:
                        {
                            WalletRecharge();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Login exitted..");
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void Purchase()
        {
            //product
            //seelct product
            //quantity - 2 //2*
            //prodcut rate = amount
            // order place - place, delivery date, -amount, quamtity less

            //Once the Customer logged in show the list of Products.
            Console.WriteLine("Product Details:");
            foreach (ProductDetails product in productList)
            {
                Console.WriteLine($"|  {product.ProductID,-10}  |  {product.ProductName,-20}  |  {product.Stock,-10}  |  {product.Price,-10}  |  {product.ShippingDuration,-10}");
            }
            //Ask the customer to select a Product using Product ID. 
            Console.Write("Enter the Product ID: ");
            string productID = Console.ReadLine().ToUpper();
            // Validate productID if it is invalid show “Invalid ProductID”. 
            bool flag = true;
            foreach (ProductDetails product in productList)
            {
                if (productID == product.ProductID)
                {
                    flag = false;
                    // If it is valid, Then ask for the count he wish to purchase.
                    Console.Write("Enter the quantity of the product you needed: ");
                    int count = int.Parse(Console.ReadLine());
                    if (product.Stock >= count)
                    {
                        // If the count is available calculate total amount with the below formula.
                        // Delivery charge is Rs 50
                        // Total Amount = (required count * price per quantity) + Delivery charge
                        double deliveryCharge = 50;
                        double TotalAmount = (count * product.Price) + deliveryCharge;
                        // Check the current logged in customer’s wallet balance to ensure he is having enough balance to purchase by comparing with total price.
                        if (currentLoginCustomer.WalletBalance >= TotalAmount)
                        {
                            // If the wallet has sufficient balance, then 
                            // Deduct the total amount from the wallet balance of the current logged in customer.
                            // Deduct the count from the stock availability of the product.
                            currentLoginCustomer.DeductAmount(TotalAmount);
                            // currentLoginCustomer.WalletBalance -= TotalAmount;
                            product.Stock -= count;
                            // Create order with available details and make its status as Ordered, add it to order List
                            OrderDetails order = new OrderDetails(currentLoginCustomer.CustomerID, product.ProductID, TotalAmount, DateTime.Today, count, OrderStatus.Ordered);
                            orderList.Add(order);
                            //Show “Order Placed Successfully. Order ID: OID1001”.
                            Console.WriteLine($"Order placed successfully. Order ID: {order.OrderID}");
                            // Show the delivery date of order by making a calculation based on purchase date and 
                            // shipping duration of the product like “Order placed successfully. 
                            // Your order will be delivered on {Order date +shipping duration of the product}.
                            DateTime dt = DateTime.Now;
                            DateTime newDate = dt.AddDays(product.ShippingDuration);
                            // Show the delivery date of order by making a calculation based on purchase date and shipping duration of the product like “Order placed successfully. Your order will be delivered on {Order date +shipping duration of the product}.
                            Console.WriteLine($"Your order will be delivered by {newDate.ToString("dd/MM/yyyy")} as the shipping duration of the prodcut is {product.ShippingDuration} days");
                        }
                        else
                        {
                            // If the wallet balance is insufficient for this order, then display “Insufficient Wallet Balance. Please recharge your wallet and do purchase again”.
                            Console.WriteLine("Insufficient Wallet Balance. Please recharge your wallet and do purchase again");
                        }
                    }
                    // If the required count is not available in the product’s stock, then show like “Required count not available. Current availability is {product’s stock count}”.
                    else
                    {
                        Console.WriteLine($"Required count is not avaiable. Current avaiablility is {product.Stock}");
                        break;
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid ProductID");
            }
        }
        public static void OrderHistory()
        {
            Console.WriteLine("Order Details:");
            bool flag = true;
            foreach (OrderDetails order in orderList)
            {
                if (currentLoginCustomer.CustomerID == order.CustomerID)
                {
                    flag = false;
                    Console.WriteLine($"|  {order.OrderID,-10}  |  {order.CustomerID,-10}  |  {order.ProductID,-10}  |  {order.TotalPrice,-10}  |  {order.PurchaseDate.ToString("dd/MM/yyyy"),-10}  |  {order.OrderStatus,-15}");
                }
            }
            if (flag)
            {
                Console.WriteLine("You haven't ordered any product");
            }
        }
        public static void CancelOrder()
        {
            bool temp = false;
            // Show all orders placed by current logged in customer whose order status is Ordered.
            foreach (OrderDetails order in orderList)
            {
                if (currentLoginCustomer.CustomerID == order.CustomerID && order.OrderStatus == OrderStatus.Ordered)
                {
                    temp = true;
                    Console.WriteLine($"|  {order.OrderID,-10}  |  {order.CustomerID,-10}  |  {order.ProductID,-10}  |  {order.TotalPrice,-10}  |  {order.PurchaseDate.ToString("dd/MM/yyyy"),-15} |   {order.OrderStatus,-15}");
                }
            }
            if (temp)
            {
                // Ask customer to select an order to be cancelled by the OrderID.
                Console.Write("Enter the orderID you want to cancel: ");
                string orderID = Console.ReadLine().ToUpper();
                // Validate orderID and show “Invalid OrderID” if there is no such order.
                bool flag = true;
                foreach (OrderDetails order in orderList)
                {
                    if (orderID == order.OrderID && order.OrderStatus == OrderStatus.Ordered)
                    {
                        flag = false;
                        // If it is valid then Pick the order based on the provided OrderID.
                        foreach (ProductDetails product in productList)
                        {
                            if (order.ProductID == product.ProductID)
                            {
                                // Increase the available stock quantity by the count of product purchased in the current order to be cancelled.
                                product.Stock += order.Quantity;
                            }
                        }
                        // Refund the amount to the customer’s wallet balance.
                        currentLoginCustomer.WalletBalance += order.TotalPrice;
                        // Change the order status to “Cancelled” and finally show “Order :{OrderID} cancelled successfully”.
                        order.OrderStatus = OrderStatus.Cancelled;
                        Console.WriteLine($"Order {order.OrderID} cancelled successfully");
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Invalid OrderID");
                }
            }
            else
            {
                Console.WriteLine("There is no current order list");
            }
        }
        public static void WalletBalance()
        {
            Console.WriteLine($"Current avaibale wallet balance is {currentLoginCustomer.WalletBalance}");
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
                    currentLoginCustomer.Recharge(amount);
                    // Console.WriteLine($"Total amount in the Wallet: {Recharge}");
                }
                else
                {
                    Console.WriteLine("Enter the amount in Positive above 0");
                    WalletRecharge();
                }
            }
            else
            {
                Submenu();
            }
        }
    }
}