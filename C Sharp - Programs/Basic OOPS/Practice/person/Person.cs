using System;
using System.IO;

class person1
{
    //fields
    private string _name;
    //property/accessors - data retrieve and set
    //property can be read only or write only
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    //autoproperty - 
    public string Name1 { get; set; } //attribute of class




    // //Example - Default constructor
    // Class Duster
    // {
    //     public int height { get; set; }
    //     public int width { get; set; }
    //     public string color { get; set; }
    //     //default constructor
    //     public Duster()
    //     {
    //         height = 2;
    //         width = 10;
    //         color = "Black";
    //     }
    // }
    // Duster duster = new Duster();


    // //Example - Parameterized constructor
    // Class Duster
    // {
    //     public int height { get; set; }
    //     public int width { get; set; }
    //     public string Color { get; set; }
    //     //default constructor
    //     public Duster(string color)
    //     {
    //         height = 2;
    //         width = 10;
    //         Color = color;
    //     }
    // }
    // Duster duster = new Duster("red");

    // //desctructor
    // ~Duster()
    // {
    // }

    //methods
    
    // //static class
    // static class FileHandler
    // {
    //     private static string s_filepath = "C://programFiles//program.cs";
    //     public static string FilePath 
    //     {
    //         get {return s_filepath;}
    //     }
    //     static FileHandler()
    //     {
    //         s_filepath = "C://programFiles//program.cs";
    //     }
    //     public static bool IsFileExists()
    //     {
    //         if(File.Exists(s_filepath))
    //         {
    //             return true;
    //         }
    //         return false;
    //     }
    // }
    // Console.WriteLine(FileHandler.FilePath); //calls default constructor bcz of static class only for frist time
    // //1. constrcutor    
    // //2. Field information
    // //3. Access property

}