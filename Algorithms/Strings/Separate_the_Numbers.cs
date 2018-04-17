// URL of the problem
// https://www.hackerrank.com/challenges/separate-the-numbers/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        /// <summary>
        /// Returns a string "YES x" or "NO" if the given string contains a sequence of beautiful numbers with 'x' equal to the first number
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string SeparateNumbers(string s)
        {
            // Check if the first digit is zero
            if (s[0] == '0')
                // Failed the problem condition
                return "NO";

            // Check if there are less than 2 digits
            if (s.Length < 2)
                // Failed the problem condition
                return "NO";

            // Variable holding the possible first number
            long firstNumber = 0;

            // Loop through the number of digits in the substrings
            for (int numDigits = 1; numDigits <= (s.Length / 2); numDigits++)
            {
                // Store the first number
                firstNumber = Convert.ToInt64(s.Substring(0, numDigits));
                // Create our own string of numbers that would pass all conditions
                string testString = string.Empty;

                // Populate the string until it's the same length as the given string
                for (int i = 0; testString.Length < s.Length; i++)
                {
                    testString = testString + (firstNumber + i);
                }

                // Check if the strings are the same
                if (testString.Equals(s))
                    return "YES " + firstNumber;
            }
            // The string failed all the problem conditions
            return "NO";
        }

        static void Main(String[] args)
        {
            // Get the number of test cases from the user and store into 'q'
            int q = Convert.ToInt32(Console.ReadLine());

            // Loop through the test cases
            for (int a0 = 0; a0 < q; a0++)
            {
                // Get the number string from the user and store into 's'
                string s = Console.ReadLine();
                // Call the seperate numbers function
                Console.WriteLine(SeparateNumbers(s));
            }
        }
    }
}
