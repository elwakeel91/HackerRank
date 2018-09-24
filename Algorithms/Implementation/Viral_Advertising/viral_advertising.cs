// URL of the problem
// https://www.hackerrank.com/challenges/strange-advertising/problem

using System;
using System.IO;

public class Solution
{

    static void Main(String[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int result = ViralAdvertising(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }

    public static int ViralAdvertising(int n)
    {
        // Number of shares
        int shares = 5;

        // Running total of likes
        int total = 0;

        for (int i = 0; i < n; i++)
        {
            // Get the number of likes that day
            int likes = shares / 2;

            // Add it to our total
            total += likes;

            // Calculate the number of shares that day
            shares = likes * 3;
        }

        return total;
    }
}
