// URL of the problem
// https://www.hackerrank.com/challenges/sock-merchant/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    static int sockMerchant(int n, int[] ar)
    {
        // Sort the array into order
        Array.Sort(ar);

        // Variables holding the number of socks, pairs and the sock color
        int numberOfSocks = 0;
        int numberOfPairs = 0;
        int lastSockColor = ar[0];

        // Loop through the array
        for (int i = 0; i < ar.Length; i++)
        {
            // Check if the last sock color matches the current one
            if (lastSockColor == ar[i])
            {
                // Add one to the number of socks
                numberOfSocks++;

                if (i == (ar.Length - 1) )
                    // Set the number of pairs
                    numberOfPairs += numberOfSocks / 2;
            }
                

            // Otherwise there is a new sock color
            else if (lastSockColor != ar[i])
            {
                // Set the number of pairs
                numberOfPairs += numberOfSocks / 2;

                // Reset the number of socks
                numberOfSocks = 1;
                // Set a new sock color
                lastSockColor = ar[i];
            }
        }

        return numberOfPairs;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = sockMerchant(n, ar);
        Console.WriteLine(result);
    }
}