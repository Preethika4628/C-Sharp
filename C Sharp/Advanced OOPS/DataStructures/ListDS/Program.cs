using System;
namespace ListDS;
class Program 
{
    public static void Main(string[] args)
    {
        CustomList<int> numberList = new CustomList<int>();  //creating list
        CustomList<int> numbers = new CustomList<int>();
        //add
        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(30);
        numberList.Add(40);
        numberList.Add(50);
        numbers.Add(60);
        numbers.Add(70);

        //add range
        numberList.AddRange(numbers);

        //display numbers inside list
        Console.Write("NumberList: ");
        for(int i=0; i<numberList.Count; i++)
        {
            Console.Write(numberList[i] +" ");
        }
        Console.WriteLine();

        //contains
        bool result = numberList.Contains(40);
        Console.Write("Contains: " + result);

        //index of
        int position = numberList.IndexOf(20);
        Console.Write("IndexOf: " + position);

        // insert
        numberList.Insert(2, 90);
        Console.Write("NumberList after inserting a value: ");
        for(int i=0; i<numberList.Count; i++)
        {
            Console.Write(numberList[i] + " ");
        }
        Console.WriteLine();

        // removing
        numberList.RemoveAt(4);
        Console.Write("NumberList after removing a value: ");
        for(int i=0; i<numberList.Count; i++)
        {
            Console.Write(numberList[i] + " ");
        }
        Console.WriteLine();

        // Remove
        bool temp = numberList.Remove(90);
        Console.Write("Remove: "+ temp);
        Console.WriteLine();

        // foreach 
        foreach(int value in numberList)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        // Reverse
        numberList.Reverse();
        Console.Write("NumberList after reversing range of values: ");
        for(int i=0; i<numberList.Count; i++)
        {
            Console.Write(numberList[i] + " ");
        }
        Console.WriteLine();

        // InsertRange
        numberList.InsertRange(3, numbers);
        // numberList.Reverse();
        Console.Write("NumberList after inserting range of values: ");
        for(int i=0; i<numberList.Count; i++)
        {
            Console.Write(numberList[i] + " ");
        }
        Console.WriteLine();

        numberList.BubbleSort();
        Console.Write("NumberList after sorting values: ");
        for(int i=0; i<numberList.Count; i++)
        {
            Console.Write(numberList[i] + " ");
        }
        Console.WriteLine();
    }
}