using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        //SuperiseSet 5 - ques 2
        int K = int.Parse(Console.ReadLine());
        string s1 = Console.ReadLine();
        char[] ch = s1.ToCharArray();
        int size = ch.Length;
        char[] chNew = new char[size+size];
        int j=0;
        string[] newS = new string[chNew.Length];
        for(int i=K-1; i<size; i=i+K)
        {
            if(K==1 && j<chNew.Length)
            {
                chNew[j] = ch[i];
                j++;
                if(!(j==chNew.Length-1))
                {
                    chNew[j+1] = ' ';
                }
                j++;
            }
            else if(j<size+1)
            {
                chNew[j] = ch[i];
                j++;
                if(!(j==size-2))
                {
                    chNew[j+1] = ' ';
                    j++;
                }
            }
        }
        j=0;
        for(int i=0; i<chNew.Length; i++)
        {
            if(i==chNew.Length-1)
            {
                newS[j] = chNew[i].ToString();
            }
            else
            {
                newS[j] = chNew[i].ToString();
                j++;
            }
        }
        Console.WriteLine(newS.ToString());




        // string array = newS.ToString();
        // Console.WriteLine(array.TrimEnd());



        // for(int i=0; i<chNew.Length; i++)
        // {
        //     if(i==chNew.Length-1)
        //     {
        //         Console.Write(chNew[i]);
        //     }
        //     else
        //     {
        //         Console.WriteLine(chNew[i] + ' ');
        //     }
        // }
        
    }
}