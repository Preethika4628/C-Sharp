using System;
namespace Library;
class Program 
{
    public static void Main(string[] args)
    {
        BookInfo book = new BookInfo("CSE", "B.E CS", 7, 5, "Panchathantra", "Vivek", 1200);
        Console.WriteLine(book.DisplayInfo());
    }
}