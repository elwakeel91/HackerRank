// URL of the problem
// https://www.hackerrank.com/challenges/utopian-tree/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        /// <summary>
        /// Calculates the height of the Utopian Tree after 'n' cycles
        /// </summary>
        /// <param name="n"> number of cycles </param>
        /// <returns> Heigh of the tree </returns>
        public static int utopianTree(int n)
        {
            // Find out how many years have passed
            int years = n / 2;
            // If it's an odd number of cycles we need to add a year to include another spring cycle 
            // and subtract the summer cycle later.
            if (n % 2 != 0) years++;
            // Use sum of series 2 ^ n + 2 ^ n - 1 + 2 ^ (n - 2)... = 2 ^ (k + 1) - 1
            int height = (int)Math.Pow(2, years + 1) - 1;
            // Subtract 1 (i.e. summer cycle) from the height for an odd number of cycles
            if (n % 2 != 0) height -= 1;

            return height;
        }

        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int result = utopianTree(n);
                Console.WriteLine(result);
            }
        }
    }
}
