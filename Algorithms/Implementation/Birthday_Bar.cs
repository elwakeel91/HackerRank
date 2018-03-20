// URL of the problem
// https://www.hackerrank.com/challenges/the-birthday-bar/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    // Gives the total number of combinations
    static int solve(int n, int[] s, int d, int m)
    {
        // Variable holding our running sum value
        int sum = 0;
        // Variable holding the number of combinations
        int counter = 0;

        // Loop through the chocolate pieces        
        for (int i = 0; i < n; i++)
        {
            // Add the current square to our running sum
            sum += s[i];

            // Check if we have reached the correct number of squares
            if (i >= (m - 1))
            {
                // if our running sum is equal to the desired sum then add one to the counter, else keep our counter the same
                counter = (sum == d) ? (counter + 1) : counter;
                // Subtract the oldest number from our running sum
                sum -= s[i - (m - 1)];
            }
        }

        return counter;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp, Int32.Parse);
        string[] tokens_d = Console.ReadLine().Split(' ');
        int d = Convert.ToInt32(tokens_d[0]);
        int m = Convert.ToInt32(tokens_d[1]);
        int result = solve(n, s, d, m);
        Console.WriteLine(result);
    }
}
