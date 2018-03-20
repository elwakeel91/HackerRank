// URL of the problem
// https://www.hackerrank.com/challenges/between-two-sets/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    // Finds the total number of possible values
    static int getTotalX(int[] a, int[] b)
    {
        // Get the LCM and GCD of the respective arrays
        int lcm = LCM(a);
        int gcd = GCD(b);

        // Variable holding our counter
        int count = 0;

        // Loop through multiples of the LCM
        for (int i = 1; (lcm * i) <= gcd; i++)
        {
            // Check if the (lcm * i) is a multiple of the GCD
            if (gcd % (lcm * i) == 0)
                // Add one to our counter
                count++;
        }
        
        // Return the total number between the two sets
        return count;
    }

    // Finds the LCM of an array of integers
    static int LCM(int[] array)
    {
        // Variable holding our LCM set as the first number in the array
        int lcm = array[0];

        // Loop through the array
        for (int i = 0; i < array.Length; i++)
        {
            // Find the LCM of the current number and the running LCM
            lcm = LCM(lcm, array[i]);
        }

        // Return the LCM of the array
        return lcm;
    }

    // Find the LCM of two integers
    static int LCM(int x, int y)
    {
        return (x * y) / (GCD(x, y));
    }

    // Find the GCD of an array of numbers
    static int GCD(int[] array)
    {
        // Variable to hold our GCD set to the first number in the array
        int gcd = array[0];

        // Loop through the array
        for (int i = 0; i < array.Length; i++)
        {
            // Find the new GCD using the current number and the running GCD
            gcd = GCD(gcd, array[i]);
        }

        // Return the GCD
        return gcd;
    }

    // Finds the GCD of two numbers
    static int GCD(int x, int y)
    {
        // Set number 1 as the bigger of the two numbers
        int num1 = x > y ? x : y;
        // and number 2 as the other number
        int num2 = num1 == x ? y : x;
        // Variable to hold our remainder
        int remainder;

        // Loop until there is no remainder when you divide the 2 numbers
        while (num1 % num2 != 0)
        {
            // Get the remainder when you divide the 2 numbers
            remainder = num1 % num2;
            // Set num1 to be equal to the smaller number
            num1 = num2;
            // Set num2 to be equal to the remainder
            num2 = remainder;
        }

        // Return the GCD
        return num2;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp, Int32.Parse);
        int total = getTotalX(a, b);
        Console.WriteLine(total);
    }
}
