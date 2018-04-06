// URL of the problem
// https://www.hackerrank.com/challenges/array-left-rotation/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    static void LeftRotate(ref int[] arr, int n, int d)
    {
        // Create a new array of the same size
        int[] tempArray = new int[n];
        for (int i = 0; i < tempArray.Length; i++)
        {
            // Get the old position of the current index
            int oldPosition = (i + d - n) < 0 ? (n + (i + d - n)) : (i + d - n);
            // Set the current index from the old index location
            tempArray[i] = arr[oldPosition];
        }
        // Left rotate the array
        arr = tempArray;
    }

    static void Main(string[] args)
    {
        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

        LeftRotate(ref a, n, d);

        Console.WriteLine(String.Join(" ", a));
    }
}