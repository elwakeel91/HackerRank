// URL of the problem
// https://www.hackerrank.com/challenges/save-the-prisoner/problem

using System;
using System.IO;

public class Solution
{
	/// <summary>
    /// Calculates the last prisoner to get candy
    /// </summary>
    /// <param name="prisoners">The number of prisoners</param>
    /// <param name="sweets">The amount of sweets to hand out</param>
    /// <param name="startingSeat">The starting seat to hand out from</param>
    /// <returns></returns>
    public static int SaveThePrisoner(int prisoners, int sweets, int startingSeat)
    {
        return ((sweets - 1 + startingSeat - 1) % prisoners) + 1;
    }

    static void Main(String[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nms = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nms[0]);

            int m = Convert.ToInt32(nms[1]);

            int s = Convert.ToInt32(nms[2]);

            int result = SaveThePrisoner(n, m, s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
