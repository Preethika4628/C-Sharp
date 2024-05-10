using System;
namespace BinarySearch;
class Program 
{
    public static void Main(string[] args)
    {
        int[] values = {12, 13, 21, 10, 8, 11, 9};
        Array.Sort(values);
        int position = BinarySearch(values, 21);
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
}