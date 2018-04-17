// URL of the problem
// https://www.hackerrank.com/challenges/designer-pdf-viewer/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        /// <summary>
        /// Returns the Area of the highlighted word
        /// </summary>
        /// <param name="k"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        static int designerPdfViewer(int[] h, string word)
        {
            int maxHeight = 0;                                                  // The maximum letter height
            int charIndex = 0;                                                  // The index of the character in the alphabet

            // Loop through the characters of the given word
            for (int i = 0; i < word.Length; i++)
            {
                // Store the character index in the alphabet (i.e. a = 0, z = 25)
                charIndex = word[i] - 'a';
                // Get the letter height
                int temp = h[charIndex];
                // Update our maximum height if we found a new one
                maxHeight = temp > maxHeight ? temp : maxHeight;
            }

            // Returns the Area of the given word
            return (maxHeight * word.Length);
        }

        static void Main(String[] args)
        {
            string[] h_temp = Console.ReadLine().Split(' ');
            int[] h = Array.ConvertAll(h_temp, Int32.Parse);
            string word = Console.ReadLine();
            int result = designerPdfViewer(h, word);
            Console.WriteLine(result);
        }
    }
}
