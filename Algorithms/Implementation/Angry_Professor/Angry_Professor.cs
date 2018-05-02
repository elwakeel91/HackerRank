// URL of the problem
// https://www.hackerrank.com/challenges/angry-professor/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace HackerRank_CSharp
{
    sealed class Solution
    {
        static string angryProfessor(int numberOfStudents, int minimumNumberOnTime, int[] arrivalTimes)
        {
            // Calculate the maximum number of students that don't come to class
            int maximumNumberLate = numberOfStudents - minimumNumberOnTime;
            int numberOfLate = 0;
            int numberOnTime = 0;

            // Loop through the arrival times
            for (int i = 0; i < numberOfStudents; i++)
            {
                // If the student arrived late
                if (arrivalTimes[i] > 0)
                {
                    // Increase the number of late students
                    numberOfLate++;
                    // If we have exceeded the maximum number of late students, cancel the class
                    if (numberOfLate > maximumNumberLate) return "YES";
                }
                else // The student is on time
                {
                    // Increase the number of students on time
                    numberOnTime++;
                    // If we have reached the required minimum number of students, the class is NOT cancelled
                    if (numberOnTime == minimumNumberOnTime) return "NO";
                }
            }
            // We should have returned a "YES" or "NO", else something is wrong
            return "Function failed";
        }

        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                string result = angryProfessor(n, k, a);
                Console.WriteLine(result);
            }
        }
    }
}
