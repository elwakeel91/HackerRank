// URL of the problem
// https://www.hackerrank.com/challenges/dynamic-array/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void dynamicArray(int n, int[][] queries)
    {
        // Variables holding our last answer and the sequence index
        int lastAnswer = 0;
        int seqIndex;

        // Variable holding the sequence list
        var seqList = new List<List<int>>(n);
        for (int i = 0; i < n; i++)
            // Initialise the sequence list with a list of integers
            seqList.Add(new List<int>());
        
        // Loop through the queries
        for (int row = 0; row < queries.Length; row++)
        {
            // Initialise x and y values
            int x = queries[row][1];
            int y = queries[row][2];
            // Get the sequence index
            seqIndex = ((x ^ lastAnswer) % n);

            // Check if we have to do query 1
            if (queries[row][0] == 1)
            {
                // Append the value of y to the sequence at sequence index
                seqList[seqIndex].Add(y);
            }

            // Else we have to do query 2
            else
            {
                // Get the value of (y % size)
                int yModSize = y % seqList[seqIndex].Count;
                // Set the value of last answer
                lastAnswer = seqList[seqIndex][yModSize];
                // Write the value of last answer on the console
                Console.WriteLine(lastAnswer);
            }
        }
    }

    static void Main(string[] args)
    {
        // Get the values of n and q from the user input
        string[] nq = Console.ReadLine().Split(' ');
        // Convert the values of n and q to integers
        int n = Convert.ToInt32(nq[0]);
        int q = Convert.ToInt32(nq[1]);

        // Jagged array of integers to hold our queries of length q
        int[][] queries = new int[q][];

        for (int queriesRowItr = 0; queriesRowItr < q; queriesRowItr++)
        {
            queries[queriesRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        dynamicArray(n, queries);
    }
}
