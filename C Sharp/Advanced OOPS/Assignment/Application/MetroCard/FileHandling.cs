using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCard
{
    public class FileHandling
    {
        public static void Create()
        {
            //directory creation
            if (!Directory.Exists("Metro"))
            {
                Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("Metro");
            }
            else
            {
                Console.WriteLine("Directory already exists");
            }

            //file for user details
            if (!File.Exists("Metro/UserDetails.csv"))
            {
                Console.WriteLine("Creating user details file");
                File.Create("Metro/UserDetails.csv").Close();
            }
            else
            {
                Console.WriteLine("User details file already exists");
            }

            //file for travel details
            if (!File.Exists("Metro/TravelDetails.csv"))
            {
                Console.WriteLine("Creating Travel details file");
                File.Create("Metro/TravelDetails.csv").Close();
            }
            else
            {
                Console.WriteLine("Travel details file created");
            }

            //file for ticket fair details
            if (!File.Exists("Metro/TicketFairDetails.csv"))
            {
                Console.WriteLine("Creating Ticket fair details file");
                File.Create("Metro/TicketFairDetails.csv").Close();
            }
            else
            {
                Console.WriteLine("Ticket Fair details file created");
            }
        }
        public static void WriteToCSV()
        {
            //user details
            string[] user = new string[Operations.userList.Count];
            for (int i = 0; i < Operations.userList.Count; i++)
            {
                user[i] = Operations.userList[i].CardNumber + "," + Operations.userList[i].UserName + "," + Operations.userList[i].PhoneNumber + "," + Operations.userList[i].Balance;
            }
            File.WriteAllLines("Metro/UserDetails.csv", user);

            //travel details
            string[] travel = new string[Operations.travelList.Count];
            for (int i = 0; i < Operations.travelList.Count; i++)
            {
                travel[i] = Operations.travelList[i].TravelID + "," + Operations.travelList[i].CardNumber + "," + Operations.travelList[i].FromLocation + "," + Operations.travelList[i].ToLocation + "," + Operations.travelList[i].Date.ToString("dd/MM/yyyy") + "," + Operations.travelList[i].TravelCost;
            }
            File.WriteAllLines("Metro/TravelDetails.csv", travel);

            //ticketfair details
            string[] ticket = new string[Operations.ticketList.Count];
            for (int i = 0; i < Operations.ticketList.Count; i++)
            {
                ticket[i] = Operations.ticketList[i].TicketID + "," + Operations.ticketList[i].FromLocation + "," + Operations.ticketList[i].ToLocation + "," + Operations.ticketList[i].Fair;
            }
            File.WriteAllLines("Metro/TicketFairDetails.csv", ticket);
        }
        public static void ReadFromCSV()
        {
            //user details
            string[] users = File.ReadAllLines("Metro/UserDetails.csv");
            foreach (string user in users)
            {
                UserDetails user1 = new UserDetails(user);
                Operations.userList.Add(user1);
            }

            //travel details
            string[] travels = File.ReadAllLines("Metro/TravelDetails.csv");
            foreach (string travel in travels)
            {
                TravelDetails travel1 = new TravelDetails(travel);
                Operations.travelList.Add(travel1);
            }

            //ticketfair details
            string[] tickets = File.ReadAllLines("Metro/TicketFairDetails.csv");
            foreach (string ticket in tickets)
            {
                TicketFairDetails ticket1 = new TicketFairDetails(ticket);
                Operations.ticketList.Add(ticket1);
            }
        }
    }
}