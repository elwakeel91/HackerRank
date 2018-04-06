// URL of the problem
// https://www.hackerrank.com/challenges/arrays-ds/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    static int[] reverseArray(int[] a)
    {
        return a.Reverse().ToArray();
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int[] res = reverseArray(arr);

        textWriter.WriteLine(string.Join(" ", res));

        textWriter.Flush();
        textWriter.Close();
    }
}
