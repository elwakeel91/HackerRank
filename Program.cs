using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    // solve using the equation:
    // Number of jumps = (x1 - x2) / (v2 - v1)

    static string Kangaroo(int x1, int v1, int x2, int v2)
    {
        // Check if they are already at the same position
        if (x1 == x2)
            return "YES";

        // Find the number of jumps
        float numberOfJumps = (float)(x1 - x2) / (v2 - v1);

        // Check that the number of jumps is positive and we don't have a remainder
        if (numberOfJumps >= 0 && (numberOfJumps % 1) == 0)
            return "YES";
        else
            return "NO";
    }

    static void Main(String[] args)
    {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        string result = Kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);
    }
}