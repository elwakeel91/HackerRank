// URL of the problem
// https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        static string HackerrankInString(string s)
        {
            // Set the target word
            string target = "hackerrank";
            // Variable holding the index of the target letter
            int index = 0;

            // Loop through each character in the given string
            foreach (char c in s)
            {
                // Check if the character matches the target character
                if (c == target[index])
                {
                    // Increase the target index
                    index++;
                    // Check if we have matched all the target letters
                    if (index > 9)
                        return "YES";
                }
            }

            // The string has NOT pass the parameters
            return "NO";
        }

        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                string result = HackerrankInString(s);
                Console.WriteLine(result);
            }
        }
    }
}
