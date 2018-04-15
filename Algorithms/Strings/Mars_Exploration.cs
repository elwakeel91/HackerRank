// URL of the problem
// https://www.hackerrank.com/challenges/mars-exploration/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        /// <summary>
        /// Returns the number of corrupted letters
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static int MarsExploration(string s)
        {
            // Variable holding the number of letters
            int numLetters = 0;

            // Loop through every 3 letters in the message
            for (int i = 0; i < s.Length / 3; i++)
            {
                // Check the first letter
                if (s[i * 3] != 'S')
                    numLetters++;
                // Check the second letter
                if (s[i * 3 + 1] != 'O')
                    numLetters++;
                // Check the third letter
                if (s[i * 3 + 2] != 'S')
                    numLetters++;
            }

            // Return the total number of corrupted letters
            return numLetters;
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            int result = MarsExploration(s);
            Console.WriteLine(result);
        }

    }
}
