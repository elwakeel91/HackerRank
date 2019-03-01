using System;
using System.IO;
using System.Linq;

namespace HackerRank
{
    public class Solution
    {

        // Complete the permutationEquation function below.
        public static int[] PermutationEquation(int[] p)
        {
            // Initialise an array for the values of y
            int[] y = new int[p.Length];

            // Loop through the p array
            for (int x = 1; x <= p.Length; x++)
            {
                // Find the index of x in the p array
                for (int i = 0; i < p.Length; i++)
                {
                    // If we found the index
                    if (x == p[i])
                    {
                        // Set the value of y 
                        y[p[x - 1] - 1] = i + 1;
                    }
                }
            }

            return y;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp));
            int[] result = PermutationEquation(p);

            textWriter.WriteLine(string.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
