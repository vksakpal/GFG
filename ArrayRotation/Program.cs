using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("====================");
            Console.WriteLine("Method 1");
            Console.WriteLine("====================");
            LeftRotate(arr, 2, 7);
            PrintArray(arr);

            Console.WriteLine("====================");
            Console.WriteLine("Method 2");
            Console.WriteLine("====================");
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
            Method2(arr1, 2);
            PrintArray(arr1);
            Console.ReadLine();
                
        }

        static void PrintArray(int[] arr)
        {
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }

        static void LeftRotate(int[] arr, int d, int n)
        {
            for(int i =0;i< d;i++)
            {
                LeftRotateByOne(arr, n);
            }
        }

        static void LeftRotateByOne(int[] arr, int n)
        {
            int i, temp = arr[0];

            for(i = 0; i < n-1;i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[i] = temp;
        }

        static void Method2(int[] arr, int d)
        {
            int[] temp = new int[d];

            for(int i =0;i < d;i++)
            {
                temp[i] = arr[i];                
            }

            for(int i = 0; i< arr.Length - d;i++)
            {
                arr[i] = arr[d + i];
            }

            for (int i = arr.Length - d, j = 0; i < arr.Length; i++, j++)
            {
                arr[i] = temp[j];
            }
        }
    }
}
