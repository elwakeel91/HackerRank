// URL of the problem
// https://www.hackerrank.com/challenges/two-characters/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        /// <summary>
        /// Returns true if the string is made of alternating characters
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static bool isAlternating(string s)
        {
            // if there are only 2 characters it must be alternating
            if (s.Length < 3)
                return true;

            // Loop through the letters in our string starting at index [2]
            for (int i = 2; i < s.Length; i++)
            {
                // if the index is even AND the character DOESN'T matches the first letter
                if (i % 2 == 0 && s[i] != s[0])
                    return false;
                // if the index is odd AND the character DOESN'T matches the second letter
                if (i % 2 != 0 && s[i] != s[1])
                    return false;
            }

            // The string passed all our checks therefore it must be alternating characters
            return true;
        }

        /// <summary>
        /// Returns the maximum length of alternating characters only substrings
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static int TwoCharaters(string s)
        {
            char charOne;
            char charTwo;
            int maxLength = 0;

            // Create a new string of letters initialised with the first letter of the original string 's'
            string letters = s[0].ToString();

            // Loop through the original string
            for (int i = 1; i < s.Length; i++)
            {
                // Check if we have added this letter in the original string to our array of letters
                if (!letters.Contains(s[i]))
                    // Increase the index and add the letter
                    letters = String.Concat(letters, s[i]);
            }

            // Loop through the unique letters in the original string
            for (int i = 0; i < letters.Length - 1; i++)
            {
                // Set the first character
                charOne = letters[i];
        
                // Loop through the remaining unique letters
                for (int j = i + 1; j < letters.Length; j++)
                {
                    // Set the second character
                    charTwo = letters[j];

                    // Create a string of the remaining letters
                    string remainingLetters = String.Join("", letters.Split(new char[] { charOne, charTwo }));
                    // Remove the remaining letters from the original string
                    string cleanString = String.Join("", s.Split(remainingLetters.ToCharArray()));

                    // Check if the clean string is made of alternating characters only
                    if (isAlternating(cleanString))
                        // Check if we have a new maximum 
                        maxLength = maxLength < cleanString.Length ? cleanString.Length : maxLength;
                }
            }

            return maxLength;
        }

        static void Main(String[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int result = TwoCharaters(s);
            Console.WriteLine(result);
        }

    }
}
