// URL of the problem
// https://www.hackerrank.com/challenges/divisible-sum-pairs/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int DivisibleSumPairs(int n, int k, int[] arr)
    {
        // Variable holding the total pairs
        int totalPairs = 0;

        // Loop through the array comparing each value
        for (int i = 0; i < arr.Length; i++)
        {
            // Loop through the values ahead of the 'i' value
            for (int j = (i + 1); j < arr.Length; j++)
            {
                // Check if the sum of the pair is divisible by k
                totalPairs = (arr[i] + arr[j]) % k == 0 ? totalPairs + 1 : totalPairs;
            }
        }
        // Return the total number of pairs
        return totalPairs;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        int result = DivisibleSumPairs(n, k, arr);
        Console.WriteLine(result);
    }
}