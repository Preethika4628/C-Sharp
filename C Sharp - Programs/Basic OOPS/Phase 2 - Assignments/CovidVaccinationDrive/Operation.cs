using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CovidVaccinationDrive
{
    public class Operation
    {
        static List<BeneficiaryDetails> beneficiaryList = new List<BeneficiaryDetails>();
        static List<VaccineDetails> vaccineList = new List<VaccineDetails>();
        static List<VaccinationDetails> vaccinationList = new List<VaccinationDetails>();
        static BeneficiaryDetails currentLoginUser;
        public static void AddDefaultData()
        {
            BeneficiaryDetails beneficiary1 = new BeneficiaryDetails("Ravichandran", 21, Gender.Male, 8484484, "Chennai");
            beneficiaryList.Add(beneficiary1);
            BeneficiaryDetails beneficiary2 = new BeneficiaryDetails("Baskaran", 22, Gender.Male, 8484747, "Chennai");
            beneficiaryList.Add(beneficiary2);

            VaccineDetails vaccine1 = new VaccineDetails(VaccineType.Covishield, 50);
            vaccineList.Add(vaccine1);
            VaccineDetails vaccine2 = new VaccineDetails(VaccineType.Covaccine, 50);
            vaccineList.Add(vaccine2);

            VaccinationDetails vaccination1 = new VaccinationDetails("BID1001", "CID2001", 1, new DateTime(2021, 11, 11));
            vaccinationList.Add(vaccination1);
            VaccinationDetails vaccination2 = new VaccinationDetails("BID1001", "CID2001", 2, new DateTime(2023, 03, 24));
            vaccinationList.Add(vaccination2);
            VaccinationDetails vaccination3 = new VaccinationDetails("BID1002", "CID2002", 1, new DateTime(2022, 04, 04));
            vaccinationList.Add(vaccination3);

            Console.WriteLine("Beneficiary Details:");
            foreach (BeneficiaryDetails beneficiary in beneficiaryList)
            {
                Console.WriteLine($"{beneficiary.RegistrationID,-10}  |  {beneficiary.Name,-15}  |  {beneficiary.Age,-3}  |  {beneficiary.Gender,-8}  |  {beneficiary.MobileNumber,-10}");
            }
            Console.WriteLine("Vaccine Details:");
            foreach (VaccineDetails vaccine in vaccineList)
            {
                Console.WriteLine($"{vaccine.VaccineID,-10}  |  {vaccine.VaccineName,-10}  |  {vaccine.NoOfDoseAvaiable,-5}");
            }
            Console.WriteLine("Vaccination Details:");
            foreach (VaccinationDetails vaccination in vaccinationList)
            {
                Console.WriteLine($"{vaccination.VaccinationID}  |  {vaccination.RegistrationID}  |  {vaccination.VaccineID}  |  {vaccination.DoseNumber}  |  {vaccination.VaccinatedDate.ToString("dd/MM/yyyy")}");
            }
        }
        public static void MainMenu()
        {
            bool flag = false;
            do
            {
                flag = true;
                Console.WriteLine("Choose:  1.Beneficiary Registration  2.Login  3.Get Vaccine info  4.Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            BeneficiaryRegistration();
                            break;
                        }
                    case 2:
                        {
                            Login();
                            break;
                        }
                    case 3:
                        {
                            GetVaccineInfo();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Exitting the Application");
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
        public static void BeneficiaryRegistration()
        {
            Console.WriteLine("Beneficiary Registration Form: ");
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Choose: 1.Male 2.Female 3.Others : ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine());
            Console.Write("Enter your Mobile number: ");
            long mobileNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter you city name: ");
            string city = Console.ReadLine();

            BeneficiaryDetails beneficiary = new BeneficiaryDetails(name, age, gender, mobileNumber, city);
            beneficiaryList.Add(beneficiary);
            Console.WriteLine($"Successfully Registered, Your Beneficiary ID is {beneficiary.RegistrationID}");
        }
        public static void Login()
        {
            Console.Write("Enter your Registration ID: ");
            string registrationID = Console.ReadLine();
            bool flag = true;
            foreach (BeneficiaryDetails beneficiary in beneficiaryList)
            {
                if (beneficiary.RegistrationID == registrationID)
                {
                    flag = false;
                    currentLoginUser = beneficiary;
                    SubMenu();
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid Registration ID");
            }
        }
        public static void SubMenu()
        {
            bool flag = false;
            do
            {
                flag = true;
                Console.WriteLine("Choose:  1.Show My details  2. Take Vaccination  3.My Vaccination history  4.Next due date  5.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            ShowMyDetails();
                            break;
                        }
                    case 2:
                        {
                            TakeVaccination();
                            break;
                        }
                    case 3:
                        {
                            MyVaccinationHistory();
                            break;
                        }
                    case 4:
                        {
                            NextDueDate();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Logging Out");
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
        public static void GetVaccineInfo()
        {
            Console.WriteLine("Vaccine Details:");
            foreach (VaccineDetails vaccine in vaccineList)
            {
                Console.WriteLine($"{vaccine.VaccineID,-10}  |  {vaccine.VaccineName,-10}  |  {vaccine.NoOfDoseAvaiable,-5}");
            }
        }
        public static void ShowMyDetails()
        {
            // Show the current beneficiary’s personal details in console
            Console.WriteLine("Beneficiary Details:");
            foreach (BeneficiaryDetails beneficiary in beneficiaryList)
            {
                if (currentLoginUser.RegistrationID == beneficiary.RegistrationID)
                {
                    Console.WriteLine($"{beneficiary.RegistrationID,-10}  |  {beneficiary.Name,-15}  |  {beneficiary.Age,-3}  |  {beneficiary.Gender,-8}  |  {beneficiary.MobileNumber,-10}");
                }
            }
        }

        public static void TakeVaccination()
        {
            //Show the list of vaccine available and to select a vaccine.
            Console.WriteLine("Vaccine Details:");
            foreach (VaccineDetails vaccine in vaccineList)
            {
                Console.WriteLine($"{vaccine.VaccineID,-10}  |  {vaccine.VaccineName,-10}  |  {vaccine.NoOfDoseAvaiable,-5}");
            }
            // •	Ask the user to select a vaccine by using vaccine ID and find the ID is valid. 
            Console.Write("Enter the VaccineID you want: ");
            string vaccineID = Console.ReadLine().ToUpper();
            bool flag = true;
            bool temp = true;
            int tempDoseNum = 0;
            foreach (VaccinationDetails vaccination in vaccinationList)
            {
                if (currentLoginUser.RegistrationID == vaccination.RegistrationID)
                {
                    temp = false;
                    tempDoseNum = vaccination.DoseNumber;
                }
            }
            if (temp)
            {
                tempDoseNum = 0;
            }
            foreach (VaccineDetails vaccine in vaccineList)
            {
                if (vaccineID == vaccine.VaccineID)
                {
                    if (tempDoseNum < 3)
                    {
                        if (tempDoseNum == 0)
                        {
                            foreach (BeneficiaryDetails beneficiary in beneficiaryList)
                            {
                                if (currentLoginUser.Age > 14)
                                {
                                    tempDoseNum++;
                                    vaccine.NoOfDoseAvaiable--;
                                }
                            }

                        }
                        else if (tempDoseNum == 1 || tempDoseNum == 2)
                        {
                            foreach (VaccinationDetails vaccination1 in vaccinationList)
                            {
                                if (vaccineID == vaccination1.VaccineID && currentLoginUser.RegistrationID == vaccination1.RegistrationID)
                                {
                                    DateTime lastDate = vaccination1.VaccinatedDate;
                                    DateTime endDate = lastDate.AddDays(30);
                                    if (endDate < DateTime.Today)
                                    {
                                        tempDoseNum++;
                                        vaccine.NoOfDoseAvaiable--;
                                    }
                                    else if (endDate >= DateTime.Today)
                                    {
                                        Console.WriteLine("You can take vaccination on " + endDate.AddDays(1));
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You have choose different vaccine ID");
                                }
                            }
                        }
                        VaccinationDetails vaccination = new VaccinationDetails(currentLoginUser.RegistrationID, vaccineID, tempDoseNum, DateTime.Today);
                        vaccinationList.Add(vaccination);
                        Console.WriteLine($"Successfully vaccinated, Your Vaccination ID is : {vaccination.VaccinationID}");
                    }
                    else
                    {
                        Console.WriteLine("You have completed all vaccination. Thanks for your participation in the vaccination drive");
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid VaccineID");
            }
            // 	If it is yes, then check date of his last vaccination and find whether 30 days have completed. 
            // •	If it is yes, then allow him to take vaccination.
            // •	Add the details to his vaccination list 
            // •	Deduct the count of vaccine available.
            // 	If it is no, then show “You have selected different vaccine”. You can vaccine with “Covaccine / Covishield (His first / second dose vaccine type)”  take vaccination process again.  
        }
        public static void MyVaccinationHistory()
        {
            bool flag = true;
            // Show the vaccination details of the current beneficiary if he had completed first/ second/ third vaccinations.
            Console.WriteLine("Vaccination Details:");
            foreach (VaccinationDetails vaccination in vaccinationList)
            {
                if (currentLoginUser.RegistrationID == vaccination.RegistrationID)
                {
                    flag = false;
                    Console.WriteLine($"{vaccination.VaccinationID}  |  {vaccination.RegistrationID}  |  {vaccination.VaccineID}  |  {vaccination.DoseNumber}  |  {vaccination.VaccinatedDate.ToString("dd/MM/yyyy")}");
                }
            }
            if (flag)
            {
                Console.WriteLine("No Vaccination history");
            }
        }
        public static void NextDueDate()
        {
            bool flag = true;
            DateTime tempDate = DateTime.Today;
            DateTime nextEligibleDate = DateTime.Today;
            // Show the next due date for the current beneficiary by finding his details from his vaccination history. 
            foreach (VaccinationDetails vaccination in vaccinationList)
            {
                if (currentLoginUser.RegistrationID == vaccination.RegistrationID)
                {
                    flag = false;
                    if (vaccination.DoseNumber == 3)
                    {
                        // If he completed the third dose, display “You have completed all vaccination. Thanks for your participation in the vaccination drive.”
                        Console.WriteLine("You have completed all vaccination. Thanks for your participation in the vaccination drive.");
                    }
                    else
                    {
                        // If either first or second dose of vaccine completed means Add 30 days to find the next due date to vaccine.
                        tempDate = vaccination.VaccinatedDate;
                    }
                }
            }
            nextEligibleDate = tempDate.AddDays(30);
            Console.WriteLine($"The Next eligible Date is {nextEligibleDate.ToString("dd/MM/yyyy")}");
            if (flag)
            {
                // If he didn’t take any dose already. Then show “you can take vaccine now”.
                Console.WriteLine("You can take vaccination now");
            }
        }
    }
}