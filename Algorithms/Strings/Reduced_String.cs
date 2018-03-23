// URL of the problem
// https://www.hackerrank.com/challenges/reduced-string/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    // Handles reducing the string
    static string super_reduced_string(string s)
    {
        // Loop through the characters of the string
        for (int i = 0, j = 1; j < s.Length;)
        {
            // Check if the adjacent characters are the same
            if (s[i] == s[j])
            {
                // Remove the two characters
                s = s.Remove(i, 2);

                // Check if we are past the first character
                if (i > 0)
                {
                    // Move back a space
                    i--;
                    j--;
                }
            }
            // Characters are not the same
            else
            {
                // Move forward a space
                i++;
                j++;
            }

            // Check if the string is empty
            if (string.IsNullOrEmpty(s))
                return "Empty String";
        }
        // Return the string
        return s;
    }

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        string result = super_reduced_string(s);
        Console.WriteLine(result);
    }
}
