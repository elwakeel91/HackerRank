// URL of the problem
// https://www.hackerrank.com/challenges/counting-valleys/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int countingValleys(int n, string s)
    {
        // Variable holding the number of valleys
        int numberOfValleys = 0;

        // Variables holding the current and last height of the climber
        int currentHeight = 0;
        int lastHeight = 0;

        foreach (char step in s)
        {
            // Check if we are stepping up (otherwise we are stepping down) then set the current height
            currentHeight = (step == 'U') ? currentHeight + 1 : currentHeight - 1;

            // Check if the current height is below sea level and the last height was above or at sea level, 
            // therefore we have entered a valley
            if (currentHeight < 0 && lastHeight >= 0)
            {
                numberOfValleys++;
            }

            // Set the last height to be the current height for the next step
            lastHeight = currentHeight;
        }

        return numberOfValleys;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int result = countingValleys(n, s);
        Console.WriteLine(result);
    }
}