// URL of the problem
// https://www.hackerrank.com/challenges/caesar-cipher-1/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        /// <summary>
        /// Returns a Caesar Cipher encrypted string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        static string CaesarCipher(string s, int k)
        {
            // Reduce the value of k
            while (k > 26)
            {
                k -= 26;
            }

            // Loop through the letters of the original word
            for (int i = 0; i < s.Length; i++)
            {
                // Check if it matches a Upper case ASCII letter
                if ((s[i] < 91 && s[i] > 64))
                {
                    char newChar = s[i] + k > 90 ? (char)(s[i] + k - 26) : (char)(s[i] + k);
                    // Switch the characters
                    s = s.Remove(i, 1);
                    s = s.Insert(i, newChar.ToString());
                }
                // Check if it matches a Lower case ASCII letter
                else if (s[i] < 123 && s[i] > 96)
                {

                    // Work out the new character
                    char newChar = s[i] + k > 122 ? (char)(s[i] + k - 26) : (char)(s[i] + k);
                    // Switch the characters
                    s = s.Remove(i, 1);
                    s = s.Insert(i, newChar.ToString());
                }
            }

            return s;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            string result = CaesarCipher(s, k);
            Console.WriteLine(result);
        }

    }
}
