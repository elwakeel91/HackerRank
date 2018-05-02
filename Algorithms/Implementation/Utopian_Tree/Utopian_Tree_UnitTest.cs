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
            // Act : Set the cycles to 3
            var result = Solution.UtopianTree(3);

            // Assert : The result is 6m
            Assert.AreEqual(result, 6);
        }
    }
}
