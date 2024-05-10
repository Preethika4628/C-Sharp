using System;
namespace LinearSearch;
class Program 
{
    //int - linear search
    public static void Main(string[] args)
    {
        int[] values = {1, 2, 3, 6, 8, 4, 9, 12};
        int position = LinearSearch(values, 19);
        if(position>-1)
        {
            Console.WriteLine("Element is present in the position " + position);
        }
        else
        {
            Console.WriteLine("Element does not exist");
        }
    }
    static int LinearSearch(int[] values, int searchElement)
    {
        int position=-1;
        for(var i=0; i<values.Length; i++)
        {
            if(values[i]==searchElement)
            {
                position=i;
                break;
            }
        }
        return position;
    }

    // //char - linear search
    // public static void Main(string[] args)
    // {
    //     char[] values = {'a', 'b', 'c', 'f', 't', 'o', 'q', 'g', 'd'};
    //     int position = LinearSearch(values, 'd');
    //     if(position>-1)
    //     {
    //         Console.WriteLine("Element is present in the position " + position);
    //     }
    //     else
    //     {
    //         Console.WriteLine("Element does not exist");
    //     }
    // }
    // static int LinearSearch(char[] values, char searchElement)
    // {
    //     int position=-1;
    //     for(var i=0; i<values.Length; i++)
    //     {
    //         if(values[i]==searchElement)
    //         {
    //             position=i;
    //             break;
    //         }
    //     }
    //     return position;
    // }

    // //string - linear search
    // public static void Main(string[] args)
    // {
    //     string[] values = { "SF1001", "SF1002", "SF1003", "SF1004", "SF1005", "SF1006", "SF1007", "SF1008", "SF1009", "SF1010", "SF1011", "SF1012", "SF1013", "SF10014", "SF1015", "SF1016", "SF1017", "SF1018", "SF1019", "SF1020" };
    //     int position = LinearSearch(values, "SF1004");
    //     if(position>-1)
    //     {
    //         Console.WriteLine("Element is present in the position " + position);
    //     }
    //     else
    //     {
    //         Console.WriteLine("Element does not exist");
    //     }
    // }
    // static int LinearSearch(string[] values, string searchElement)
    // {
    //     int position=-1;
    //     for(var i=0; i<values.Length; i++)
    //     {
    //         if(values[i]==searchElement)
    //         {
    //             position=i;
    //             break;
    //         }
    //     }
    //     return position;
    // }
}