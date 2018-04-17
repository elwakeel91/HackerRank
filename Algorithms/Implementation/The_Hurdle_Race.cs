// URL of the problem
// https://www.hackerrank.com/challenges/the-hurdle-race/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        /// <summary>
        /// Returns the number of magic potion doses the player must take to complete the race
        /// </summary>
        /// <param name="k"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        static int hurdleRace(int k, int[] height)
        {
            // Variable holding the largest value of height
            int maxHeight = height.Max();

            // Check if our player can jump over the maxHeight value
            if (k >= maxHeight)
                // He doesn't need the magic potion
                return 0;
            else // He needs to take a certain number of doses
                return maxHeight - k;
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] height_temp = Console.ReadLine().Split(' ');
            int[] height = Array.ConvertAll(height_temp, Int32.Parse);
            int result = hurdleRace(k, height);
            Console.WriteLine(result);
        }
    }
}
