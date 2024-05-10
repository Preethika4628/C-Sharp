using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace ReadWrite;
class Program
{
    public static void Main(string[] args)
    {
        if (!Directory.Exists("TestFolder"))
        {
            Console.WriteLine("Creating folder...");
            Directory.CreateDirectory("TestFolder");
        }
        else
        {
            Console.WriteLine("Directory exists");
        }

        //csv file creation
        if (!File.Exists("TestFolder/Data.csv"))
        {
            Console.WriteLine("Creating file...");
            File.Create("TestFolder/Data.csv").Close();
        }
        else
        {
            Console.WriteLine("CSV file already exists");
        }

        //JSON file creation
        if (!File.Exists("TestFolder/Data.json"))
        {
            Console.WriteLine("Creating file...");
            File.Create("TestFolder/Data.json").Close();
        }
        else
        {
            Console.WriteLine("JSON file already exists");
        }

        List<Student> studentList = new List<Student>();
        studentList.Add(new Student() { Name = "Preethi", Fathername = "Sathish", DOB = new DateTime(2000, 11, 01), Gender = Gender.Female, TotalMarks = 400 });
        studentList.Add(new Student() { Name = "Sha", Fathername = "Sathish", DOB = new DateTime(2009, 11, 16), Gender = Gender.Female, TotalMarks = 475 });
        studentList.Add(new Student() { Name = "Sri", Fathername = "Sathish", DOB = new DateTime(2009, 11, 16), Gender = Gender.Female, TotalMarks = 485 });
        WriteToCSV(studentList);
        ReadCSV();
        WriteToJSON(studentList);
        ReadJSON();
    }

    static void WriteToCSV(List<Student> studentList)
    {
        StreamWriter sw = new StreamWriter("TestFolder/Data.csv");
        foreach (Student student in studentList)
        {
            string line = student.Name + "," + student.Fathername + "," + student.Gender + "," + student.DOB.ToString("dd/MM/yyyy") + "," + student.TotalMarks;
            sw.WriteLine(line);
        }
        sw.Close();
    }
    static void ReadCSV()
    {
        List<Student> newList = new List<Student>();
        StreamReader sr = new StreamReader("TestFolder/Data.csv");
        string line = sr.ReadLine();
        while (line != null)
        {
            string[] values = line.Split(",");
            if (values[0] != "")
            {
                Student student = new Student()
                {
                    Name = values[0],
                    Fathername = values[1],
                    Gender = Enum.Parse<Gender>(values[2]),
                    DOB = DateTime.ParseExact(values[3], "dd/MM/yyyy", null),
                    TotalMarks = int.Parse(values[4])
                };
                newList.Add(student);
            }
            line = sr.ReadLine();
        }
        sr.Close();
        Console.WriteLine("Data in CSV file: ");
        foreach (Student student in newList)
        {
            Console.WriteLine($"{student.Name,-10}  |  {student.Fathername,-10}  |  {student.Gender}  |  {student.DOB.ToString("dd/MM/yyyy")}  |  {student.TotalMarks}");
            // Console.WriteLine("Name: " + student.Name, "Father Name: " + student.Fathername);
            // Console.Write(" Gender: " + student.Gender, "DOB: " + student.DOB, "Total Marks: " + student.TotalMarks);
        }
    }
    static void WriteToJSON(List<Student> studentList) 
    {
        StreamWriter sw = new StreamWriter("TestFolder/Data.json");
        var option = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        string jsonData = JsonSerializer.Serialize(studentList,option);
        sw.WriteLine(jsonData);
        sw.Close();
    }
    static void ReadJSON()
    {
        StreamReader sr = new StreamReader("TestFolder/Data.json");
        List<Student> students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("TestFolder/Data.json"));
        Console.WriteLine("Data in JSON file: ");
        foreach(Student student in students)
        {
            Console.WriteLine($"{student.Name,-10}  |  {student.Fathername,-10}  |  {student.Gender}  |  {student.DOB.ToString("dd/MM/yyyy")}  |  {student.TotalMarks}");
            // Console.WriteLine("Name: "+student.Name + "Father Name: " + student.Fathername);
            // Console.WriteLine("Gender: "+ student.Gender + "DOB: "+student.DOB.ToString("dd/MM/yyyy"));
            // Console.WriteLine("Total Marks"+student.TotalMarks);

        }
    }
}