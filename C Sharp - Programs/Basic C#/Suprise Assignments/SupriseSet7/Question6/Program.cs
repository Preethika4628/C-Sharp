using System;
namespace Question6;
class Program 
{
    public static void Main(string[] args)
    {
        string s1 = Console.ReadLine();
        string[] str = s1.Split(' ');
        string winner = str[0];
        int count = 0;
        for(int i=0; i<str.Length; i++)
        {
            if(winner == str[i])
            {
                count++;
            }
        }
        string result;
        result = winner + " " + count;
        Console.WriteLine(result);
    }
}