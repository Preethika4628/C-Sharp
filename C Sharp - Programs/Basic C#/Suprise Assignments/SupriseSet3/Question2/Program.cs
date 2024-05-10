using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();
        char[] c = s.ToCharArray();
        // int count = 0;
        Console.WriteLine(c);
        for(int i=0; i<s.Length-1; i++)
        {
            if(c[i] == c[i+1])
            {
                char d = c[i];
            }
            // for(int j=0; j<s.Length-1; j++)
            // {
            //     char d = c[j];
            // }
        }
        Console.WriteLine();
    }
}