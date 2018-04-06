// URL of the problem
// https://www.hackerrank.com/challenges/2d-array/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    static int array2D(int[][] arr)
    {
        // Variable holding the current sum and maximum sum
        int sum = 0;
        int maxSum = -1000;

        // Loop through the rows
        for (int row = 0; row < 4; row++)
        {
            // Loop through the columns
            for (int column = 0; column < 4; column++)
            {
                // Calculate the hourglass sum
                sum = arr[row][column] + arr[row][column + 1] + arr[row][column + 2] +
                                       +arr[row + 1][column + 1] +
                      arr[row + 2][column] + arr[row + 2][column + 1] + arr[row + 2][column + 2];

                // Check if its bigger than our old maximum sum and set accordingly
                maxSum = sum > maxSum ? sum : maxSum;
            }
        }
        // Return the maximum sum found
        return maxSum;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int arrRowItr = 0; arrRowItr < 6; arrRowItr++)
        {
            arr[arrRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = array2D(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int arrRowItr = 0; arrRowItr < 6; arrRowItr++)
        {
            arr[arrRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = array2D(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
