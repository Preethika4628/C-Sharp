using System;
namespace BubbleSort;
class Program 
{
    public static void Main(string[] args)
    {
        int[] array= new int[6]{68, 88, 45, 25, 75, 13};
        int i, j;
        for(i=0; i<=array.Length-2; i++)
        {
            for(j=0; j<=array.Length-2; j++)
            {
                if(array[j] > array[j+1])
                {
                    int temp = array[j+1];
                    array[j+1] = array[j];
                    array[j] = temp;
                }
            }
        }
        Console.Write("Bubble sorted array: ");
        foreach(int val in array)
        {
            Console.Write(val + " ");
        }
        Console.WriteLine();
    }
}