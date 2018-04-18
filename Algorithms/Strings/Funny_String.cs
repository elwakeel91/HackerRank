// URL of the problem
// https://www.hackerrank.com/challenges/funny-string/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        /// <summary>
        /// Checks if the string is 'funny' and returns "Funny" or "Not Funny"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string FunnyString(string s)
        {
            // Create a character array storing the reverse string
            char[] r = s.Reverse().ToArray();
            
            // Loop through half the string
            for (int i = 0; i < s.Length / 2; i++)
            {
                // Check if the absolute differences DON'T match
                if (Math.Abs(s[i] - s[i + 1]) != Math.Abs(r[i] - r[i + 1]))
                    // Then it's not a funny string
                    return "Not Funny";
            }

            // The string passed all the parameters so it's a funny string
            return "Funny";
        }

        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                string result = FunnyString(s);
                Console.WriteLine(result);
            }
        }
    }
}
