// URL of the problem
// https://www.hackerrank.com/challenges/weighted-uniform-string/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        static void weightedUniformStrings(string s, int[] queries)
        {
            // Create a bool for every possible weight
            bool[] weights = new bool[(int)Math.Pow(10, 7)];

            // Variable holding the previous character we checked
            char previousChar = '0';
            // Variable holding the current weight
            int weight = 0;

            // Loop through each character of the string
            foreach (char c in s)
            {
                // Check if the current character is the same as the previous character
                if (c == previousChar)
                    // Add to the weight value
                    weight += (c - 'a' + 1);
                else
                    // Set a new weight value
                    weight = c - 'a' + 1;

                // Set the number in our bool array to true
                weights[weight] = true;
            }

            // Loop through the numbers in the queries array
            foreach (int num in queries)
            {
                // Check if the number is true in the array of booleans
                if (weights[num])
                    // Write "Yes"
                    Console.WriteLine("Yes");
                else // The number is false
                    Console.WriteLine("No");
            }
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            int[] queries = new int[queriesCount];

            for (int queriesItr = 0; queriesItr < queriesCount; queriesItr++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[queriesItr] = queriesItem;
            }

            weightedUniformStrings(s, queries);
        }
    }
}
