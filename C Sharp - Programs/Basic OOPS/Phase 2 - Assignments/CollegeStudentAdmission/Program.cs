using System;
using System.Collections;
using System.Collections.Generic;
namespace CollegeStudentAdmission;
class Program
{
    static List<StudentDetails> studentList = new List<StudentDetails>();
    static StudentDetails parentStudent;

    public static void Main(string[] args)
    {
        int n;
        do
        {
            Console.WriteLine("---SYNCFUSION COLLEGE OF ENGINEERING AND TECHNOLOGY---");
            Console.WriteLine("Choose: \n1.Student Registration \n2.Student Login \n3.Exit");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    string option = "";
                    Registration(option);
                    break;
                case 2:
                    Login();
                    break;
                case 3:
                    break;
            }
        } while (n != 3);
    }

    private static void Registration(string option)
    {
        do
        {
            Console.WriteLine("STUDENT REGISTRATION FORM:");
            Console.Write("Enter your name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter your father name: ");
            string fatherName = Console.ReadLine();
            Console.Write("Enter your date of birth in dd//MM//yyyy: ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Select your gender: 1.Male 2.Female 3.Transgender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            Console.Write("Enter your Physics mark: ");
            int physics = int.Parse(Console.ReadLine());
            Console.Write("Enter your Chemistry mark: ");
            int chemistry = int.Parse(Console.ReadLine());
            Console.Write("Enter you Maths mark: ");
            int maths = int.Parse(Console.ReadLine());
            
            StudentDetails student = new StudentDetails(studentName, fatherName, dob, gender, physics, chemistry, maths);
            Console.WriteLine("Registered successfully");
            Console.WriteLine("Your student id is " + student.StudentID);
            studentList.Add(student);
        } while (option == "yes");
    }
    private static void Login()
    {
        Console.Write("Choose the below option: \n1.Check eligibilty \n2.Show details \n3.Take admission \n4.Cancel admission \n5.Show Admission details \n6.Exit \n");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter your student id to login");
                string loginID = Console.ReadLine().ToUpper();
                bool flag = true;

                Console.WriteLine("StudentDetails Details:-");
                foreach (StudentDetails student in studentList)
                {
                    if (student.StudentID == loginID)
                    {
                        parentStudent = student;
                        flag = false;
                        bool eligibility = student.CheckEligibilty(75.0);
                        if (eligibility)
                        {
                            Console.WriteLine("You are aligible for admission");
                        }
                        else
                        {
                            Console.WriteLine("You are not eligible for admission");
                        }
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Invalid User ID");
                }
                break;

            case 2:
                ShowDetails();
                break;
            case 3:
                // TakeAdmission();
                break;
            case 4:
                // CancelAdmission();
                break;
            case 5:
                // ShowAdmissionDetails();
                break;
            case 6:
                break;


        }
    }

    private static void ShowDetails()
    {
        Console.WriteLine("Enter your student id to login");
        string loginID = Console.ReadLine().ToUpper();
        Console.WriteLine("Student Details:-");
        bool flag = true;
        
        foreach (StudentDetails student in studentList)
        {
            if (student.StudentID == loginID)
            {
                flag = false;
                Console.WriteLine("Name: " + student.StudentName);
                Console.WriteLine("Father Name: " + student.FatherName);
                Console.WriteLine("DOB: " + student.DOB);
                Console.WriteLine("Gender: " + student.Gender);
                Console.WriteLine("Physics mark: " + student.Physics);
                Console.WriteLine("Chemistry mark: " + student.Chemistry);
                Console.WriteLine("Maths mark: " + student.Maths);
            }
        }
        if (flag)
        {
            Console.WriteLine("Invalid User ID");
        }
    }
}

