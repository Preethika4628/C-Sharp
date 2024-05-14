using System;
namespace LinearSearch;
class Program
{
    public static void Main(string[] args)
    {
        int[] values = {12,24,14,16,19,10,15};
        int position = LinearSearch(values, 19);
        if(position>-1)
        {
            Console.WriteLine("Element found in position " + position );
        }
        else
        {
            Console.WriteLine("Element not found");
        }

    }  
    static int LinearSearch(int[] values, int searchElement)
    {
        int position=-1;
        for(var i=0; i<values.Length ; i++)
        {
            if(values[i]==searchElement)
            {
                position=i;
                break;
            }
        }
        return position;
    }
}