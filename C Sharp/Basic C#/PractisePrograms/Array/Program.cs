using System;
namespace Ar1;
class Program
{
    public static void Main(string[] args)
    {
        // //types of array creation
        // int[] array1 = new int[5];
        // // int[] array2 = new int[5]{1,2,3,4,5};
        // // int[]  array3 = new int[]{6,7,8,9,0};

        // //array1 intialization
        // for(int i = 0; i < array1.Length ; i++)
        // {
        //     array1[i] = int.Parse(Console.ReadLine());
        // }
        // for(int i = 0; i < array1.Length ; i++)
        // {
        //     Console.WriteLine(array1[i]);
        // }

        // int i = 0;
        // int[] a = new int[100];
        // int n = int.Parse(Console.ReadLine());
        // for(i=0;i<n;i++)
        // {
        //     a[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // for(i=n-1;i>=0;i--)
        // {
        //     Console.Write("{0}", a[i] + " ");
        // }


        // // Practise Ass - Ques 2: get size and elements and display the sum of elements
        // int n = int.Parse(Console.ReadLine());
        // int sum = 0;
        // int[] array = new int[n];
        // for(int i = 0; i < n ; i++)
        // {
        //     array[i] = int.Parse(Console.ReadLine());
        // }
        // for(int i = 0; i < n ; i++)
        // {
        //     sum += array[i];
        // }
        // Console.WriteLine($"{sum}");


        // //Practice Assignment-Ques 3: Max and Min element in the array
        // int n = int.Parse(Console.ReadLine());
        // int[] arr = new int[n];
        // for(int i=0; i<n; i++)
        // {
        //     arr[i] = int.Parse(Console.ReadLine());
        // }
        // int max = arr[0];
        // int temp = arr[0];
        // int min = 0;
        // for(int i=1; i<n; i++)
        // {
        //     if(arr[i]>temp)
        //     {
        //         max = arr[i];
        //     }
        //     else
        //     {
        //         min = temp;
        //     }
        // }
        // Console.WriteLine("Max: "+ max);
        // for(int i=1; i<n; i++)
        // {
        //     if(arr[i]<temp)
        //     {
        //         min = arr[i];
        //     }
        // }
        // Console.WriteLine("Min: "+ min);


        // //Practice Assignment-Ques 4: Odd and even numbers in an array
        // int n = int.Parse(Console.ReadLine());
        // int[] array1 = new int[n];
        // int[] odd = new int[n];
        // int[] even = new int[n];
        // int j=0, k=0;
        // for(int i=0; i<n; i++)
        // {
        //     array1[i] = int.Parse(Console.ReadLine());
        // }
        // for(int i=0; i<n; i++)
        // {
        //     if(array1[i] % 2 ==0)
        //     {
        //         even[j] = array1[i];
        //         j++;
        //     }
        //     else
        //     {
        //         odd[k] = array1[i];
        //         k++;
        //     }
        // }

        // Console.Write("Odd Numbers : ");
        // for(int i=0; i<k ; i++)
        // {
        //     Console.Write(odd[i]+" ");
        // }
        // Console.WriteLine();
        // Console.Write("Even Numbers : ");
        // for(int i=0; i<j ; i++)
        // {
        //     Console.Write(even[i]+" ");
        // }


        // //sorting the array
        // int n, i, j, tmp;
        // n = Convert.ToInt32(Console.ReadLine());
        // int[] arr1 = new int[n];
        // for (i = 0; i < n; i++)
        // {
        //     arr1[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // for (i = 0; i < n; i++)
        // {
        //     for (j = i + 1; j < n; j++)
        //     {
        //         if (arr1[j] < arr1[i])
        //         {
        //             tmp = arr1[i];
        //             arr1[i] = arr1[j];
        //             arr1[j] = tmp;
        //         }
        //     }
        // }
        // for (i = 0; i < n; i++)
        // {
        //     Console.Write("{0} ", arr1[i]);
        // }


        // 3*3 matrix
        // int[,] arr1 = new int[3, 3];
        // for (int i = 0; i < 3; i++)
        // {
        //     for (int j = 0; j < 3; j++)
        //     {
        //         arr1[i, j] = int.Parse(Console.ReadLine());
        //     }
        // }
        // for (int i = 0; i < 3; i++)
        // {
        //     Console.Write("\n");
        //     for (int j = 0; j < 3; j++)
        //     {
        //         Console.Write("{0} ", arr1[i, j]);
        //     }
        // }

        // // add 2 matrix
        // int i, j;
        // int n = int.Parse(Console.ReadLine());
        // int[,] arr1 = new int[n, n];
        // int[,] arr2 = new int[n, n];
        // int[,] result = new int[n, n];
        
        // for (i = 0; i < n; i++)
        // {
        //     for (j = 0; j < n; j++)
        //     {
        //         arr1[i, j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }
        // for (i = 0; i < n; i++)
        // {
        //     for (j = 0; j < n; j++)
        //     {
        //         arr2[i, j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }
        // for (i = 0; i < n; i++)
        // {
        //     for (j = 0; j < n; j++)
        //         result[i, j] = arr1[i, j] + arr2[i, j]; 
        // }
        // for (i = 0; i < n; i++)
        // {
        //     Console.Write("\n");
        //     for (j = 0; j < n; j++)
        //     Console.Write("{0} ", result[i, j]);
        // }

        // //multiply 2 matrix
        // int i, j, sum;
        // int n = int.Parse(Console.ReadLine());
        // int[,] arr1 = new int[n, n];
        // int[,] arr2 = new int[n, n];
        // int[,] result = new int[n, n];
        
        // for (i = 0; i < n; i++)
        // {
        //     for (j = 0; j < n; j++)
        //     {
        //         arr1[i, j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }
        // for (i = 0; i < n; i++)
        // {
        //     for (j = 0; j < n; j++)
        //     {
        //         arr2[i, j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }
        // for (i = 0; i < n; i++) // Row of the first matrix
        //     {
        //         for (j = 0; j < n; j++) // Column of the second matrix
        //         {  
        //             sum = 0;
        //             for (int k = 0; k < n; k++)
        //                 sum = sum + arr1[i, k] * arr2[k, j];
        //             result[i, j] = sum;
        //         }
        //     }
        //  for (i = 0; i < n; i++)
        //     {
        //         Console.Write("\n");
        //         for (j = 0; j < n; j++)
        //         {
        //             Console.Write("{0} ", result[i, j]);
        //         }
        //     }


        // //9. transpose of a matrix
        // int c = int.Parse(Console.ReadLine());
        // int r = int.Parse(Console.ReadLine());
        // int[,] arr1 = new int[r, c];
        // int[,] arr2 = new int[c, r];
        // for (int i = 0; i < r; i++)
        // {
        //     for (int j = 0; j < c; j++)
        //     {
        //         arr1[i, j] = int.Parse(Console.ReadLine());
        //     }
        // }
        // for (int i = 0; i < c; i++)
        // {
        //     for (int j = 0; j < r; j++)
        //     {
        //         arr2[i,j] = arr1[j,i];
        //     }
        // }
        // for (int i = 0; i < c; i++)
        // {
        //     for (int j = 0; j < r; j++)
        //     {
        //         Console.Write(arr2[i,j]+" ");
        //     }
        //     Console.WriteLine();
        // }

        // //8. compares two last names
        // string str1 = Console.ReadLine();
        // string str2 = Console.ReadLine();
        // int index1 = str1.LastIndexOf(" ");
        // int index2 = str2.LastIndexOf(" ");
        // Console.WriteLine(index1);
        // Console.WriteLine(index2);
        // if(str1[index1+1]>str2[index2+1])
        // {
        //     Console.WriteLine(str2);
        //     Console.WriteLine(str1);
        // }
        // else
        // {
        //     Console.WriteLine(str1);
        //     Console.WriteLine(str2);
        // }

        //10. find the element in the array
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int flag = 0;
        int temp = 0;
        for(int i=0; i<n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for(int i=0; i<n; i++)
        {
            if(arr[i]==k)
            {
                temp = i;
                flag++;
            }
        }
        if(flag > 0)
        {
            Console.WriteLine(temp);
        }
        else
        {
            Console.WriteLine(-1);
        }



        

       

    }
}