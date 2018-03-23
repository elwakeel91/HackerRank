// URL of the problem
// https://www.hackerrank.com/challenges/day-of-the-programmer/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static string solve(int year)
    {
        string sYear = year.ToString();

        if (year < 1918)
            return (year % 4 == 0) ? "12.09." + sYear : "13.09." + sYear;
        if (year > 1918)
            return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) ? "12.09." + sYear : "13.09." + sYear;
        if (year == 1918)
            return "26.09." + sYear;

        return null;
    }

    static void Main(String[] args)
    {
        int year = Convert.ToInt32(Console.ReadLine());
        string result = solve(year);
        Console.WriteLine(result);
    }
}