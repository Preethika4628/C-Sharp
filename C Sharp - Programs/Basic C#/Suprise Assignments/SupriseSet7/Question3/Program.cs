using System;
using System.Linq;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        string s1 = Console.ReadLine();
        string str = "";
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] > 'a' && s1[i] < 'z')
            {
                str = str + (char)(s1[i] - 32);
                
            }
            else if(s1[i] > 'A' && s1[i] < 'Z')
            {
                str = str + (char)(s1[i] + 32);
                
            }
            else
            {
                str = str + s1[i];
            }
        }
        string ch = str.ToString();
        Console.WriteLine(ch);
        // char c = (char)('P' + 32);
        // Console.Write(c);
        

    }
}