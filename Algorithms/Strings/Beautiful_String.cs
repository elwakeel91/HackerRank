// URL of the problem
// https://www.hackerrank.com/challenges/beautiful-binary-string/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
	/// <summary>
        /// Calculates the minimum number of fixes required to make a string beautiful
        /// </summary>
        /// <param name="b"> Original string </param>
        /// <returns> The minumum number of fixes required </returns>
        static int beautifulBinaryString(string b)
        {
            // Create a new string without all occurences of '010'
            string beautifulString = b.Replace("010", "");
            // Calculate the difference in the length of the original string to the new string
            // Divide by 3 as we removed 3 characters each time
            int numberOfFixes = (b.Length - beautifulString.Length) / 3;

            return numberOfFixes;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string b = Console.ReadLine();
            int result = beautifulBinaryString(b);
            Console.WriteLine(result);
        }
    }
}
