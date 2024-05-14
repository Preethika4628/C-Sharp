using System;
namespace SelectionSort;
class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[6] { 4, 8, 6, 3, 5, 7 };
        int i, j;
        for (i = 0; i < array.Length - 1; i++)
        {
            int min = i;
            for (j = i + 1; j < array.Length; j++)
            {
                if (array[min] > array[j])
                {
                    min = j;
                }
            }
            int temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }
        Console.Write("Selection sorted array: ");
        foreach (int val in array)
        {
            Console.Write(val + " ");
        }
        Console.WriteLine();
    }
}