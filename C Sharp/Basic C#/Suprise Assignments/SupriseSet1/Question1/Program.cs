using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        //character containing even number of occurrences should be elaborated else print the same format
        string str = Console.ReadLine();
        char[] ch = str.ToCharArray();
        string NewS = "";
        int n = str.Length;
        for(int i=0; i<n; i++)
        {
            if(ch[i]>='0' && ch[i]<='9')
            {
                char c = ch[i-1];
                if(ch[i]%2==0)
                {
                    int num = ch[i];
                    for(int j=0; j<=num; j++)
                    {
                        NewS = NewS + c;
                    }
                }
            }
        }
        Console.WriteLine(NewS);
    }
}