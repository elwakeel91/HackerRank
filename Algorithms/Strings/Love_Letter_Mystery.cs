// URL of the problem
// https://www.hackerrank.com/challenges/the-love-letter-mystery/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        /// <summary>
        /// Calculates the number of operations needed to make the 'love letter' a palindrome letter
        /// </summary>
        /// <param name="s"> The love letter </param>
        /// <returns> The number of operations needed </returns>
        static int theLoveLetterMystery(string s)
        {
	    // Variable holding the number of operations required
            int numberOfOperations = 0;

            // Create a reverse string of the love letter
            string reverseString = new string(s.ToCharArray().Reverse().ToArray());

            // Loop through the characters in the first half of the love letter
            for (int i = 0; i < s.Length / 2; i++)
            {
                // Find the absolute difference between the letters to give the number of operations needed
                numberOfOperations += Math.Abs((int)s[i] - (int)reverseString[i]);
            }

            return numberOfOperations;
        }

        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                int result = theLoveLetterMystery(s);
                Console.WriteLine(result);
            }
        }
    }
}
