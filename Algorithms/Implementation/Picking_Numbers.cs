// URL of the problem
// https://www.hackerrank.com/challenges/picking-numbers/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution : PrimeNumbers
    {
        /// <summary>
        /// Returns the maximum number of integers you can select
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int PickingNumbers(int[] a, int n)
        {
            // Create a new array to store the frequency of the number in array a
            int[] frequency = new int[100];

            // Loop through the array of numbers
            for (int i = 0; i < n; i++)
                // Set the value of our frequence array
                frequency[a[i]]++;

            int maxNumber = 0;

            // Loop through the frequency array and find which pair of numbers occurs the most
            for (int i = 1; i < 100; i++)
            {
                int temp = (frequency[i - 1] + frequency[i]);
                maxNumber = temp > maxNumber ? temp : maxNumber;
            }

            // Return the maximum number found in array b
            return maxNumber;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int result = PickingNumbers(a, n);
            Console.WriteLine(result);
        }
    }
}
