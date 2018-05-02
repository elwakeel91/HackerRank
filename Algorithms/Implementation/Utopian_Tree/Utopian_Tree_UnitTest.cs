using System;
using HackerRank_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.UnitTests
{
    [TestClass]
    public class ProgramTest
    {
	    /// <summary>
        /// Test UtopianTree method: Input of 3 cycles returns a height of 6m
        /// </summary>
        [TestMethod]
        public void UtopianTree_ThreeCycles_ReturnsSix()
        {
            // Arrange
            int cycles = 3;
            int expectedResult = 6;

            // Act
            var result = Solution.UtopianTree(cycles);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
