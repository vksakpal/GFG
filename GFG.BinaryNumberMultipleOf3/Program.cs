using System;
using System.Collections.Generic;

namespace GFG.BinaryNumberMultipleOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> binaryStrings = new List<string>();
            Console.WriteLine("Please enter input count:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter binary strings:");
            for(int i = 0; i< num;i++)
            {
                binaryStrings.Add(Console.ReadLine());
            }

           
            Console.WriteLine("Please enter check number:");
            int checkNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entered binary strings");

            foreach(string binaryString in binaryStrings)
            {
                Console.WriteLine(binaryString);
            }


            List<int> response = CheckBinaryDataDivisibleByNumber(binaryStrings, checkNum);
            Console.WriteLine($"Are Binary strings Divisible by {checkNum}");

            foreach (int isDivisible in response)
            {
                Console.WriteLine(isDivisible);
            }

            Console.ReadLine();
        }

         static List<int>  CheckBinaryDataDivisibleByNumber(List<string> binaryStrings, int num)
        {
            List<int> response = new List<int>();

            foreach(string binaryString in binaryStrings)
            {
                int number = Convert.ToInt32(binaryString, 2);
                if(number % num == 0)
                {
                    response.Add(1);
                }
                else
                {
                    response.Add(0);
                }
            }

            return response;

        }
    }
}
