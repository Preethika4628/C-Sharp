using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCard
{
    public class Operations
    {
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        public static CustomList<TravelDetails> travelList = new CustomList<TravelDetails>();
        public static CustomList<TicketFairDetails> ticketList = new CustomList<TicketFairDetails>();
        public static UserDetails currentLoginUser;
        public static void AddDefaultData()
        {
            UserDetails user1 = new UserDetails("Ravi", 9848812345, 1000);
            userList.Add(user1);
            UserDetails user2 = new UserDetails("Baskaran", 9948854321, 1000);
            userList.Add(user2);

            TravelDetails travel1 = new TravelDetails("CMR1001", "Airport", "Egmore", new DateTime(2023, 10, 10), 55);
            travelList.Add(travel1);
            TravelDetails travel2 = new TravelDetails("CMR1001", "Alandur", "Koyambedu", new DateTime(2023, 10, 10), 32);
            travelList.Add(travel2);
            TravelDetails travel3 = new TravelDetails("CMR1002", "Airport", "Koyambedu", new DateTime(2023, 11, 10), 25);
            travelList.Add(travel3);
            TravelDetails travel4 = new TravelDetails("CMR1002", "Egmore", "Thirumangalam", new DateTime(2023, 11, 10), 25);
            travelList.Add(travel4);

            TicketFairDetails ticketFair1 = new TicketFairDetails("Airport", "Egmore", 55);
            ticketList.Add(ticketFair1);
            TicketFairDetails ticketFair2 = new TicketFairDetails("Airport", "Koyambedu", 25);
            ticketList.Add(ticketFair2);
            TicketFairDetails ticketFair3 = new TicketFairDetails("Airport", "Koyambedu", 25);
            ticketList.Add(ticketFair3);
            TicketFairDetails ticketFair4 = new TicketFairDetails("Koyambedu", "Egmore", 32);
            ticketList.Add(ticketFair4);
            TicketFairDetails ticketFair5 = new TicketFairDetails("Vadapalani", "Egmore", 45);
            ticketList.Add(ticketFair5);
            TicketFairDetails ticketFair6 = new TicketFairDetails("Arumbakkam", "Egmore", 25);
            ticketList.Add(ticketFair6);
            TicketFairDetails ticketFair7 = new TicketFairDetails("Vadapalani", "Koyambedu", 25);
            ticketList.Add(ticketFair7);
            TicketFairDetails ticketFair8 = new TicketFairDetails("Arumbakkam", "Koyambedu", 16);
            ticketList.Add(ticketFair8);

            Console.WriteLine("User Details: ");
            foreach (UserDetails user in userList)
            {
                Console.WriteLine($"{user.CardNumber,-10} | {user.UserName,-10} | {user.PhoneNumber} | {user.Balance}");
            }
            Console.WriteLine("Travel Details: ");
            foreach (TravelDetails travel in travelList)
            {
                Console.WriteLine($"{travel.TravelID,-10} | {travel.CardNumber,-10} | {travel.FromLocation,-10} | {travel.ToLocation,-15} | {travel.Date.ToString("dd/MM/yyyy"),-8} | {travel.TravelCost,-5}");
            }
            Console.WriteLine("Ticket Fair Details: ");
            foreach (TicketFairDetails ticketFair in ticketList)
            {
                Console.WriteLine($"{ticketFair.TicketID,-10} | {ticketFair.FromLocation,-10} | {ticketFair.ToLocation,-10} | {ticketFair.Fair,-5}");
            }
        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Choose:  1.New User Registration  2.Login User  3.Exit");
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
                            Login();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Exitting the application");
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
            Console.WriteLine("USER REGISTRATION ");
            Console.Write("Enter the User Name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your Phone number ");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter your Balance: ");
            double balance = double.Parse(Console.ReadLine());

            UserDetails user = new UserDetails(userName, phoneNumber, balance);
            userList.Add(user);
            Console.WriteLine($"User registered successfully. Your User ID is {user.CardNumber}");
        }
        public static void Login()
        {
            Console.Write("Enter the User ID to login: ");
            string cardNumber = Console.ReadLine().ToUpper();
            currentLoginUser = BinarySearch.LoginSearch(cardNumber);
            if (currentLoginUser != null)
            {
                Console.WriteLine("Logged in successfully..!");
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
                Console.WriteLine("Choose:  1.BalanceCheck  2.Recharge  3.ViewTravelHistory  4.Travel  5.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            BalanceCheck();
                            break;
                        }
                    case 2:
                        {
                            Recharge();
                            break;
                        }
                    case 3:
                        {
                            ViewTravelHistory();
                            break;
                        }
                    case 4:
                        {
                            Travel();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Exitting the Login");
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
        public static void BalanceCheck()
        {
            Console.WriteLine($"Current Balance in your user ID is {currentLoginUser.Balance}");
        }
        public static void Recharge()
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
                    Console.WriteLine($"Total amount in the Wallet: {currentLoginUser.Balance}");
                }
                else
                {
                    Console.WriteLine("Enter the amount in Positive above 0");
                    Recharge();
                }
            }
            else
            {
                SubMenu();
            }
        }
        public static void ViewTravelHistory()
        {
            TravelDetails travel = BinarySearch.TravelSearch(currentLoginUser.CardNumber);
            if (travel != null)
            {
                Console.WriteLine($"{travel.TravelID,-10} | {travel.CardNumber,-10} | {travel.FromLocation,-10} | {travel.ToLocation,-15} | {travel.Date.ToString("dd/MM/yyyy"),-8} | {travel.TravelCost,-5}");
            }
            else
            {
                Console.WriteLine("No travel history");
            }
        }
        public static void Travel()
        {
            //1.	Show the Ticket fair details where the user wishes to travel by getting TicketID.
            Console.WriteLine("Ticket Fair Details: ");
            foreach (TicketFairDetails ticketFair in ticketList)
            {
                Console.WriteLine($"{ticketFair.TicketID,-10} | {ticketFair.FromLocation,-10} | {ticketFair.ToLocation,-10} | {ticketFair.Fair,-5}");
            }
            Console.Write("Enter the ticket ID: ");
            string ticketID = Console.ReadLine();
            // bool flag = true;
            TicketFairDetails ticket = BinarySearch.TicketFairSearch(ticketID);
            // 2.	Check the ticketID is valid. Else show “Invalid ticket id”.
            if (ticket != null)
            {
                // 3.	IF ticket is valid then, Check the balance from the user object whether it has sufficient balance to travel.
                if (currentLoginUser.Balance >= ticket.Fair)
                {
                    // 4.	If “Yes” deduct the respective amount from the balance and add the travel details like Card number, From and ToLocation, Travel Date, Travel cost, Travel ID (auto generation) in his travel history.
                    currentLoginUser.Balance -= ticket.Fair;
                    TravelDetails travel = new TravelDetails(currentLoginUser.CardNumber, ticket.FromLocation, ticket.ToLocation, DateTime.Now, ticket.Fair);
                    travelList.Add(travel);
                    Console.WriteLine("Travel detail successfully created");
                    Console.WriteLine($"Your travel ID is {travel.TravelID}");
                }
                else
                {
                    // 5.	If “No” ask him to recharge and go to the “Existing User Service” menu.
                    Console.WriteLine("Insufficient Balance, Recharge");
                }
            }
            else
            {
                Console.WriteLine("Invalid Ticket id");
            }
        }
    }
}