using System;
namespace Array;
class Program 
{
    public static void Main(string[] args)
    {
        string[] name = new string[5]{"Mani" , "Ganesh", "Venkat", "Suresh", "Preethi"};
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(name[i]);
        }

        Console.Write("Enter a name: ");
        string Sname = Console.ReadLine();
        bool flag = true;
        foreach(string temp in name)
        {
            if(Sname.Equals(temp))
            {
                flag = false;
                Console.WriteLine("The name is present in the array");
            }
        }
        if(flag == true)
        {
            Console.WriteLine("The name is not present");
        }

    }
}