// URL of the problem
// https://www.hackerrank.com/challenges/alternating-characters/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        /// <summary>
        /// Returns the minimum number of deletions to make the string alternating characters
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static int alternatingCharacters(string s)
        {
            // Variable holding the number of deletions required
            int numDeletions = 0;
            // Variable to check what the next character must be
            char nextCharacter = s[0] == 'A' ? 'B' : 'A';

            // Loop through the string
            for (int i = 1; i < s.Length; i++)
            {
                // Check if we got the required next character
                if (s[i] == nextCharacter)
                    // Switch the next character variable
                    nextCharacter = (nextCharacter == 'A') ? 'B' : 'A';
                else // We didn't get the required character and we must delete
                    numDeletions++;
            }

            return numDeletions;
        }

        static void Main(String[] args)
        {
            // Store the number of test cases from the user input
            int q = Convert.ToInt32(Console.ReadLine());

            // Loop through the test cases
            for (int a0 = 0; a0 < q; a0++)
            {
                // Store the string from the user input
                string s = Console.ReadLine();
                // Calculate the minimum number of deletions necessary to create a string of alternating characters
                int result = alternatingCharacters(s);
                // Print the result on the screen
                Console.WriteLine(result);
            }
        }
    }
}
