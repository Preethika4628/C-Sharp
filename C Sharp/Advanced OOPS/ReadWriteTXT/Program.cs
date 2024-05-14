using System;
using System.IO;
namespace ReadWriteTXT;
class Program 
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Console.WriteLine("Creating folder");
            Directory.CreateDirectory("TestFolder");
        }
        else
        {
            Console.WriteLine("Directory exists");
        }

        if(!File.Exists("TestFolder/MyFile.txt"))
        {
            Console.WriteLine("Creating the file");
            File.Create("TestFolder/MyFile.txt").Close();
        }
        else
        {
            Console.WriteLine("File already exists");
        }

        Console.WriteLine("Select 1.Read from file  2.Write from file");
        int option = int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                StreamReader sr = new StreamReader("TestFolder/MyFile.txt");
                string data = sr.ReadLine();
                while(data != null)
                {
                    Console.WriteLine(data);
                    data = sr.ReadLine();
                }
                sr.Close();
                break;
            }
            case 2:
            {
                string[] contents = File.ReadAllLines("TestFolder/MyFile.txt");
                StreamWriter sw = new StreamWriter("TestFolder/MyFile.txt");
                Console.WriteLine("Enter what do you want to place in file: ");
                string data = Console.ReadLine();
                string old = "";
                foreach(string line in contents)
                {
                    old = old + line + "\n";
                }
                old = old + data + "\n";
                sw.WriteLine(old);
                sw.Close();
                break;
            }
        }
    }
}