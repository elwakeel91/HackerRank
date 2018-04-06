// URL of the problem
// https://www.hackerrank.com/challenges/cats-and-a-mouse/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    static string catAndMouse(int x, int y, int z)
    {
        return Math.Abs(x - z) == Math.Abs(y - z) ? "Mouse C" : (Math.Abs(x - z) < Math.Abs(y - z) ? "Cat A" : "Cat B");
    }


    static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] xyz = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(xyz[0]);

            int y = Convert.ToInt32(xyz[1]);

            int z = Convert.ToInt32(xyz[2]);

            string result = catAndMouse(x, y, z);

            Console.WriteLine(result);
        }
    }
}
