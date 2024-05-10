using System;
using System.Collections.Generic;
namespace OnlineDTHRecharge
{
    public static class Operation
    {
        static List<UserDetails> userList = new List<UserDetails>();
        static List<PackDetails> packList = new List<PackDetails>();
        static List<RechargeHistoryDetails> rechargeHistoryList = new List<RechargeHistoryDetails>();
        static UserDetails currentLoginUser;
        public static void AddDefaultData()
        {
            //create a list for all classes
            //create an object
            //add to the list
            //traverse and show the data
            UserDetails user1 = new UserDetails("John", 9746646466, "john@gmail.com", 500);
            userList.Add(user1);
            UserDetails user2 = new UserDetails("Merlin", 9782136543, "merlin@gmail.com", 150);
            userList.Add(user2);

            PackDetails pack1 = new PackDetails("RC150", "Pack1", 150, 28, 50);
            packList.Add(pack1);
            PackDetails pack2 = new PackDetails("RC300", "Pack2", 300, 56, 75);
            packList.Add(pack2);
            PackDetails pack3 = new PackDetails("RC500", "Pack3", 500, 28, 200);
            packList.Add(pack3);
            PackDetails pack4 = new PackDetails("RC1500", "Pack4", 1500, 365, 200);
            packList.Add(pack4);

            RechargeHistoryDetails rechargeHistory1 = new RechargeHistoryDetails("UID1001", "RC150", new DateTime(2021, 11, 30), 150, new DateTime(2021, 12, 27), 50);
            rechargeHistoryList.Add(rechargeHistory1);
            RechargeHistoryDetails rechargeHistory2 = new RechargeHistoryDetails("UID1001", "RC500", new DateTime(2024, 05, 01), 150, new DateTime(2024, 05, 28), 50);
            rechargeHistoryList.Add(rechargeHistory2);
            RechargeHistoryDetails rechargeHistory3 = new RechargeHistoryDetails("UID1002", "RC150", new DateTime(2022, 01, 01), 150, new DateTime(2022, 01, 28), 50);
            rechargeHistoryList.Add(rechargeHistory3);
            RechargeHistoryDetails rechargeHistory4 = new RechargeHistoryDetails("UID1002", "RC150", new DateTime(2024, 04, 01), 150, new DateTime(2024, 4, 28), 50);
            rechargeHistoryList.Add(rechargeHistory4);



            Console.WriteLine("User Details: ");
            foreach (UserDetails user in userList)
            {
                Console.WriteLine($" {user.UserID,-10} | {user.UserName,-10} | {user.MobileNumber,-15} | {user.EmailID,-20} | {user.WalletBalance,-10} ");
            }
            Console.WriteLine("Pack Details: ");
            foreach (PackDetails pack in packList)
            {
                Console.WriteLine($" {pack.PackID,-10} | {pack.PackName,-10} | {pack.Price,-12} | {pack.Validity,-10} | {pack.NumberOfChannels,-10} ");
            }
            Console.WriteLine("Recharge History Details: ");
            foreach (RechargeHistoryDetails rechargeHistory in rechargeHistoryList)
            {
                Console.WriteLine($" {rechargeHistory.RechargeID,-10} | {rechargeHistory.UserID,-10} | {rechargeHistory.PackID,-10} | {rechargeHistory.RechargeDate.ToString("dd/MM/yyyy"),-20} | {rechargeHistory.ValidTill.ToString("dd/MM/yyyy"),-15} | {rechargeHistory.NumberOfChannels,-10} ");
            }
        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Choose:  1.User Registration  2.User Login  3.Exit");
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
                            Console.WriteLine("Exiting Application");
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
        public static void UserRegistration()
        {
            Console.WriteLine("User Registration: ");
            Console.Write("Enter your User name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your Mobile number: ");
            long mobileNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter your Email ID: ");
            string emailID = Console.ReadLine();
            Console.Write("Enter your amount in the Wallet: ");
            double walletbalance = double.Parse(Console.ReadLine());

            UserDetails user = new UserDetails(userName, mobileNumber, emailID, walletbalance);
            userList.Add(user);
            Console.WriteLine($"User Registered Successfully. Your UserID is {user.UserID}");
        }
        public static void UserLogin()
        {
            //get userID
            //traverse userList
            //find whether user ID present
            //if not present, show invalid id
            //if present, store the current login in cookie object globally
            //show the submenu
            Console.Write("Enter your UserID: ");
            string userID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (UserDetails user in userList)
            {
                if (user.UserID == userID)
                {
                    Console.WriteLine("Logged in Successfully");
                    flag = false;
                    currentLoginUser = user;
                    SubMenu();
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid Login ID");
            }
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                //display option in submenu
                //switch case for each option and mention the methods for each
                Console.WriteLine("Choose:  1.Current Pack  2.Pack Recharge  3.Wallet Reachrge  4.View Pack Recharge Hiatory  5.Show Wallet Balance  6.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            CurrentPack();
                            break;
                        }
                    case 2:
                        {
                            PackRecharge();
                            break;
                        }
                    case 3:
                        {
                            WalletRecharge();
                            break;
                        }
                    case 4:
                        {
                            ViewPackRechargeHistory();
                            break;
                        }
                    case 5:
                        {
                            ShowWalletBalance();
                            break;
                        }
                    case 6:
                        {
                            flag = false;
                            Console.WriteLine("Exiting Login");
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
        public static void CurrentPack()
        {
            //Displays recent pack detail of current user (User ID, Pack ID, Recharge Amount, Valid Till, Number of channels)
            bool flag = true;
            Console.WriteLine("Current Pack Details: ");
            foreach (RechargeHistoryDetails rechargeHistory in rechargeHistoryList)
            {
                // DateTime dt = DateTime.Now;

                if (rechargeHistory.ValidTill >= DateTime.Now)
                {
                    if (currentLoginUser.UserID == rechargeHistory.UserID)
                    {
                        flag = false;
                        Console.WriteLine($" {rechargeHistory.RechargeID,-10} | {rechargeHistory.UserID,-10} | {rechargeHistory.PackID,-10} | {rechargeHistory.RechargeDate.ToString("dd/MM/yyyy"),-20} | {rechargeHistory.ValidTill.ToString("dd/MM/yyyy"),-15} | {rechargeHistory.NumberOfChannels,-10} ");
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Current user doesn't have any pack recharged");
            }
        }
        public static void PackRecharge()
        {
            // 1.	List the available pack details and ask the user to choose a pack and recharge.
            Console.WriteLine("Pack Details: ");
            foreach (PackDetails pack in packList)
            {
                Console.WriteLine($" {pack.PackID,-10} | {pack.PackName,-10} | {pack.Price,-12} | {pack.Validity,-10} | {pack.NumberOfChannels,-10} ");
            }
            Console.Write("Enter the Pack ID which you want to recharge: ");
            string packID = Console.ReadLine();
            int count = 0;
            bool flag = true;
            DateTime tempValidTill = DateTime.Now;
            foreach (PackDetails pack in packList)
            {
                if (packID == pack.PackID)
                {
                    // Based on the pack choose, check the wallet balance.
                    //-calculate amount need for the seleced pack
                    if (currentLoginUser.WalletBalance >= pack.Price)
                    {
                        // If the user has sufficient balance, then permit and do recharge.
                        //-deduct the amount from the wallet
                        currentLoginUser.WalletBalance -= pack.Price;
                        int nValid = pack.Validity;
                        DateTime RDate = DateTime.Today;
                        DateTime VDate = DateTime.Today;
                        if (flag)
                        {
                            foreach (RechargeHistoryDetails rechargeHistory in rechargeHistoryList)
                            {
                                if (currentLoginUser.UserID == rechargeHistory.UserID)
                                {
                                    count++;
                                    tempValidTill = rechargeHistory.ValidTill;
                                }
                            }
                            // Pack exp today -> recharge - pack should start from today
                            if (tempValidTill == DateTime.Today)
                            {
                                RDate = DateTime.Today.AddDays(1);
                                VDate = RDate.AddDays(nValid);
                            }
                            else if (tempValidTill > DateTime.Today)
                            {
                                RDate = tempValidTill.AddDays(1);
                                VDate = RDate.AddDays(nValid);
                            }
                            else if (tempValidTill < DateTime.Today)
                            {
                                // History present, but pack expired -> recharge from today
                                RDate = DateTime.Today;
                                VDate = RDate.AddDays(nValid);
                            }
                            RechargeHistoryDetails rechargeHistory1 = new RechargeHistoryDetails(currentLoginUser.UserID, pack.PackID, RDate, pack.Price, VDate, pack.NumberOfChannels);
                            rechargeHistoryList.Add(rechargeHistory1);
                            Console.WriteLine("Recharge done successfully");
                            Console.WriteLine($"Your Recharge History ID is {rechargeHistory1.RechargeID}");
                        }
                    }
                    else
                    {
                        // If insufficient balance in wallet, ask them to recharge his wallet.
                        Console.WriteLine("Insufficient Wallet Balance. Please recharge your wallet");
                    }
                    flag = false;
                }
                if (flag)
                {
                    // No history -> recharge today
                    Console.WriteLine("No recharge history is present");
                }
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
                    currentLoginUser.Recharge(amount);
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
                SubMenu();
            }

        }
        public static void ViewPackRechargeHistory()
        {
            bool flag = true;
            Console.WriteLine("Recharge History Details: ");
            foreach (RechargeHistoryDetails rechargeHistory in rechargeHistoryList)
            {
                if (currentLoginUser.UserID == rechargeHistory.UserID)
                {
                    flag = false;
                    Console.WriteLine($" {rechargeHistory.RechargeID,-10} | {rechargeHistory.UserID,-10} | {rechargeHistory.PackID,-10} | {rechargeHistory.RechargeDate.ToString("dd/MM/yyyy"),-20} | {rechargeHistory.ValidTill.ToString("dd/MM/yyyy"),-15} | {rechargeHistory.NumberOfChannels,-10} ");
                }
            }
            if (flag)
            {
                Console.WriteLine("Current user doesn't have any pack recharged");
            }
        }
        public static void ShowWalletBalance()
        {
            //show the wallet balance for the particular userID
            Console.WriteLine($"Current Balance in your user ID is {currentLoginUser.WalletBalance}");
        }

    }
}