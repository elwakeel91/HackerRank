// URL of the problem
// https://www.hackerrank.com/challenges/camelcase/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int camelcase(string s)
    {
        // Variable holding the number of words in the string
        int numWords = 1;

        // Loop through the characters in the word
        for (int i = 1; i < s.Length; i++)
        {
            // Check if the letter is between the ASCII number 65 and 90
            if (s[i] >= 65 && s[i] <= 90)
                // Add one to our number of words
                numWords++;
        }
        // Return the number of words
        return numWords;
    }

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        int result = camelcase(s);
        Console.WriteLine(result);
    }
}
