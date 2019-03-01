using System;
using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankUnitTests
{
    [TestClass]
    public class SequenceEquation
    {
        [TestMethod]
        public void GivenArrayP1_ReturnArrayY()
        {
            // Arrange
            int[] p = new int[] 
            {
                5, 2, 1, 3, 4
            };
            int[] expected = new int[]
            {
                4, 2, 5, 1, 3
            };

            // Act
            int[] actual = Solution.PermutationEquation(p);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenArrayP2_ReturnArrayY()
        {
            // Arrange
            int[] p = new int[]
            {
                2, 3, 1
            };
            int[] expected = new int[]
            {
                2, 3, 1
            };

            // Act
            int[] actual = Solution.PermutationEquation(p);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
