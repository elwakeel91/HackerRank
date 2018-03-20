// URL of the problem
// https://www.hackerrank.com/challenges/apple-and-orange/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    // Handles counting and printing the score for apples and oranges
    static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        // Variable holding Apples Score
        int applesScore = 0;
        // Variable holding Oranges Score
        int orangesScore = 0;

        // Loop through the apples
        for (int i = 0; i < apples.Length; i++)
        {
            // Get the apple position in world space
            int applesPosition = a + apples[i];
            // Check if it landed on the house, then add one to the score.
            applesScore = (applesPosition >= s && applesPosition <= t) ? applesScore + 1 : applesScore;
        }

        // Loop through the oranges
        for (int i = 0; i < oranges.Length; i++)
        {
            // Get the orange position in world space
            int orangesPosition = b + oranges[i];
            // Check if it landed on the house, then add one to the score.
            orangesScore = (orangesPosition >= s && orangesPosition <= t) ? orangesScore + 1 : orangesScore;
        }
        // Print the score
        Console.WriteLine($"{applesScore}\n{orangesScore}");
    }

    static void Main(String[] args)
    {
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]);
        int t = Convert.ToInt32(tokens_s[1]);
        string[] tokens_a = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(tokens_a[0]);
        int b = Convert.ToInt32(tokens_a[1]);
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] apple_temp = Console.ReadLine().Split(' ');
        int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
        string[] orange_temp = Console.ReadLine().Split(' ');
        int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);
        CountApplesAndOranges(s, t, a, b, apple, orange);
    }
}
