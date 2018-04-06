// URL of the problem
// https://www.hackerrank.com/challenges/electronics-shop/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int getMoneySpent(int[] keyboards, int[] drives, int s)
    {
        // Variable storing the amount of money spent
        int moneySpent = -1;

        // Loop through the keyboards
        for (int i = 0; i < keyboards.Length; i++)
        {
            // Check if the keyboard is already too expensive
            if (keyboards[i] >= s)
                // Skip to the next keyboard
                continue;

            // Loop through the drives
            for (int j = 0; j < drives.Length; j++)
            {
                // Check if the price of keyboard and drive is within budget and the most expensive combination
                if (keyboards[i] + drives[j] <= s && keyboards[i] + drives[j] > moneySpent)
                    // Store the amount of money spent with this combination
                    moneySpent = keyboards[i] + drives[j];
            }
        }
        // Return the maximum money spent
        return moneySpent;
    }

    static void Main(String[] args)
    {
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]);
        int n = Convert.ToInt32(tokens_s[1]);
        int m = Convert.ToInt32(tokens_s[2]);
        string[] keyboards_temp = Console.ReadLine().Split(' ');
        int[] keyboards = Array.ConvertAll(keyboards_temp, Int32.Parse);
        string[] drives_temp = Console.ReadLine().Split(' ');
        int[] drives = Array.ConvertAll(drives_temp, Int32.Parse);
        //  The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
        int moneySpent = getMoneySpent(keyboards, drives, s);
        Console.WriteLine(moneySpent);
    }
}
