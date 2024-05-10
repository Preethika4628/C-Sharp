using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncStays
{
    public class Operations
    {
        public static List<UserRegistration> userList = new List<UserRegistration>();
        public static List<RoomDetails> roomList = new List<RoomDetails>();
        public static List<BookingDetails> bookingList = new List<BookingDetails>();
        public static List<RoomSelection> selectionList = new List<RoomSelection>();
        static UserRegistration currentLoginUser;
        public static void AddDefaultData()
        {
            UserRegistration user1 = new UserRegistration("Ravichandran", 995875777, 347777378383, "Chennai", FoodType.Veg, Gender.Male, 5000);
            userList.Add(user1);
            UserRegistration user2 = new UserRegistration("Baskaran", 448844848, 474777477477, "Chennai", FoodType.NonVeg, Gender.Male, 6000);
            userList.Add(user2);

            RoomDetails room1 = new RoomDetails(RoomType.Standard, 2, 500);
            roomList.Add(room1);
            RoomDetails room2 = new RoomDetails(RoomType.Standard, 4, 700);
            roomList.Add(room2);
            RoomDetails room3 = new RoomDetails(RoomType.Standard, 2, 500);
            roomList.Add(room3);
            RoomDetails room4 = new RoomDetails(RoomType.Standard, 2, 500);
            roomList.Add(room4);
            RoomDetails room5 = new RoomDetails(RoomType.Standard, 2, 500);
            roomList.Add(room5);
            RoomDetails room6 = new RoomDetails(RoomType.Delux, 2, 1000);
            roomList.Add(room6);
            RoomDetails room7 = new RoomDetails(RoomType.Delux, 2, 1000);
            roomList.Add(room7);
            RoomDetails room8 = new RoomDetails(RoomType.Delux, 4, 1400);
            roomList.Add(room8);
            RoomDetails room9 = new RoomDetails(RoomType.Delux, 4, 1400);
            roomList.Add(room9);
            RoomDetails room10 = new RoomDetails(RoomType.Suit, 2, 2000);
            roomList.Add(room10);
            RoomDetails room11 = new RoomDetails(RoomType.Suit, 2, 2000);
            roomList.Add(room11);
            RoomDetails room12 = new RoomDetails(RoomType.Suit, 2, 2000);
            roomList.Add(room12);
            RoomDetails room13 = new RoomDetails(RoomType.Suit, 4, 2500);
            roomList.Add(room13);

            BookingDetails booking1 = new BookingDetails("SF1001", 1450, new DateTime(2022, 11, 10), BookingStatus.Booked);
            bookingList.Add(booking1);
            BookingDetails booking2 = new BookingDetails("SF1002", 2000, new DateTime(2022, 11, 10), BookingStatus.Booked);
            bookingList.Add(booking2);

            RoomSelection selection1 = new RoomSelection("BID101", "RID101", new DateTime(2022, 11, 11, 6, 0, 0), new DateTime(2022, 11, 12, 14, 0, 0), 750, 1.5, BookingStatus.Booked);
            selectionList.Add(selection1);
            RoomSelection selection2 = new RoomSelection("BID101", "RID102", new DateTime(2022, 11, 11, 10, 0, 0), new DateTime(2022, 11, 12, 9, 0, 0), 700, 1, BookingStatus.Booked);
            selectionList.Add(selection2);
            RoomSelection selection3 = new RoomSelection("BID102", "RID103", new DateTime(2022, 12, 11, 9, 0, 0), new DateTime(2022, 11, 12, 9, 0, 0), 500, 1, BookingStatus.Booked);
            selectionList.Add(selection3);
            RoomSelection selection4 = new RoomSelection("BID102", "RID106", new DateTime(2022, 12, 11, 6, 0, 0), new DateTime(2022, 11, 12, 12, 30, 0), 1500, 1.5, BookingStatus.Booked);
            selectionList.Add(selection4);

            foreach (UserRegistration user in userList)
            {
                Console.WriteLine($"{user.UserID,-8} | {user.UserName,-15} | {user.MobileNumber,-10} | {user.AadharNumber,-15} | {user.Address,-10} | {user.FoodType,-8} | {user.Gender,-8} | {user.WalletBalance}");
            }
            foreach (RoomDetails room in roomList)
            {
                Console.WriteLine($"{room.RoomID,-8} | {room.RoomType,-10} | {room.NumberOfBeds,-4} | {room.PricePerDay}");
            }
            foreach (BookingDetails booking in bookingList)
            {
                Console.WriteLine($"{booking.BookingID,-8} | {booking.UserID,-8} | {booking.TotalPrice,-6} | {booking.DateOfBooking.ToString("dd/MM/yyyy"),-10} | {booking.BookingStatus,-15}");
            }
            foreach (RoomSelection selection in selectionList)
            {
                Console.WriteLine($"{selection.SelectionID,-10} | {selection.BookingID,-8} | {selection.RoomID,8} | {selection.StayingDateFrom,-24} | {selection.StayingDateTo,-24} | {selection.Price,-6} | {selection.NumberOfDays,-4} | {selection.BookingStatus}");
            }
        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                Console.Write("Choose:  1.User Registration  2.User Login  3.Exit : ");
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
                            flag = false;
                            Console.WriteLine("Exitting the application");
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
        public static void Registration()
        {
            Console.WriteLine("REGISTRATION FORM: ");
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Mobile Number: ");
            long mobile = long.Parse(Console.ReadLine());
            Console.Write("Enter your Aadhar Number: ");
            long aadhar = long.Parse(Console.ReadLine());
            Console.Write("Enter your Address: ");
            string address = Console.ReadLine();
            Console.Write("Choose Food type: 1.Veg 2.NonVeg : ");
            FoodType foodType = Enum.Parse<FoodType>(Console.ReadLine(), true);
            Console.Write("Choose Gender: 1.Male  2.Female  3.Transgender : ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            Console.Write("Enter your Wallet Balance: ");
            double balance = double.Parse(Console.ReadLine());

            UserRegistration user = new UserRegistration(name, mobile, aadhar, address, foodType, gender, balance);
            userList.Add(user);
            Console.WriteLine($"User registered successfully. Your User ID is {user.UserID}");
        }
        public static void Login()
        {
            Console.WriteLine("LOGGIN MENU: ");
            Console.Write("Enter your UserID: ");
            string userID = Console.ReadLine();
            currentLoginUser = Search.BinarySearch(userID);
            if (currentLoginUser != null)
            {
                Console.WriteLine("LoggedIn successfully");
                SubMenu();
            }
            else
            {
                Console.WriteLine("InValid UserID");
            }
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                Console.Write("Choose:  1.View Customer Profile   2.Book Room   3.Modify Booking   4.Cancel Booking  5.Booking History  6.Wallet Recharge  7.Show WalletBalance  8.Exit : ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            ViewCustomerProfile();
                            break;
                        }
                    case 2:
                        {
                            BookRoom();
                            break;
                        }
                    case 3:
                        {
                            ModifyRoom();
                            break;
                        }
                    case 4:
                        {
                            CancelBooking();
                            break;
                        }
                    case 5:
                        {
                            BookingHistory();
                            break;
                        }
                    case 6:
                        {
                            WalletRecharge();
                            break;
                        }
                    case 7:
                        {
                            ShowWalletBalance();
                            break;
                        }
                    case 8:
                        {
                            flag = false;
                            Console.WriteLine("Exitting the Login");
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
        public static void ViewCustomerProfile()
        {
            foreach (UserRegistration user in userList)
            {
                if (currentLoginUser.UserID == user.UserID)
                {
                    Console.WriteLine($"{user.UserID,-8} | {user.UserName,-15} | {user.MobileNumber,-10} | {user.AadharNumber,-15} | {user.Address,-10} | {user.FoodType,-8} | {user.Gender,-8} | {user.WalletBalance}");
                }
            }
        }
        public static void BookRoom()
        {
            bool RoomIDfound = false;
            // 1.	Create temporary booking object whose UserID is currentUserID, TotalAmount 0, Bookingdate Now, Status as initiated.
            List<BookingDetails> localBookingList = new List<BookingDetails>();
            BookingDetails tempbooking = new BookingDetails(currentLoginUser.UserID, 0, DateTime.Now, BookingStatus.Initated);
            // 2.	Create temporary local room selection list to hold the room selection objects up to booking completion.
            List<RoomSelection> localRoomSelection = new List<RoomSelection>();
            RoomSelection tempRoomSelec = new RoomSelection("", "", DateTime.Now, DateTime.Now, 0, 0, BookingStatus.Initated);
            // 3.	Need to show the list of available room types by traversing the Room Details list.
            string option = "";
            double totalPrice = 0;
            do
            {
                foreach (RoomDetails room in roomList)
                {
                    Console.WriteLine($"{room.RoomID,-8} | {room.RoomType,-10} | {room.NumberOfBeds,-4} | {room.PricePerDay}");
                }
                // 4.	Need to ask the user to enter DateFrom (Date and Time) and DateTo (Date and Time), RoomID & no. Of Days of booking.
                Console.Write("Enter the RoomID you want: ");
                string roomID = Console.ReadLine();
                Console.Write("Enter the number of days: ");
                double numberDays = double.Parse(Console.ReadLine());
                Console.Write("Enter the From Date: ");
                DateTime FromDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter the To Date: ");
                DateTime ToDate = DateTime.Parse(Console.ReadLine());
                // 5.	Based on the data need to check the room is already booked or not by traversing room selection list. If it is not booked means Create Room Selection object and add it to local room selection list.
                foreach (RoomDetails room in roomList)
                {
                    if (room.RoomID == roomID)
                    {
                        RoomIDfound = true;
                        if (room.NumberOfBeds > 0)
                        {
                            // tempRoomSelec.BookingID = booking.BookingID;
                            // tempRoomSelec.RoomID = roomID;
                            // tempRoomSelec.NumberOfDays = numberDays;
                            // tempRoomSelec.StayingDateFrom = FromDate;
                            // DateTime day = tempRoomSelec.StayingDateFrom.AddDays(numberDays);
                            // tempRoomSelec.StayingDateTo = day;
                            // tempRoomSelec.StayingDateTo = ToDate;
                            TimeSpan days = ToDate.Subtract(FromDate);
                            double Day = days.Days;
                            double price = Day * room.PricePerDay;
                            totalPrice += price;
                            tempRoomSelec = new RoomSelection(tempbooking.BookingID, roomID, FromDate, ToDate, room.PricePerDay, numberDays, BookingStatus.Booked);
                            localRoomSelection.Add(tempRoomSelec);
                        }
                    }
                }
                if (!RoomIDfound)
                {
                    System.Console.WriteLine("Invalid RoomID");
                }
                System.Console.WriteLine("Do you want to book again? : yes/no");
                option = Console.ReadLine().ToLower();
                // 6.	Ask the user whether he want to book another room. If “yes” means repeat step 3 to 5 to create new selection object and add it to local list.
            } while (option == "yes");
            // bool temp = false;
            // do
            // {
            if (totalPrice <= currentLoginUser.WalletBalance)
            {
                // temp = true;
                // 8.	Check the user has enough balance. If he has enough balance Add the local temp room selection to global list. Add the booking object to booking list. And show rooms successfully booked Your booking ID – BID101.
                selectionList.AddRange(localRoomSelection);
                tempbooking.BookingStatus = BookingStatus.Booked;
                tempbooking.TotalPrice = totalPrice;
                currentLoginUser.DeductBalance(totalPrice);
                bookingList.Add(tempbooking);
                Console.WriteLine("Booked room succesfully");
            }
            else
            {
                // 9.	If user don’t have enough balance, ask the user whether he want to proceed booking after recharge. If he says no then Show Exiting without booking rooms.
                System.Console.WriteLine("In sufficient balance to purchase.");
                System.Console.WriteLine("Do you Want to recharge?: yes/no");
                string recharge = Console.ReadLine().ToLower();
                if (recharge == "yes")
                {
                    // 19.	If he says “Yes”. Then ask him to Recharge with the total price of Order. 
                    // If he recharged with that amount means continue from step 12 to continue purchase. 
                    // temp = true;
                    System.Console.Write("Enter the Amount to recharge:");
                    double amount = double.Parse(Console.ReadLine());
                    currentLoginUser.WalletRecharge(amount);
                    System.Console.WriteLine($"Current Balance:{currentLoginUser.WalletBalance}");
                }
                else
                {
                    // temp = false;
                    foreach (RoomSelection selection in selectionList)
                    {
                        foreach (RoomDetails room in roomList)
                        {
                            if (selection.RoomID == room.RoomID)
                            {
                                room.NumberOfBeds++;
                                break;
                            }
                        }
                    }
                }
                // 10.	If he says yes means show the amount to be recharged for continue booking (Total Booking Amount). Recharge with user provided amount and go to step 8 to proceed booking.
                // 7.	If user says “No” means calculate the total rent amount of that selected rooms modify the booking object details and status as booked. 
            }
            // } while (temp);
        }
        public static void ModifyRoom()
        {
            bool flag = true;
            // •	Need to show the current user’s booking history whose booking status is Booked by traversing the booking details list and need to ask the user to pick a bookingID. 
            foreach (BookingDetails booking in bookingList)
            {
                if (currentLoginUser.UserID == booking.UserID && booking.BookingStatus == BookingStatus.Booked)
                {
                    flag = false;
                    Console.WriteLine($"{booking.BookingID,-8} | {booking.UserID,-8} | {booking.TotalPrice,-6} | {booking.DateOfBooking.ToString("dd/MM/yyyy"),-10} | {booking.BookingStatus,-15}");
                }
            }
            if (flag)
            {
                Console.WriteLine("You have no booking");
            }
            else
            {
                System.Console.Write("Enter the bookingID you wish to Modify:");
                string bookingID = Console.ReadLine().ToUpper();
                // •	Check whether the booking ID present in booking details and its status is Booked.
                // •	Traverse the selection list and check the Booking ID present in selection list and the selection status is Booked.
                foreach (BookingDetails booking in bookingList)
                {
                    if (bookingID == booking.BookingID && booking.BookingStatus == BookingStatus.Booked && currentLoginUser.UserID == booking.UserID)
                    {
                        // •	Show the selection list details of that booking ID and ask the user to enter selection ID.
                        foreach (RoomSelection selection in selectionList)
                        {
                            if (bookingID == selection.BookingID && selection.BookingStatus == BookingStatus.Booked)
                            {
                                Console.WriteLine($"{selection.SelectionID,-10} | {selection.BookingID,-8} | {selection.RoomID,8} | {selection.StayingDateFrom,-24} | {selection.StayingDateTo,-24} | {selection.Price,-6} | {selection.NumberOfDays,-4} | {selection.BookingStatus}");
                            }

                        }
                        bool flag1 = true;
                        double totalPrice = 0;
                        Console.WriteLine("Enter the room selection ID you want to modify");
                        string selectionID = Console.ReadLine().ToUpper();
                        // •	Validate the selection ID present in the selection list and its belong to current user and current booking ID.
                        foreach (RoomSelection selection1 in selectionList)
                        {
                            if (selectionID == selection1.SelectionID  && selection1.BookingStatus == BookingStatus.Booked)
                            {
                                flag1 = false;
                                Console.Write("Choose: 1.Cancel Selected Room  2.Add New Room");
                                int option = int.Parse(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                        {
                                            // 1.	If the user enter this option means return the selected room amount to user, deduct the amount from booking and change the status of selection entry to Cancelled.
                                            // 2.	Show “Selected room cancelled from your booking”.
                                            selection1.BookingStatus = BookingStatus.Cancelled;
                                            booking.TotalPrice -= selection1.Price;
                                            currentLoginUser.WalletRecharge(selection1.Price);
                                            Console.WriteLine("Selected room cancelled from your booking");
                                            break;
                                        }
                                    case 2:
                                        {
                                            // 1.	Show the list of available rooms in from the room details and ask the user to enter room ID and check in and out date and time.
                                            // 2.	Ask the user to enter number of days room is required.
                                            foreach (RoomDetails room in roomList)
                                            {
                                                Console.WriteLine($"{room.RoomID,-8} | {room.RoomType,-10} | {room.NumberOfBeds,-4} | {room.PricePerDay}");
                                            }
                                            Console.Write("Enter the RoomID you want: ");
                                            string roomID = Console.ReadLine();
                                            Console.Write("Enter the number of days: ");
                                            double numberDays = double.Parse(Console.ReadLine());
                                            Console.Write("Enter the From Date: ");
                                            DateTime FromDate = DateTime.Parse(Console.ReadLine());
                                            Console.Write("Enter the To Date: ");
                                            DateTime ToDate = DateTime.Parse(Console.ReadLine());
                                            // 3.	Check the selected room is available on that date and time by checking in the room selection list.
                                            foreach (RoomDetails room1 in roomList)
                                            {
                                                if (roomID == room1.RoomID)
                                                {
                                                    if (room1.NumberOfBeds > 0)
                                                    {
                                                        // 4.	If the room is available means then calculate amount.
                                                        TimeSpan days = ToDate.Subtract(FromDate);
                                                        double Day = days.Days;
                                                        double price = Day * room1.PricePerDay;
                                                        totalPrice += price;
                                                        if (currentLoginUser.WalletBalance >= price)
                                                        {
                                                            // 5.	Check the user has enough balance. If he has means deduct the amount from user.
                                                            currentLoginUser.DeductBalance(price);
                                                            // 6.	Add the amount to booking details.
                                                            booking.TotalPrice += price;
                                                            // 7.	Create selection object based on provided details and its status as Booked and add to the booking list.
                                                            RoomSelection selection = new RoomSelection(bookingID, roomID, FromDate, ToDate, price, numberDays, BookingStatus.Booked);
                                                            selectionList.Add(selection);
                                                            // 8.	Show “Booking modified successfully”.
                                                            Console.WriteLine("Booking modified successfully");
                                                        }
                                                        else
                                                        {
                                                            // 9.	If he don’t have enough balance means show “Please recharge {Rs. The above selected amount} before adding new room”.
                                                            Console.WriteLine($"Insufficient Balance, Please recharge Rs{price}");
                                                            WalletRecharge();
                                                        }

                                                    }
                                                }
                                            }
                                            break;
                                        }
                                    default:
                                    {
                                        Console.WriteLine("Select the correct option");
                                        break;
                                    }
                                }
                            }
                        }
                        if(flag1)
                        {
                            Console.WriteLine("Invalid RoomID");
                        }
                    }
                }

            }


        }
        public static void CancelBooking()
        {
            // Need to show the current user’s booking history whose booking status is Booked by traversing the booking details list and need to ask the user to pick a bookingID. 
            bool flag = true;
            foreach (BookingDetails booking in bookingList)
            {
                if (currentLoginUser.UserID == booking.UserID && booking.BookingStatus == BookingStatus.Booked)
                {
                    flag = false;
                    Console.WriteLine($"{booking.BookingID,-8} | {booking.UserID,-8} | {booking.TotalPrice,-6} | {booking.DateOfBooking.ToString("dd/MM/yyyy"),-10} | {booking.BookingStatus,-15}");
                }
            }
            if (!flag)
            {
                Console.Write("Enter the booking ID: ");
                string bookingID = Console.ReadLine().ToUpper();
                // Need to validate the id is present and need to change the status of booking to Cancelled and return the booking amount to current user’s wallet.
                foreach (BookingDetails booking in bookingList)
                {
                    if (bookingID == booking.BookingID && booking.BookingStatus == BookingStatus.Booked && currentLoginUser.UserID == booking.UserID)
                    {
                        booking.BookingStatus = BookingStatus.Cancelled;
                        currentLoginUser.WalletRecharge(booking.TotalPrice);
                        // Change the booking status of selection list details of that corresponding bookingID from Booked to cancelled.
                        foreach (RoomSelection selection in selectionList)
                        {
                            if (selection.BookingID == bookingID && selection.BookingStatus == BookingStatus.Booked)
                            {
                                selection.BookingStatus = BookingStatus.Cancelled;
                            }
                        }
                    }
                }
                Console.WriteLine("Booking cancelled Successfully");
            }
            if (flag)
            {
                Console.WriteLine("No Booking history");
            }
        }
        public static void BookingHistory()
        {
            bool flag = true;
            foreach (BookingDetails booking in bookingList)
            {
                if (currentLoginUser.UserID == booking.UserID && booking.BookingStatus == BookingStatus.Booked)
                {
                    flag = false;
                    Console.WriteLine($"{booking.BookingID,-8} | {booking.UserID,-8} | {booking.TotalPrice,-6} | {booking.DateOfBooking.ToString("dd/MM/yyyy"),-10} | {booking.BookingStatus,-15}");
                }
            }
            if (flag)
            {
                Console.WriteLine("No Booking history");
            }
        }
        public static void WalletRecharge()
        {
            Console.Write("Do you want to recharge: yes/no :");
            string option = Console.ReadLine().ToLower();
            if (option == "yes")
            {
                Console.Write("Enter the amount to recharge: ");
                double amount = double.Parse(Console.ReadLine());
                if (amount > 0)
                {
                    currentLoginUser.WalletRecharge(amount);
                    Console.WriteLine($"The Total amount in the wallet is {currentLoginUser.WalletBalance}");
                }
                else
                {
                    Console.Write("Enter the amount in positive number");
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
            Console.WriteLine($"Total Balance in the wallet is {currentLoginUser.WalletBalance}");
        }
    }
}