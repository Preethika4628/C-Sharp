using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SyncStays
{
    public class FileHandling
    {
        public static void Create()
        {
            //directory creation
            if(!Directory.Exists("SyncStays"))
            {
                Console.WriteLine("Creating a directory");
                Directory.CreateDirectory("SyncStays");
            }
            else
            {
                Console.WriteLine("SyncStays Directory Exists");
            }
            //User registration file creation
            if(!File.Exists("SyncStays/UserRegistration.csv"))
            {
                Console.WriteLine("Creatinf user registration file");
                File.Create("SyncStays/UserRegistration.csv").Close();
            }
            else
            {
                Console.WriteLine("User registration file exists");
            }
            //room details file creation
            if(!File.Exists("SyncStays/RoomDetails.csv"))
            {
                Console.WriteLine("Creating Room Details file");
                File.Create("SyncStays/RoomDetails.csv").Close();
            }
            else
            {
                Console.WriteLine("Room details file exists");
            }
            //booking details file creation
            if(!File.Exists("SyncStays/BookingDetails.csv"))
            {
                Console.WriteLine("Creating Booking Details file");
                File.Create("SyncStays/BookingDetails.csv").Close();
            }
            else
            {
                Console.WriteLine("Booking Details file exists");
            }
            //room selection details file creation
            if(!File.Exists("SyncStays/RoomSelection.csv"))
            {
                Console.WriteLine("Creatinf Room Selection file");
                File.Create("SyncStays/RoomSelection.csv").Close();
            }
            else
            {
                Console.WriteLine("Room Selection file exists");
            }
        }
        public static void WritetoCSV()
        {
            //user list
            string[] users = new string[Operations.userList.Count];
            for (int i = 0; i < Operations.userList.Count; i++)
            {
               users[i] = Operations.userList[i].UserID + "," +  Operations.userList[i].UserName + "," + Operations.userList[i].MobileNumber + "," + Operations.userList[i].AadharNumber + "," + Operations.userList[i].Address + "," + Operations.userList[i].FoodType + "," + Operations.userList[i].Gender + "," + Operations.userList[i].WalletBalance;
            }
            File.WriteAllLines("SyncStays/UserRegistration.csv", users);

            //room list
            string[] rooms = new string[Operations.roomList.Count];
            for (int i = 0; i < Operations.roomList.Count; i++)
            {
                rooms[i] = Operations.roomList[i].RoomID + "," + Operations.roomList[i].RoomType + "," + Operations.roomList[i].NumberOfBeds + "," + Operations.roomList[i].PricePerDay;
            }
            File.WriteAllLines("SyncStays/RoomDetails.csv", rooms);

            //booking list
            string[] bookings = new string[Operations.bookingList.Count];
            for (int i = 0; i < Operations.bookingList.Count; i++)
            {
                bookings[i] = Operations.bookingList[i].BookingID + "," + Operations.bookingList[i].UserID + "," + Operations.bookingList[i].TotalPrice + "," + Operations.bookingList[i].DateOfBooking.ToString("dd/MM/yyyy") + "," + Operations.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("SyncStays/BookingDetails.csv", bookings);

            //roomSelection list
            string[] selections = new string[Operations.selectionList.Count];
            for (int i = 0; i < Operations.selectionList.Count; i++)
            {
                selections[i] = Operations.selectionList[i].SelectionID + "," + Operations.selectionList[i].BookingID + "," + Operations.selectionList[i].RoomID + "," + Operations.selectionList[i].StayingDateFrom + "," + Operations.selectionList[i].StayingDateTo + "," + Operations.selectionList[i].Price + "," + Operations.selectionList[i].NumberOfDays + "," + Operations.selectionList[i].BookingStatus;
            }
            File.WriteAllLines("SyncStays/RoomSelection.csv", selections);
        }
        public static void ReadFromCSV()
        {
            //user
            string[] users = File.ReadAllLines("SyncStays/UserRegistration.csv");
            foreach (string user in users)
            {
                UserRegistration user1 = new UserRegistration(user);
                Operations.userList.Add(user1);
            }
            //room
            string[] rooms = File.ReadAllLines("SyncStays/RoomDetails.csv");
            foreach (string room in rooms)
            {
                RoomDetails room1 = new RoomDetails(room);
                Operations.roomList.Add(room1);
            }
            // booking
            string[] bookings = File.ReadAllLines("SyncStays/BookingDetails.csv");
            foreach (string booking in bookings)
            {
                BookingDetails booking1 = new BookingDetails(booking);
                Operations.bookingList.Add(booking1);
            }
            //room selection
            string[] selections = File.ReadAllLines("SyncStays/RoomSelection.csv");
            foreach (string selection in selections)
            {
                RoomSelection selection1 = new RoomSelection(selection);
                Operations.selectionList.Add(selection1);
            }
        }
    }
}