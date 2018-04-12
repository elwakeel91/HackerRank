// URL of the problem
// https://www.hackerrank.com/challenges/picking-numbers/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        /// <summary>
        /// Returns the maximum number of integers you can select
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int PickingNumbers(int[] a, int n)
        {
            // Create a new array of length double array 'a'
            // to store the number of integers we can select at each digit found in array a
            int[] b = new int[2 * n];
            // Variable to hold the index of array b
            int indexB;

            // Loop through the array of numbers up to (n - 1) as the substring is at least 2 numbers
            for (int i = 0; i < (n - 1); i++)
            {
                // Set the value for the index of array b
                indexB = 2 * i;

                // Create a second loop to compare the numbers in the array
                for (int j = i; j < n; j++)
                {
                    // Check if the two numbers being compared are equal or is bigger by 1
                    if (a[i] == a[j] || a[i] + 1 == a[j])
                        // Increase the number stored in array b
                        b[indexB]++;
                    // Check if the two numbers being compared are equal or is smaller by 1
                    if (a[i] == a[j] || a[i] - 1 == a[j])
                        // Increase the number stored in array b
                        b[indexB + 1]++;
                }
            }

            // Return the maximum number found in array b
            return b.Max();  
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
