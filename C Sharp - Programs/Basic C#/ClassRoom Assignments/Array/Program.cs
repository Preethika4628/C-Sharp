using System;
namespace Array;
class Program
{
    public static void Main(string[] args)
    {
        string[] name = new string[5]{"Mani", "Ganesh", "Suresh", "Venkat", "Venkat"};
        foreach(string i in name)
        {
            Console.WriteLine($"{i}");
        }

        //forLoop
        Console.Write("Enter a name: ");
        string search  = Console.ReadLine();
        int flag=0;
        for(int i =0;i<name.Length;i++)
        {
            if(name[i]==search)
            {
                Console.WriteLine("The name is present in array");
                break;
            }
            else if(flag==name.Length-1 && name[i]!=search)
            {
                Console.WriteLine("The name is not present in array");
            }
            flag++;
            
        }

        //forEachLoop
        int count =0;
        Console.Write("Enter a name: ");
        string str  = Console.ReadLine();
        foreach(string i in name)
        {
            if(i==str)
            {
                Console.WriteLine("The name is present in array");
                break;
            }
            else if(count==name.Length-1 && i!=str)
            {
                Console.WriteLine("The name is not present in array");
            }
            count++;
            
        }

    }
}