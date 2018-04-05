// URL of the problem
// https://www.hackerrank.com/challenges/drawing-book/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int solve(int n, int p)
    {
        int frontTurn = p / 2 ;
        int backTurn = (p != n) ? (n - p) / 2 : 0;
        if (n % 2 == 0 && p % 2 != 0)
            backTurn++;
        return (frontTurn < backTurn) ? frontTurn : backTurn;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        int result = solve(n, p);
        Console.WriteLine(result);
    }
}