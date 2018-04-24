// URL of the problem
// https://www.hackerrank.com/challenges/determining-dna-health/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                          //
//  Still incomplete. Come back to this after researching Aho-Corasick algorith to solve.   //
//                                                                                          //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] genes = Console.ReadLine().Split(' ');
            string[] health_temp = Console.ReadLine().Split(' ');
            int[] health = Array.ConvertAll(health_temp, Int32.Parse);
            int s = Convert.ToInt32(Console.ReadLine());

            int maxHealth = 0;
            int minHealth = 0;

            for (int a0 = 0; a0 < s; a0++)
            {
                string[] tokens_first = Console.ReadLine().Split(' ');
                int first = Convert.ToInt32(tokens_first[0]);
                int last = Convert.ToInt32(tokens_first[1]);
                string d = tokens_first[2];

                int result = dnaHealth(genes, health, first, last, d);

                maxHealth = result > maxHealth ? result : maxHealth;
                minHealth = minHealth > result ? result : minHealth;
            }

            Console.WriteLine($"{maxHealth} {minHealth}");
        }

        private static int dnaHealth(string[] genes, int[] health, int first, int last, string d)
        {
            int result = 0;

            for (int i = first; i <= last; i++)
            {
                string subString = d;

                while (subString.Contains(genes[i]))
                {
                    int startIndex = subString.IndexOf(genes[i]);
                    subString = subString.Remove(startIndex, 1);
                    result += health[i];
                }
            }

            return result;
        }
    }
}
