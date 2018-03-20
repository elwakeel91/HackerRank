using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    // Handles rounding the grades
    static int[] solve(int[] grades)
    {
        // Loop through the grades array
        for (int i = 0; i < grades.Length; i++)
        {
            // Check if the grade is at least 38 and can be rounded
            if (grades[i] >= 38 && (grades[i] % 5) >= 3)
            {
                // Get the second digit
                int secondDigit = (grades[i] % 10);

                // Check if the second digit is less than 5, then round up or down accordingly
                grades[i] = secondDigit < 5 ? grades[i] : grades[i] + 10;
                secondDigit = secondDigit < 5 ? 5 : 0;

                // Set the final grade
                grades[i] = firstDigit * 10 + secondDigit;
            }
        }

        // Return the rounded grades array
        return grades;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[n];
        for (int grades_i = 0; grades_i < n; grades_i++)
        {
            grades[grades_i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] result = solve(grades);
        Console.WriteLine(String.Join("\n", result));


    }
}