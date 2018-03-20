using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
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

    /// <summary>
    /// Find the GCD of an array of numbers
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Finds the GCD of two numbers
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
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
        string[] input = Console.ReadLine().Split(' ');

        // Conver the input to an array of numbers
        int[] array = new int[input.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Int32.Parse(input[i]);
        }

        // Output the GCD
        Console.WriteLine(GCD(array));
        // Output the LCM
        Console.WriteLine(LCM(array));

        Console.Read();
    }
}