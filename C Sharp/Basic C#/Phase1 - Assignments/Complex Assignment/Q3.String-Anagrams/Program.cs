using System;
namespace Q3;
class Program 
{
    public static void Main(string[] args)
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        char[] c1 = s1.ToCharArray();
        char[] c2 = s2.ToCharArray();
        for(int i=0; i<c1.Length-1;)
        {
            if(c1.Contains(c2[i]))
            {
                Console.WriteLine("Anagrams");
                break;
            }
            else
            {
                Console.WriteLine("Not Anagrams");
                break;
            }
        }
    }
}