using System;
using HackerRank_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.UnitTests
{
    [TestClass]
    public class ProgramTest
    {
        /// <summary>
        /// Test Kangaroo method: The kangaroos meet returns "YES"
        /// </summary>
        [TestMethod]
        public void UtopianTree_KangaroosMeet_ReturnsYES()
        {
            // Arrange
            int x1 = 0;
            int v1 = 3;
            int x2 = 4;
            int v2 = 2;
            var expectedResult = "YES";

            // Act
            var result = Solution.Kangaroo(x1, v1, x2, v2);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        /// <summary>
        /// Test Kangaroo method: The kangaroos DON'T meet returns "NO"
        /// </summary>
        [TestMethod]
        public void UtopianTree_KangaroosDontMeet_ReturnsNO()
        {
            // Arrange
            int x1 = 0;
            int v1 = 2;
            int x2 = 5;
            int v2 = 3;
            var expectedResult = "NO";

            // Act
            var result = Solution.Kangaroo(x1, v1, x2, v2);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
