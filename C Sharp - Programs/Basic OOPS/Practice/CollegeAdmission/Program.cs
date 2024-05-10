using System;
using System.Collections.Generic;
namespace CollegeAdmission;


class Program
{
    public static void Main(string[] args)
    {
        //Problems in Procedural oriented language 

        List<StudentDetails> studentList = new List<StudentDetails>();

        string option = "";
        do
        {
            //action to be repeated
            Console.WriteLine("Student Registration Form:-");

            //student 1
            //Printing the form to get the details
            // StudentDetails student1 = new StudentDetails();

            Console.Write("Enter your name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter your father name: ");
            string fatherName = Console.ReadLine();

            // Console.Write("Enter your gender: ");
            // string gender  = Console.ReadLine();
            Console.Write("Select your gender: 1.Male 2.Female 3.Transgender");
            Gender gender  = Enum.Parse<Gender>(Console.ReadLine(), true);

            Console.Write("Enter your date of birth in dd//MM//yyyy: ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Enter your phone number: ");
            long phone = long.Parse(Console.ReadLine());

            Console.Write("Enter your Physics marks: ");
            int physics = int.Parse(Console.ReadLine());

            Console.Write("Enter your Chemistry marks: ");
            int chemistry = int.Parse(Console.ReadLine());

            Console.Write("Enter your Maths marks: ");
            int maths = int.Parse(Console.ReadLine());

            //parameterixed constructor object
            StudentDetails student = new StudentDetails(studentName, fatherName, gender, dob, phone, physics, chemistry, maths);
            Console.WriteLine("You have registered successfully. Your ID is " + student.StudentID);
            studentList.Add(student);

            //loop breaker
            Console.WriteLine("Do you want to continue");
            option = Console.ReadLine();
            option = option.ToLower();

        } while (option == "yes");

        Console.WriteLine("Enter your student id to login");
        string loginID = Console.ReadLine().ToUpper();
        bool flag = true;


        Console.WriteLine("StudentDetails Details:-");
        foreach (StudentDetails student in studentList)
        {
            if (student.StudentID == loginID)
            {
                flag = false;
                Console.WriteLine("Name: " + student.StudentName);
                Console.WriteLine("Father Name: " + student.FatherName);
                Console.WriteLine("DOB: " + student.DOB);
                Console.WriteLine("Gender: " + student.Gender);
                Console.WriteLine("Phone Number: " + student.Phone);
                Console.WriteLine("Physics mark: " + student.Physics);
                Console.WriteLine("Chemistry mark: " + student.Chemistry);
                Console.WriteLine("Maths mark: " + student.Maths);
                bool eligibility = student.CheckEligibilty(75.0);
                // bool eligibility = student.IsEligibilty(75.0);
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

    }
}