using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class Operation
    {
        static List<UserDetails> userList = new List<UserDetails>();
        static List<MedicineDetails> medicineList = new List<MedicineDetails>();
        static List<OrderDetails> orderList = new List<OrderDetails>();
        static UserDetails currentUserLogin; //cookie value
        public static void AddDefaultData()
        {
            UserDetails user1 = new UserDetails("Ravi", 33, "Theni", 9877774440, 400);
            userList.Add(user1);
            UserDetails user2 = new UserDetails("Baskaran", 33, "Chennai", 8847757470, 500);
            userList.Add(user2);

            MedicineDetails medicine1 = new MedicineDetails("Paracitamol", 40, 5, new DateTime(2023, 12, 30));
            medicineList.Add(medicine1);
            MedicineDetails medicine2 = new MedicineDetails("Calpol", 10, 5, new DateTime(2023, 11, 30));
            medicineList.Add(medicine2);
            MedicineDetails medicine3 = new MedicineDetails("Gelucil", 3, 40, new DateTime(2024, 04, 30));
            medicineList.Add(medicine3);
            MedicineDetails medicine4 = new MedicineDetails("Metrogel", 5, 40, new DateTime(2024, 12, 30));
            medicineList.Add(medicine4);
            MedicineDetails medicine5 = new MedicineDetails("Povidin Iodin", 10, 40, new DateTime(2026, 10, 30));
            medicineList.Add(medicine5);

            OrderDetails order1 = new OrderDetails("UID1001", "MID2001", 3, 15, new DateTime(2023, 11, 13), OrderStatus.Purchased);
            orderList.Add(order1);
            OrderDetails order2 = new OrderDetails("UID1002", "MID2002", 2, 10, new DateTime(2023, 11, 13), OrderStatus.Cancelled);
            orderList.Add(order2);
            OrderDetails order3 = new OrderDetails("UID1004", "MID2004", 2, 100, new DateTime(2023, 11, 13), OrderStatus.Purchased);
            orderList.Add(order3);
            OrderDetails order4 = new OrderDetails("UID1003", "MID2003", 3, 120, new DateTime(2024, 01, 15), OrderStatus.Cancelled);
            orderList.Add(order4);
            OrderDetails order5 = new OrderDetails("UID1005", "MID2005", 5, 250, new DateTime(2024, 01, 15), OrderStatus.Purchased);
            orderList.Add(order5);
            OrderDetails order6 = new OrderDetails("UID1002", "MID2002", 3, 15, new DateTime(2024, 01, 15), OrderStatus.Purchased);
            orderList.Add(order6);

            Console.WriteLine("User Details:");
            foreach (UserDetails user in userList)
            {
                Console.WriteLine($"{user.UserID,-10}  |  {user.UserName,-15}  |  {user.Age,-5}  |  {user.City,-10}  |  {user.PhoneNumber,-15}  |  {user.Balance,-10}");
            }
            Console.WriteLine("Medicine Details:");
            foreach (MedicineDetails medicine in medicineList)
            {
                Console.WriteLine($"{medicine.MedicineID,-10}  |  {medicine.MedicineName,-15}  |  {medicine.AvaiableCount,-5}  |  {medicine.Price,-5}  |  {medicine.DateOfExpiry.ToString("dd/MM/yyyy"),-15}");
            }
            Console.WriteLine("Order Details:");
            foreach (OrderDetails order in orderList)
            {
                Console.WriteLine($"{order.OrderID,-10}  |  {order.UserID,-10}  |  {order.MedicineID,-8}  |  {order.MedicineCount,-5}  |  {order.TotalPrice,-5}  |  {order.OrderDate.ToString("dd/MM/yyyy"),-10}  |  {order.OrderStatus,-15}");
            }
        }

        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                Console.Write("Choose:  1.User Registration  2.User Login  3.Exit  : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            UserRegistration();
                            break;
                        }
                    case 2:
                        {
                            UserLogin();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Exitting the Application");
                            flag = false;
                        }
                        break;
                    default:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void UserRegistration()
        {
            Console.WriteLine("Registration Form:-");
            Console.Write("Enter you name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your city name: ");
            string city = Console.ReadLine();
            Console.Write("Enter you Phone number: ");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter your Account balance: ");
            int balance = int.Parse(Console.ReadLine());

            UserDetails user = new UserDetails(name, age, city, phoneNumber, balance);
            userList.Add(user);
            Console.WriteLine($"Successfully Registred. The user ID is {user.UserID}");
        }
        public static void UserLogin()
        {
            Console.Write("Enter you UserID: ");
            string userID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (UserDetails user in userList)
            {
                if (userID == user.UserID)
                {
                    Console.WriteLine("Logged in Successfully");
                    flag = false;
                    currentUserLogin = user;
                    SubMenu();
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("User ID is not found");
            }
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                Console.Write("Choose:  1.Show medicine list  2.Purchase medicine  3.Cancel purchase  4.Show purchase history  5.Wallet Recharge  6.Show wallet balance  7.Exit  : ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            ShowMedicineList();
                            break;
                        }
                    case 2:
                        {
                            PurchaseMedicine();
                            break;
                        }

                    case 3:
                        {
                            CancelPurchase();
                            break;
                        }
                    case 4:
                        {
                            ShowPurchaseHistory();
                            break;
                        }
                    case 5:
                        {
                            WalletRecharge();
                            break;
                        }
                    case 6:
                        {
                            ShowWalletBalance();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Exitting login");
                            flag = false;
                            break;
                        }

                    default:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void ShowMedicineList()
        {
            Console.WriteLine("Medicine Details:");
            foreach (MedicineDetails medicine in medicineList)
            {
                Console.WriteLine($"{medicine.MedicineID,-10}  |  {medicine.MedicineName,-15}  |  {medicine.AvaiableCount,-5}  |  {medicine.Price,-5}  |  {medicine.DateOfExpiry.ToString("dd/MM/yyyy"),-15}");
            }
        }
        public static void PurchaseMedicine()
        {
            //Show the List of medicine details by traversing the medicine details list.
            Console.WriteLine("Medicine Details:");
            foreach (MedicineDetails medicine in medicineList)
            {
                Console.WriteLine($"{medicine.MedicineID,-10}  |  {medicine.MedicineName,-15}  |  {medicine.AvaiableCount,-5}  |  {medicine.Price,-5}  |  {medicine.DateOfExpiry.ToString("dd/MM/yyyy"),-15}");
            }
            //Ask the user to select the medicine using MedicineID.
            Console.Write("Choose the Medicine ID you want: ");
            string medicineID = Console.ReadLine();
            Console.WriteLine("Medicine Details:");
            bool flag = true;
            foreach (MedicineDetails medicine in medicineList)
            {
                //Check the Medicine list whether the MedicineID was available.
                if (medicineID == medicine.MedicineID)
                {
                    flag = false;
                    //Check the medicine was not expired. If it is expired or not available, then show the user “Medicine is not available”.
                    if (medicine.DateOfExpiry > DateTime.Now)
                    {
                        // /Ask the number of counts of that medicine he wants to buy.
                        Console.Write("Enter the number of medicines you want: ");
                        int noOfMedicine = int.Parse(Console.ReadLine());
                        //check the asked count is available. If it is available,
                        if (medicine.AvaiableCount >= noOfMedicine)
                        {
                            //If the medicine is not expired, then check User has enough balance to purchase that medicine.
                            double totalPrice = noOfMedicine * medicine.Price;
                            if (currentUserLogin.Balance >= totalPrice)
                            {
                                //Reduce the number of AvailableCount of that medicine in MedicineDetails. 
                                medicine.AvaiableCount -= noOfMedicine;
                                //Deduct the total amount from user’s balance amount.
                                currentUserLogin.DeductAmount(totalPrice);
                                // currentUserLogin.Balance -= totalPrice;
                                //If all the conditions specified in step 4 are true then calculate the total amount of purchased medicines, OrderDate is Now, Put OrderStatus as “Purchased” and create object for OrderDetails class and add it to the list. 
                                OrderDetails order = new OrderDetails(currentUserLogin.UserID, medicine.MedicineID, noOfMedicine, totalPrice, DateTime.Today, OrderStatus.Purchased);
                                orderList.Add(order);
                                //Finally show the message “Medicine was purchased successfully”.
                                Console.WriteLine("Successfully order created");
                                Console.WriteLine($"Your order ID is {order.OrderID}");
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough amount in your wallet, Please do recharge");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"The medicine is not avaiable in the needed quantity");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Medicine not avaiable");
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("The mentioned Medicine ID is not avaiable");
            }
        }
        public static void CancelPurchase()
        {
            bool temp = false;
            //Show the order details of the currently logged in user whose order status is “Purchased”.
            // check the OrderID present in the list and check its OrderStatus is Purchased.
            Console.WriteLine("Order Details:");
            foreach (OrderDetails order in orderList)
            {
                if (currentUserLogin.UserID == order.UserID && order.OrderStatus == OrderStatus.Purchased)
                {
                    temp = true;
                    Console.WriteLine($"{order.OrderID,-10}  |  {order.UserID,-10}  |  {order.MedicineID,-8}  |  {order.MedicineCount,-5}  |  {order.TotalPrice,-5}  |  {order.OrderDate.ToString("dd/MM/yyyy"),-10}  |  {order.OrderStatus,-15}");
                }
            }
            if (temp)
            {
                //Get the OrderID information from the user
                Console.Write("Enter the order ID you want to cancel: ");
                string orderID = Console.ReadLine().ToUpper();
                bool flag = true;
                foreach (OrderDetails order in orderList)
                {
                    if (orderID == order.OrderID)
                    {
                        //If the OrderID matches increase the count of that Medicine in the medicine details, Return the amount to the user.  Change the Status of the order to “Cancelled”.
                        foreach (MedicineDetails medicine in medicineList)
                        {
                            if (order.MedicineID == medicine.MedicineID)
                            {
                                medicine.AvaiableCount += order.MedicineCount;
                            }
                        }
                        currentUserLogin.Balance += order.TotalPrice;
                        order.OrderStatus = OrderStatus.Cancelled;
                        Console.WriteLine("Order cancelled Successfully");
                        flag = false;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("The mentioned order ID is not avaible");
                }
                //Show the user that the “OrderID XXX was cancelled successfully”. 
            }
            else
            {
                Console.WriteLine("You haven't purchased any medicine before");
            }

        }
        public static void ShowPurchaseHistory()
        {
            bool flag = true;
            foreach (OrderDetails order in orderList)
            {
                if (currentUserLogin.UserID == order.UserID)
                {
                    Console.WriteLine($"{order.OrderID,-10}  |  {order.UserID,-10}  |  {order.MedicineID,-8}  |  {order.MedicineCount,-5}  |  {order.TotalPrice,-5}  |  {order.OrderDate.ToString("dd/MM/yyyy"),-10}  |  {order.OrderStatus,-15}");
                }
                flag = false;
            }
            if (flag)
            {
                Console.WriteLine("Purchase history not found for this user");
            }
        }
        public static void WalletRecharge()
        {
            //Ask whether he wishes to recharge
            Console.Write("Do you want to recharge? yes/no : ");
            string choice = Console.ReadLine();
            if (choice == "yes")
            {
                //if yes then ask for amount
                Console.Write("Enter the amount you want to reacharge: ");
                double amount = double.Parse(Console.ReadLine());
                if (amount > 0)
                {
                    //update the amount and disply it
                    currentUserLogin.Recharge(amount);
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
            Console.WriteLine($"My Wallet balance is {currentUserLogin.Balance}");
        }
    }
}