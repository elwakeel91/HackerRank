// URL of the problem
// https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        /// <summary>
        /// Calculates Alice's rank for each time she played
        /// </summary>
        /// <param name="scores"></param>
        /// <param name="alice"></param>
        /// <returns></returns>
        static int[] ClimbingLeaderboard(int[] scores, int[] alice)
        {
            // Create a new list of unique scores
            List<int> uScores = new List<int>() { 0 };

            // Loop through the scores array
            for (int i = 0; i < scores.Length; i++)
            {
                // Check if the score value is NOT on our list of unique scores
                if (uScores.Last() != scores[i])
                    // Add the score value to our list
                    uScores.Add(scores[i]);
            }

            // Variable holding the rank of Alice's games
            int[] aliceRank = new int[alice.Length];

            // Loop through Alice's scores
            for (int j = 0; j < alice.Length; j++)
            {
                // While her score is bigger than the lowest score and there are scores to compare with
                while (alice[j] >= uScores.Last() && uScores.Count > 1)
                    // Remove the lowest score on our unique score list
                    uScores.RemoveAt(uScores.Count - 1);

                // Set Alice's rank for this game
                aliceRank[j] = uScores.Count;
            }

            // Return the array of Alice's ranks
            return aliceRank;
        }

        static void Main(string[] args)
        {
            int scoresCount = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
            ;
            int aliceCount = Convert.ToInt32(Console.ReadLine());

            int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
            ;
            int[] result = ClimbingLeaderboard(scores, alice);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}
