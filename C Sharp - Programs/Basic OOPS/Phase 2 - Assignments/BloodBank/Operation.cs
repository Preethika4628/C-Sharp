using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public class Operation
    {
        // create list for all classes
        static List<UserRegistrationDetails> userRegistrationList = new List<UserRegistrationDetails>();
        static List<DonationDetails> donationList = new List<DonationDetails>();
        static UserRegistrationDetails currentLoginUser;

        public static void AddDefaultData()
        {
            //create and object with default values
            //add it to the list
            //traverse and show the data
            UserRegistrationDetails userRegistration1 = new UserRegistrationDetails("Ravichandran", 8484848, BloodType.O_Positive, 30, new DateTime(2022, 08, 25));
            userRegistrationList.Add(userRegistration1);
            UserRegistrationDetails userRegistration2 = new UserRegistrationDetails("Baskaran", 4747447, BloodType.AB_Positive, 30, new DateTime(2023, 10, 18));
            userRegistrationList.Add(userRegistration2);

            DonationDetails donation1 = new DonationDetails("UID1001", new DateTime(2022, 06, 10), 73, 120, 14, BloodType.O_Positive);
            donationList.Add(donation1);
            DonationDetails donation2 = new DonationDetails("UID1001", new DateTime(2022, 10, 10), 74, 120, 14, BloodType.O_Positive);
            donationList.Add(donation2);
            DonationDetails donation3 = new DonationDetails("UID1002", new DateTime(2022, 07, 11), 74, 120, 13.6, BloodType.AB_Positive);
            donationList.Add(donation3);
            Console.WriteLine("Donar Details:");
            foreach (UserRegistrationDetails user in userRegistrationList)
            {
                Console.WriteLine($"{user.DonarID,-10}  |  {user.DonarName,-15}  |  {user.MobileNumber,-10}  |  {user.BloodGroup,-15}  | {user.Age,-8}  |  {user.LastDonationDate.ToString("dd/MM/yyyy"),-10}");
            }
            Console.WriteLine("Donation Details:");
            foreach (DonationDetails donation in donationList)
            {
                Console.WriteLine($"{donation.DonationID,-10}  |  {donation.DonarID,-10}  |  {donation.DonationDate.ToString("dd/MM/yyyy"),-10}  |  {donation.Weight,-8}  | {donation.BloodPressure,-8}  |  {donation.Hemoglobin,-8}  |  {donation.BloodGroup,-15}");
            }
        }
        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                Console.Write("Choose:  1.User Registration  2.User Login  3.Fetch Donar Details  4.Exit : ");
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
                            FetchDonarDetails();
                            break;
                        }
                    case 4:
                        {
                            flag = false;
                            Console.WriteLine("Exiting the Application");
                            break;
                        }

                    default:
                        {
                            flag = false;
                            Console.WriteLine("Invalid Input");
                            break;
                        }
                }
            } while (flag);
        }
        public static void UserRegistration()
        {
            Console.WriteLine("Registration form:-");
            Console.Write("Enter the Donar name: ");
            string donarName = Console.ReadLine();
            Console.Write("Enter your mobile number: ");
            long mobileNumber = long.Parse(Console.ReadLine());
            Console.Write("Select your Blood group:  1.A_Positive  2.B_Positive  3.O_Positive,  4.AB_Positive : ");
            BloodType bloodgroup = Enum.Parse<BloodType>(Console.ReadLine(), true);
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your last date of donation: ");
            DateTime lastDonationDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            UserRegistrationDetails user = new UserRegistrationDetails(donarName, mobileNumber, bloodgroup, age, lastDonationDate);
            userRegistrationList.Add(user);
            Console.WriteLine($"User Registration done successfully. Your DonarID is {user.DonarID}");
        }
        public static void UserLogin()
        {
            //get the userID
            //traverse the userRegistrationList
            //check whether the entered ID ids present in the list
            //If yes, store it in the cookiee variable globally
            //if not, show invalid
            //show the submenu
            Console.Write("Enter your UserID: ");
            string userID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (UserRegistrationDetails user in userRegistrationList)
            {
                if (user.DonarID == userID)
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
        public static void FetchDonarDetails()
        {
            bool flag = true;
            //Ask for “Blood Group” and check blood group in the Donation details and it should display the donor’s name and phone number and native place.
            Console.Write("Select the Blood Group you needed:  1. A_Positive  2. B_Positive  3. O_Positive  4. AB_Positive  : ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1 || choice == 2 || choice == 3 || choice == 4)
            {
                BloodType blood = (BloodType)choice;
                // Console.WriteLine(blood);
                foreach (UserRegistrationDetails user in userRegistrationList)
                {
                    if (user.BloodGroup == blood)
                    {
                        flag = false;
                        Console.WriteLine($"{user.DonarName,-15}  |  {user.MobileNumber,-10}  | {user.Age,-8}");
                    }
                }
                if (flag)
                {
                    Console.WriteLine("No Donar avaiable in this Blood Group");
                }
            }
            else
            {
                Console.WriteLine("Choose one of the option from above");
                FetchDonarDetails();
            }
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                Console.Write("Choose:  1.Donate Blood  2.Donation History  3.Next Eligible Date  4.Exit : ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            DonateBlood();
                            break;
                        }
                    case 2:
                        {
                            DonationHistory();
                            break;
                        }
                    case 3:
                        {
                            NextEligibleDate();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Logging out from Login Menu");
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
        private static void DonateBlood()
        {
            //Get the weight, blood pressure, hemoglobin count from the user 
            Console.Write("Enter you Weight: ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("Enter you Blood Pressure: ");
            int bloodPressure = int.Parse(Console.ReadLine());
            Console.Write("Enter your Hemoglobin: ");
            int hemoglobin = int.Parse(Console.ReadLine());
            // check Weight is above 50, bp is below 130 hemoglobin count is above 13.
            if (weight > 50 && bloodPressure < 130 && hemoglobin > 13)
            {
                if (currentLoginUser.LastDonationDate <= DateTime.Now)
                {
                    // Check whether the person’s completed 6 months after donating the blood.
                    DateTime startDate = currentLoginUser.LastDonationDate;
                    DateTime endDate = startDate.AddMonths(6);
                    if (endDate < DateTime.Today)
                    {
                        DonationDetails donation = new DonationDetails(currentLoginUser.DonarID, DateTime.Today, weight, bloodPressure, hemoglobin, currentLoginUser.BloodGroup);
                        donationList.Add(donation);
                        DateTime temp = DateTime.Today.AddMonths(6);
                        Console.WriteLine("Blood Donated Succesfully...");
                        Console.WriteLine($"Donation ID is {donation.DonationID} and Next Donation can be done on {temp.ToString("dd/MM/yyyy")}");
                        currentLoginUser.LastDonationDate = DateTime.Today;
                    }
                    else
                    {
                        Console.WriteLine("You can't donate today. Wait for few days, Check your Next eligible date for donation for further details");
                    }
                }
                else
                {
                    Console.WriteLine("You can't Donate, check your next eligibility date");
                }
            }
            else
            {
                Console.WriteLine("You are not fit to donate");
            }
        }
        private static void DonationHistory()
        {
            bool flag = true;
            // Show the donation details of the current user using the method by traversing the donation history list.
            Console.WriteLine("Donation Details:");
            foreach (DonationDetails donation in donationList)
            {
                if (donation.DonarID == currentLoginUser.DonarID)
                {
                    flag = false;
                    Console.WriteLine($"{donation.DonationID,-10}  |  {donation.DonarID,-10}  |  {donation.DonationDate.ToString("dd/MM/yyyy"),-10}  |  {donation.Weight,-8}  | {donation.BloodPressure,-8}  |  {donation.Hemoglobin,-8}  |  {donation.BloodGroup,-15}");
                }
            }
            if (flag)
            {
                Console.WriteLine("This user doesn't have any donar history");
            }
        }
        private static void NextEligibleDate()
        {
            bool flag = true;
            int count = 0;
            string tempDonationID = "";
            DateTime tempDate = DateTime.Now;
            if (flag)
            {
                foreach (DonationDetails donation in donationList)
                {
                    if (donation.DonarID == currentLoginUser.DonarID)
                    {
                        flag = false;
                        count++;
                        tempDonationID = donation.DonationID;
                        // If the user donates 2 times, last donation must be user recently donated date.
                        tempDate = donation.DonationDate;
                    }
                }
                DateTime NextEligible = tempDate.AddMonths(6);
                // Show the next eligible date for the user (6 months from the date of last donation).
                Console.WriteLine($"Next eligible date for Blood donation is {NextEligible.AddDays(1).ToString("dd/MM/yyyy")}");
                flag = false;
            }
            if (flag)
            {
                Console.WriteLine("This user doesn't have any donar history");
            }
        }
    }
}