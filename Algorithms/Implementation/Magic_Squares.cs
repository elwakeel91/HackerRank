// URL of the problem
// https://www.hackerrank.com/challenges/magic-square-forming/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    // List of magic squares
    static int[][] magicSquares =  { new int[] { 8, 1, 6, 3, 5, 7, 4, 9, 2 },
                                     new int[] { 6, 1, 8, 7, 5, 3, 2, 9, 4 },
                                     new int[] { 4, 9, 2, 3, 5, 7, 8, 1, 6 },
                                     new int[] { 2, 9, 4, 7, 5, 3, 6, 1, 8 },
                                     new int[] { 8, 3, 4, 1, 5, 9, 6, 7, 2 },
                                     new int[] { 4, 3, 8, 9, 5, 1, 2, 7, 6 },
                                     new int[] { 6, 7, 2, 1, 5, 9, 8, 3, 4 },
                                     new int[] { 2, 7, 6, 9, 5, 1, 4, 3, 8 }};

    // Method to compare magic squares and calculate the cost of converting to a magic square
    static int formingMagicSquare(int[][] s)
    {
        // Array holding our cost variables when compared to magic squares
        int[] cost = { 0, 0, 0, 0, 0, 0, 0, 0 };

        // Loop through the magic squares
        for (int magicSquareNumber = 0; magicSquareNumber < magicSquares.Length; magicSquareNumber++)
        {
            // Loop through the rows of the user input square
            for (int row = 0; row < 3; row++)
            {
                // Loop through the columns of the user input square
                for (int column = 0; column < 3; column++)
                {
                    // Calculate the cost comparison to convert the user input into the current magic square
                    cost[magicSquareNumber] += Math.Abs(s[row][column] - magicSquares[magicSquareNumber][(row * 3) + column]);
                }
            }
        }

        // Return the smallest value in our cost array
        return cost.Min();
    }

    static void Main(String[] args)
    {
        // Create a 2D array of integers with 3 rows
        int[][] s = new int[3][];

        // Loop through the 3 ros
        for (int s_i = 0; s_i < 3; s_i++)
        {
            // Get user input for each row
            string[] s_temp = Console.ReadLine().Split(' ');
            // Convert it to an array of numbers
            s[s_i] = Array.ConvertAll(s_temp, Int32.Parse);
        }

        int result = formingMagicSquare(s);
        Console.WriteLine(result);
    }
}