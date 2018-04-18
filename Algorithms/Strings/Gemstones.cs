// URL of the problem
// https://www.hackerrank.com/challenges/gem-stones/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        /// <summary>
        /// Return the number of Gemstones found in the rock collection
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int Gemstones(string[] arr)
        {
            // Store the number of Gemstones found
            int numGemstones = 0;
            // Store a true or false if the mineral is a Gemstone
            bool isGemstone;

            // Array of minerals found
            string minerals = string.Empty;

            // Loop through each mineral in the first rock
            foreach (char mineral in arr[0])
            {
                // See if we have already checked this mineral
                if (minerals.Contains(mineral))
                    // Do nothing
                    continue;
                else // Add it to our collection of minerals
                    minerals += mineral;

                // Set isGemstone to true until proven false
                isGemstone = true;

                // Loop through the other rocks in the collection
                for (int i = 1; i < arr.Length; i++)
                {
                    // If the rock does NOT contain the mineral
                    if (!arr[i].Contains(mineral))
                    {
                        // It isn't a gemstone
                        isGemstone = false;
                        // No need to check the remaining rocks
                        break;
                    }
                        
                }

                // If the isGemstone remained true
                if (isGemstone)
                    // Increase out Gemstones counter
                    numGemstones++;
            }
            
            return numGemstones;
        }

        static void Main(String[] args)
        {
            // Store the number of rocks
            int n = Convert.ToInt32(Console.ReadLine());

            // Create an array of string holding the minerals found in each rock
            string[] arr = new string[n];

            // Loop through the rocks and store the minerals found
            for (int arr_i = 0; arr_i < n; arr_i++)
            {
                arr[arr_i] = Console.ReadLine();
            }

            // Calculate the number of different 'Gemstones' found in the rock collection
            int result = Gemstones(arr);
            Console.WriteLine(result);
        }
    }
}
