using System;
namespace BinarySearch;
class Program 
{
    //int - binary search
    public static void Main(string[] args)
    {
        int[] values = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
        Array.Sort(values);
        int position = BinarySearch(values, 5);
        if(position>-1)
        {
            Console.WriteLine("Elements found at " + position);
        }
        else
        {
            Console.WriteLine("Elements not found");
        }
    }
    static int BinarySearch(int[] values, int searchElement)
    {
        int left=0;
        int right = values.Length-1;
        while (left<=right)
        {
            int middle = left+((right-left)/2);
            if(values[middle]==searchElement)
            {
                return middle;
            }
            else if(values[middle]<searchElement)
            {
                //if the search element is greater than middle
                //search in right half by changing value of left
                left = middle+1;
            }
            else
            {
                //if the search element is lesser than middle
                // search in right half by changing value of left
                right=middle-1;
            }
        }
        //elements not present in array
        return -1;
    }

    
    // //char - binary search
    // public static void Main(string[] args)
    // {
    //     char[] values = {'a', 'b', 'c', 'f', 't', 'o', 'q', 'g', 'd'};
    //     Array.Sort(values);
    //     int position = BinarySearch(values, 't');
    //     if(position>-1)
    //     {
    //         Console.WriteLine("Elements found at " + position);
    //     }
    //     else
    //     {
    //         Console.WriteLine("Elements not found");
    //     }
    // }
    // static int BinarySearch(char[] values, char searchElement)
    // {
    //     int left=0;
    //     int right = values.Length-1;
    //     while (left<=right)
    //     {
    //         int middle = left+((right-left)/2);
    //         if(values[middle]==searchElement)
    //         {
    //             return middle;
    //         }
    //         else if(values[middle]<searchElement)
    //         {
    //             //if the search element is greater than middle
    //             //search in right half by changing value of left
    //             left = middle+1;
                
    //         }
    //         else
    //         {
    //             //if the search element is lesser than middle
    //             // search in right half by changing value of left
    //             right=middle-1;
    //         }
    //     }
    //     //elements not present in array
    //     return -1;
    // }

    
    // //string - binary search
    // public static void Main(string[] args)
    // {
    //     string[] values = { "SF1001", "SF1002", "SF1003", "SF1004", "SF1005", "SF1006", "SF1007", "SF1008", "SF1009", "SF1010", "SF1011", "SF1012", "SF1013", "SF10014", "SF1015", "SF1016", "SF1017", "SF1018", "SF1019", "SF1020" };
    //     Array.Sort(values);
    //     int position = BinarySearch(values, "SF1006");
    //     if(position>-1)
    //     {
    //         Console.WriteLine("Elements found at " + position);
    //     }
    //     else
    //     {
    //         Console.WriteLine("Elements not found");
    //     }
    // }
    // static int BinarySearch(string[] values, string searchElement)
    // {
    //     int left=0;
    //     int right = values.Length-1;
    //     while (left<=right)
    //     {
    //         int middle = left+((right-left)/2);
    //         if(values[middle]==searchElement)
    //         {
    //             return middle;
    //         }
    //         else if (values[middle] < searchElement)
    //         {
    //             //if the search element is greater than middle
    //             //search in right half by changing value of left
    //             left = middle+1;
                
    //         }
    //         else
    //         {
    //             //if the search element is lesser than middle
    //             // search in right half by changing value of left
    //             right=middle-1;
    //         }
    //     }
    //     //elements not present in array
    //     return -1;
    // }
}