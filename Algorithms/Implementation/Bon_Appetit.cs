// URL of the problem
// https://www.hackerrank.com/challenges/bon-appetit/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{

    class Solution
    {
        static void Main(string[] args)
        {
            // Get the values of 'n' and 'k' from the user
            string[] tokens_a = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_a[0]);
            int k = Convert.ToInt32(tokens_a[1]);

            // Get the cost of each object from the user
            string[] tokens_b = Console.ReadLine().Split(' ');
            int[] costArray = Array.ConvertAll(tokens_b, Int32.Parse);

            // Get the amount charged from the user
            int charge = Convert.ToInt32(Console.ReadLine());
            // Variable holding our calulated sum
            int sum = 0;

            // Loop through the cost of each item
            for (int i = 0; i < n; i++)
            {
                // Add the cost to our sum if it isn't the food she didn't eat
                sum = (i == k) ? sum : sum + costArray[i];
            }

            // Split the bill
            int splitBill = sum / 2;

            // Set the output
            string output = splitBill == charge ? "Bon Appetit" : (charge - splitBill).ToString();

            // Ouput the correct result
            Console.WriteLine(output);
        }
    }
}