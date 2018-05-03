using System;
using HackerRank_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.UnitTests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void BirthdayBar_TwoSquaresAddingToThree_ReturnsTwo()
        {
            // Arrange
            int n = 5;
            int[] s = new int[] { 1, 2, 1, 3, 2 };
            int d = 3;
            int m = 2;
            int expectedResult = 2;

            // Act
            var result = Solution.BirthdayBar(n, s, d, m);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void BirthdayBar_ThreeSquaresAddingToTwo_ReturnsZero()
        {
            // Arrange
            int n = 6;
            int[] s = new int[] { 1, 1, 1, 1, 1 };
            int d = 2;
            int m = 3;
            int expectedResult = 0;

            // Act
            var result = Solution.BirthdayBar(n, s, d, m);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
