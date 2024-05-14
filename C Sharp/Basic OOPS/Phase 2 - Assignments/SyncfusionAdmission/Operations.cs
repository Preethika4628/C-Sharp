using System;
using System.Collections.Generic;
namespace SyncfusionAdmission
{
    public static class Operations
    {
        static List<StudentDetails> studentList = new List<StudentDetails>();
        static List<DepartmentDetails> departmentList = new List<DepartmentDetails>();
        static List<AdmissionDetails> admissionList = new List<AdmissionDetails>();
        static StudentDetails currentLoginStudent; //cookie object

        public static void AddDefaultData()
        {
            // Console.WriteLine("Adding default data");
            //create list for all classes
            //create objects
            //add to list
            //traverse and show the added data

            StudentDetails student1 = new StudentDetails("Ravichandran E", " Ettapparajan", new DateTime(1999, 11, 11), Gender.Male, 95, 95, 95);
            studentList.Add(student1);
            StudentDetails student2 = new StudentDetails("Baskaran S", " Sethurajan", new DateTime(1999, 11, 11), Gender.Male, 95, 95, 95);
            studentList.Add(student2);

            DepartmentDetails department1 = new DepartmentDetails("EEE", 29);
            departmentList.Add(department1);
            DepartmentDetails department2 = new DepartmentDetails("CSE", 29);
            departmentList.Add(department2);
            DepartmentDetails department3 = new DepartmentDetails("MECH", 30);
            departmentList.Add(department3);
            DepartmentDetails department4 = new DepartmentDetails("ECE", 30);
            departmentList.Add(department4);

            AdmissionDetails admission1 = new AdmissionDetails(student1.StudentID, department1.DepartmentID, new DateTime(2022, 05, 11), AdmissionStatus.Admitted);
            admissionList.Add(admission1);
            AdmissionDetails admission2 = new AdmissionDetails(student2.StudentID, department2.DepartmentID, new DateTime(2022, 05, 12), AdmissionStatus.Admitted);
            admissionList.Add(admission2);

            Console.WriteLine("Student Details:");
            foreach (StudentDetails student in studentList)
            {
                Console.WriteLine($"|  {student.StudentID,-10}  |  {student.StudentName,-15}  |  {student.FatherName,-15}  |  {student.DOB.ToString("dd/MM/yyyy"),-15}  |  {student.Gender,-15}  |  {student.Physics,-10}  |  {student.Chemistry,-10}  |  {student.Maths,-10}");
            }
            Console.WriteLine("Department Details:");
            foreach (DepartmentDetails department in departmentList)
            {
                Console.WriteLine($"|  {department.DepartmentID,-10}  |  {department.DepartmentName,-15}  |  {department.NumberOfSeats,-15}  ");
            }
            Console.WriteLine("Admission Details:");
            foreach (AdmissionDetails admission in admissionList)
            {
                Console.WriteLine($"|  {admission.AdmissionID,-10}  |  {admission.StudentID,-10}  |  {admission.DepartmentID,-10}  |  {admission.AdmissionDate.ToString("dd/MM//yyyy"),-15}  |  {admission.AdmissionStatus,-15}  ");
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
                        Registration();
                        break;
                    case 2:
                        Login();
                        break;
                    case 3:
                        Console.WriteLine("Exit selected");
                        flag = false;
                        break;
                }
            } while (flag);
        }
        public static void Registration()
        {
            Console.WriteLine("STUDENT REGISTRATION FORM:");
            Console.Write("Enter your name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter your father name: ");
            string fatherName = Console.ReadLine();
            Console.Write("Enter your date of birth in dd//MM//yyyy: ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Select your gender: 1.Male 2.Female 3.Transgender ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            Console.Write("Enter your Physics mark: ");
            int physics = int.Parse(Console.ReadLine());
            Console.Write("Enter your Chemistry mark: ");
            int chemistry = int.Parse(Console.ReadLine());
            Console.Write("Enter you Maths mark: ");
            int maths = int.Parse(Console.ReadLine());

            StudentDetails student = new StudentDetails(studentName, fatherName, dob, gender, physics, chemistry, maths);
            Console.WriteLine("Student Registered Successfully and Student-ID is  " + student.StudentID);
            studentList.Add(student);
        }
        public static void Login()
        {
            //get user ID
            //traverse StudentList
            //Find whether user id present
            //if userID not present, show invalid userID.
            //if userID present, store current login cookie object globally
            //then show the submenu
            Console.Write("Enter the studentID: ");
            string id = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (StudentDetails student in studentList)
            {
                if (student.StudentID == id)
                {
                    Console.WriteLine("Logged in successfully..!");
                    currentLoginStudent = student;
                    flag = false;
                    SubMenu();
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Student-ID is invalid");
            }
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Choose:  1.Check Eligibility  2.Show Details  3.Take Admission  4.Cancel Admission  5.Show Admission Details  6.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        CheckEligibility();
                        break;
                    case 2:
                        ShowDetails();
                        break;
                    case 3:
                        TakeAdmission();
                        break;
                    case 4:
                        CancelAdmission();
                        break;
                    case 5:
                        ShowAdmissionDetails();
                        break;
                    case 6:
                        flag = false;
                        break;
                }
            } while (flag);
        }
        public static void CheckEligibility()
        {
            bool value = currentLoginStudent.IsEligibile(75.0);
            if (value)
            {
                Console.WriteLine("Student is eligible");
            }
            else
            {
                Console.WriteLine("Student is not eligible");
            }
        }
        public static void ShowDetails()
        {
            Console.WriteLine($"|  {currentLoginStudent.StudentID,-10}  |  {currentLoginStudent.StudentName,-15}  |  {currentLoginStudent.FatherName,-15}  |  {currentLoginStudent.DOB.ToString("dd/MM//yyyy"),-15}  |  {currentLoginStudent.Gender,-15}  |  {currentLoginStudent.Physics,-10}  |  {currentLoginStudent.Chemistry,-10}  |  {currentLoginStudent.Maths,-10}");
        }
        public static void TakeAdmission()
        {
            //Show the list of available departments and number of seats available by traversing the department details list
            Console.WriteLine("Department Details:");
            foreach (DepartmentDetails department in departmentList)
            {
                Console.WriteLine($"|  {department.DepartmentID,-10}  |  {department.DepartmentName,-15}  |  {department.NumberOfSeats,-15}  ");
            }
            //Ask the student to pick one DepartmentID
            Console.Write("Enter the department ID: ");
            string departmentID = Console.ReadLine().ToUpper();
            // Validate the DepartmentID is present in the list.
            bool flag = true;
            foreach (DepartmentDetails department in departmentList)
            {
                if (department.DepartmentID == departmentID)
                {
                    flag = false;
                    // If it is present, then check whether he is eligible to take admission.
                    bool temp = currentLoginStudent.IsEligibile(75);
                    if (temp)
                    {
                        //If he is eligible, check whether seat available or not
                        if (department.NumberOfSeats > 0)
                        {
                            bool admissionStatusFlag = true;
                            // if seats available then Check whether the student has already taken any admission by traversing admission details list. If he didn’t took any admission previously.
                            foreach (AdmissionDetails admission in admissionList)
                            {
                                if (currentLoginStudent.StudentID == admission.StudentID && admission.AdmissionStatus == AdmissionStatus.Admitted)
                                {
                                    admissionStatusFlag = false;
                                }
                            }
                            // Then, Reduce the seat count in department list and create admission details object by using StudentID, DepartmentID, AdmissionDate as Now, AdmissionStatus and Booked and add it to list.
                            if (admissionStatusFlag)
                            {
                                department.NumberOfSeats--;
                                AdmissionDetails admission = new AdmissionDetails(currentLoginStudent.StudentID, department.DepartmentID, DateTime.Now, AdmissionStatus.Admitted);
                                admissionList.Add(admission);
                                // Finally show “Admission took successfully.Your admission ID – SF3001”.
                                Console.WriteLine($"Admission added successfully. your admissionID is {admission.AdmissionID}");
                            }
                            else
                            {
                                Console.WriteLine("You have already taken admission");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Seat not avaiable");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not eligible for admission");
                    }
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Department ID not present");
            }
        }
        public static void CancelAdmission()
        {
            bool flag = true;
            //Show the current logged in student’s admission detail by traversing the list which AdmissionStatus Property is Booked. If fount then show it.
            foreach (AdmissionDetails admission in admissionList)
            {
                if (currentLoginStudent.StudentID == admission.AdmissionID && admission.AdmissionStatus == AdmissionStatus.Admitted)
                {
                    flag = false;
                    //Change the Admission status property to Cancelled.
                    admission.AdmissionStatus = AdmissionStatus.Cancelled;
                    //Return the seat to Department Details list
                    foreach (DepartmentDetails department in departmentList)
                    {
                        if (admission.DepartmentID == department.DepartmentID)
                        {
                            department.NumberOfSeats++;
                        }
                    }
                    //Finally show admission cancelled successfully.
                    Console.WriteLine("Admission succesfully cancelled");
                }
            }
            if (flag)
            {
                Console.WriteLine("You have not taken any admission");
            }
        }
        public static void ShowAdmissionDetails()
        {
            bool flag = true;
            foreach (AdmissionDetails admission in admissionList)
            {
                if (admission.StudentID == currentLoginStudent.StudentID)
                {
                    flag = false;
                    Console.WriteLine($"|  {admission.AdmissionID,-10}  |  {admission.StudentID,-10}  |  {admission.DepartmentID,-10}  |  {admission.AdmissionDate.ToString("dd/MM//yyyy"),-15}  |  {admission.AdmissionStatus,-15}  ");
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid Student ID");
            }
        }
    }
}