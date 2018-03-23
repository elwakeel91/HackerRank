// URL of the problem
// https://www.hackerrank.com/challenges/migratory-birds/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int MigratoryBirds(int n, int[] ar)
    {
        // Variables holding the total number of each type
        int totalTypeOne = 0;
        int totalTypeTwo = 0;
        int totalTypeThree = 0;
        int totalTypeFour = 0;
        int totalTypeFive = 0;

        // Loop through the array
        for (int i = 0; i < ar.Length; i++)
        {
            // Check what type it is
            switch (ar[i])
            {
                // Type 1
                case 1:
                    totalTypeOne++;
                    break;
                // Type 2
                case 2:
                    totalTypeTwo++;
                    break;
                // Type 3
                case 3:
                    totalTypeThree++;
                    break;
                // Type 4
                case 4:
                    totalTypeFour++;
                    break;
                // Type 5
                case 5:
                    totalTypeFive++;
                    break;
            }
        }

        // Check if Type One is the most common
        if (totalTypeOne >= totalTypeTwo &&
            totalTypeOne >= totalTypeThree &&
            totalTypeOne >= totalTypeFour &&
            totalTypeOne >= totalTypeFive)
            // Return Type 1
            return 1;

        // Check if Type Two is the most common
        if (totalTypeTwo >= totalTypeThree &&
            totalTypeTwo >= totalTypeFour &&
            totalTypeTwo >= totalTypeFive)
            // Return Type 2
            return 2;

        // Check if Type Three is the most common
        if (totalTypeThree >= totalTypeFour &&
            totalTypeThree >= totalTypeFive)
            // Return Type 3
            return 3;

        // Check if Type Four is the most common
        if (totalTypeFour >= totalTypeFive)
            // Return Type 4
            return 4;

        // Return Type 5
        return 5;

    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = migratoryBirds(n, ar);
        Console.WriteLine(result);
    }
}
