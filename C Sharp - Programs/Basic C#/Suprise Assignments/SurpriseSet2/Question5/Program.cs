using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string s1 = Console.ReadLine();
        string[] a1 = s1.Split(',');
        int[] arr1 = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr1[i] = int.Parse(a1[i]);
        }
        string s2 = Console.ReadLine();
        string[] a2 = s2.Split(',');
        int[] arr2 = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr2[i] = int.Parse(a2[i]);
        }
        string str = string.Empty;
        string[] s = new string[n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (arr1[i] == arr2[j])
                {
                    str += arr1[i] + " ";
                }
            }
        }
        string resultString = string.Empty;
        for (int i = 0; i < str.Length; i++)
        {
            if (!resultString.Contains(str[i]))
            {
                resultString += str[i];
            }
        }
        Console.WriteLine(resultString.Trim());

    }
}