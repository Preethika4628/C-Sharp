using System;
using System.Globalization;
using System.Reflection.Metadata;
using Microsoft.VisualBasic;
namespace String;
class Program 
{
    public static void Main(string[] args)
    {
        string firstName = "Preethika Sathish";
        string lastName = "Sathish";
        string otherName = "preethika sathish";

        Console.WriteLine("Clone: "+ firstName.Clone());

        Console.WriteLine("CompareTo: " + firstName.CompareTo(lastName));
        Console.WriteLine("CompareTo: " + firstName.CompareTo(firstName));
        Console.WriteLine("CompareTo: " + firstName.CompareTo(otherName));

        Console.WriteLine("Equals: " + firstName.Equals(lastName));
        Console.WriteLine("Equals: " + firstName.Equals(firstName));
        Console.WriteLine("Equals: " + firstName.Equals(otherName, StringComparison.CurrentCultureIgnoreCase));

        Console.WriteLine("Contains: " + firstName.Contains("ree"));

        Console.WriteLine("IndexOf: " + firstName.IndexOf('a'));

        Console.WriteLine("ToLower: " + firstName.ToLower());
        Console.WriteLine("ToUpper: " + otherName.ToUpper());

        Console.WriteLine("Insert: " + firstName.Insert(0, "Hello "));

        Console.WriteLine("LastIndexOf: " + firstName.LastIndexOf('e'));

        Console.WriteLine("Length: " + firstName.Length);

        Console.WriteLine("Remove: " + otherName.Remove(5));
        Console.WriteLine("Remove: " + otherName.Remove(6, 2));

        Console.WriteLine("Remove: " + otherName.Replace('e','i'));


        string[] splitChar = firstName.Split(new char[] {'e', ' '});
        string[] splitString = firstName.Split(new string[] {"ee", "ha"}, StringSplitOptions.None);
        string[] splitA = firstName.Split('e');
        string[] SplitB = firstName.Split('e', 'a');
        Console.WriteLine(splitChar[0]);
        Console.WriteLine(splitString[1]);
        Console.WriteLine(splitA[2]);
        Console.WriteLine(SplitB[4]);

        Console.WriteLine("StartsWith: "+ firstName.StartsWith("S"));

        Console.WriteLine("SubString: "+ firstName.Substring(7, 5));

        char[] array = firstName.ToCharArray();
        foreach(var character in array)
        {
            Console.WriteLine(character);
        }

         string sampleString = ("Anu, Banu, Ramya, Bavya, Priya");
         Console.WriteLine(sampleString);
         string[] words = sampleString.Split(',');
         Console.Write("Splitted string are: ");
         for(int i=0; i<words.Length; i++)
         {
            Console.Write(words[i]);
         }
         Console.WriteLine();

         string joinS = string.Join(" -", words);
         Console.WriteLine("Join String: "+ joinS);

         Console.WriteLine(firstName.Trim());//TrimStart, TrimEnd

         string hello="Hello C#";
         string padLeft = hello.PadLeft(20);
         string charPad = hello.PadLeft(20, '#');
         Console.WriteLine(hello);
         Console.WriteLine(padLeft);
         Console.WriteLine(charPad);

         string hello1 = "Hello c#";
         string padRight = hello1.PadRight(20);
         string charPad1 = hello1.PadRight(20, '#');
        Console.WriteLine(hello1);
         Console.WriteLine(padRight);
         Console.WriteLine(charPad1);



//         // //Practice Prog - 1.Sum of teh weight of the string:
//         // string S = Console.ReadLine();
//         // int result = 0;
//         // foreach(char c in S)
//         // {
//         //     result += c;
//         // }
//         // Console.WriteLine(result);


//         // //Practise Prog - 2.Length of a string without using built in funxtion
//         // string s1 = Console.ReadLine();
//         // char[] ch = s1.ToCharArray();
//         // int count = 0;
//         // foreach(int i in ch)
//         // {
//         //     count++;
//         // }
//         // Console.WriteLine(count);

//         // string str = "Preethi";
//         // int len=0;

//         // foreach(char c in str)
//         // {
//         //     len+=1;
//         // }
//         // Console.WriteLine(len);


//         // //Practise Prog - 3. Print individual charcter in a string
//         // string s2 = Console.ReadLine();
//         // char[] ch1 = s2.ToCharArray();
//         // foreach(char c in ch1)
//         // {
//         //     Console.WriteLine(c);
//         // }


//         // //Practice Prog - 4.Count the total number of words
//         // string s = Console.ReadLine();
//         // int count=0;
//         // string[] words = s.Split(' ');
//         // foreach(string s1 in words)
//         // {
//         //     count++;
//         // }
//         // Console.WriteLine(count);

//         // //Practise Prog - 6.Count total vowels and constant in a string:
//         // string s1 = Console.ReadLine();
//         // string s = s1.ToLower();
//         // int vow = 0, cons = 0;
//         // foreach(char c in s)
//         // {
//         //     if(c =='a' || c =='e' || c =='i' || c =='o' || c =='u')
//         //     {
//         //         vow++;
//         //     }
//         //     else if(c>'a' && c<='z')
//         //     {
//         //         cons++;
//         //     }
//         // }
//         // Console.WriteLine($"Total number of vowels: {vow}");
//         // Console.WriteLine($"Total number of constants: {cons}"); 


//         //phase i assignment-1: 1.Remove the whitespace and return the length
//         // string s = Console.ReadLine();
//         // int count=0;
//         // string[] words = s.Split(' ');
//         // foreach(string s1 in words)
//         // {
//         //     for(int i=0; i>)
//         // }
//         // Console.WriteLine(count); 

        
//         // //Medium assignment - ques 10: number of alphabets, characters, special character
//         // string s1 = Console.ReadLine();
//         // string s = s1.ToLower();
//         // int alpha=0, num=0, special=0;
        
//         // Console.WriteLine("The number of Alphabets in the string is:" + CountAlphabets(string s));

//         // static int CountAlphabets( string s)
//         // { 
//         //     int count=0;
//         //     foreach(char n in s)
//         //     {
//         //         if(alpha>='a'&& alpha<'z')
//         //         {
//         //             count++;
                    
//         //         }
//         //         Console.WriteLine(alpha);
//         //         return count;
//         //     }
//         // static void CountDigits(int num)
//         // {
//         //     Console.WriteLine(num);
//         // }
//         // static void CountSpecialChars(int special)
//         // {
//         //     Console.WriteLine(special);
//         // }


//         // string s = "5,2,6";
//         // string[] s1 = s.Split(',');
//         // int[] arr = new int[3];
//         // for(int i=0; i<3; i++)
//         // {
//         //     arr[i] = int.Parse(s1[i]);
//         // }


//         // //removes the duplicate character
//         // string inputString = Console.ReadLine();
//         // string resultString = string.Empty;
//         // for (int i = 0; i < inputString.Length; i++)
//         // {
//         //     if (!resultString.Contains(inputString[i]))
//         //     {
//         //         resultString += inputString[i];
//         //     }
//         // }
//         // Console.WriteLine(resultString);
//         // Console.ReadKey();

//         // string s1 = Console.ReadLine();
//         // string s2 = Console.ReadLine();

//         // if(s1.Equals(s2))
//         // {
//         //     Console.WriteLine("The two strings are equal.");
//         // }
//         // else
//         // {
//         //     Console.WriteLine("The two strings are not equal.");   
//         // }


//         string name1 = Console.ReadLine();
//         string name2 = Console.ReadLine();
//         int index1 = name1.IndexOf(" ");
//         index1 = index1 < 0 ? 0 : index1--;
//         int index2 = name2.IndexOf(" ");
//         index2 = index2 < 0 ? 0 : index2--;
//         int length = Math.Max(name1.Length, name2.Length);
//         if (string.Compare(name1, index1, name2, index2, length, new CultureInfo("en-US"), CompareOptions.IgnoreCase) < 0)
//             Console.WriteLine("{0}\n{1}", name1, name2);
//         else
//             Console.WriteLine("{0}\n{1}", name2, name1);
//     }
// }

// using System;
// namespace System.Globalization;

//         class Program
//         {
//             public static void Main(string[] args)
//             {
                // //last name sorting
                // string name1 = Console.ReadLine();
                // string name2 = Console.ReadLine();
                // int index1 = name1.IndexOf(" ");
                // index1 = index1 < 0 ? 0 : index1--;
                // int index2 = name2.IndexOf(" ");
                // index2 = index2 < 0 ? 0 : index2--;
                // int length = Math.Max(name1.Length, name2.Length);
                // if (string.Compare(name1, index1, name2, index2, length, new CultureInfo("en-US"), CompareOptions.IgnoreCase) < 0)
                // {
                //     Console.WriteLine($"{0}\n{1}", name1, name2);
                // } 
                // else
                // {
                //     Console.WriteLine($"{0}\n{1}", name2, name1);
                // }

                // //substring occurence
                // string sentence = Console.ReadLine();
                // string substring = Console.ReadLine();
                // string occurence = Console.ReadLine();
                // substring = substring.Insert(substring.Length," ");
                // string result = sentence.Insert(sentence.IndexOf(occurence), substring);
                // Console.WriteLine(result);

                // //9. swap even and odd numbers
                // string str = Console.ReadLine();
                // string nString = ""+str[0];
                // char ch;
                // char next;
                // for(int i=0; i<str.Length; i=i+2)
                // {
                //     next = str[i];
                //     if(i==str.Length-1 && str.Length%2==0)
                //     {
                //         nString += next;
                //         break;
                //     }
                //     ch = str[i+1];
                //     nString = nString + ch +next;
                // }
                // Console.WriteLine(nString);



                // //10. reverse the string in the upper case
                // string str = Console.ReadLine();
                // char ch;
                // string upper = "";
                // string reverse = "";
                // for(int i=0; i<str.Length; i++)
                // {
                //     ch = str[i];
                //     if(ch>='a' && str[i]<='z')
                //     {
                //         ch = (char)(str[i]-32);
                //     }
                //     upper = upper + ch;
                // }
                // foreach( char i in upper )
                // {
                //     reverse = i+reverse;
                // }
                // Console.WriteLine(reverse);


                
            }
        }
            