using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        string s1 = Console.ReadLine();
        string[] str = s1.Split(' ');
        string sn = "";
        for(int i=0; i<str.Length; i++)
        {
            if(i==0)
            {
                sn += str[i].ToUpper() + " ";
            }
            if(i>0)
            {
                if(i%2!=0)
                {
                    sn += str[i].ToLower() + " ";
                }
                else if(i%2==0)
                {
                    sn = sn + str[i].ToUpper() + " ";
                }
            }
        }
        Console.WriteLine(sn.Trim());
    }
}