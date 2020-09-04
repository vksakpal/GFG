using System;
using System.Xml.Schema;

namespace Array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of test cases:");
            int numOfTestCases = Convert.ToInt32( Console.ReadLine());
            int n = 0;
            int s = 0;
            for(int i = 0;i < numOfTestCases;i++)
            {
                Console.WriteLine("N {Size of array} S {Sum}");
                var sizeAndNumber = Console.ReadLine().Split();
                if(sizeAndNumber?.Length == 2)
                {
                    n = Convert.ToInt32( sizeAndNumber[0]);
                    s = Convert.ToInt32(sizeAndNumber[1]);
                }
                int[] arr = new int[n];
                for(int j = 0;j < n;j++)
                {
                    arr[j] = Convert.ToInt32(Console.ReadLine());
                }

                SubArrayWithGivenSum(arr, s);
            }

            Console.ReadLine();
            

        }

        private static void SubArrayWithGivenSum(int[] arr, int sumTobeChecked)
        {
            int startIndex = 0;
            int endIndex = 0;
           
            bool isContinue = true;
            for (int i = 0;i < arr.Length;i++)
            {
                
                int sum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    sum = sum + arr[j];
                    if(sum == sumTobeChecked)
                    {
                        startIndex = i + 1;
                        endIndex = j + 1;
                        isContinue = false;
                        break;

                    }

                    if(sum > sumTobeChecked || !isContinue)
                    {
                        break;
                    }
                }
                if (!isContinue)
                {
                    break;
                }

            }

            if(isContinue)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine($"{startIndex} {endIndex}");
            }
            
        }
    }
}
