using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.UnitTests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void ViralAdvertising_DayOne_ReturnsTwo()
        {
            // Assert
            Assert.AreEqual(2, Solution.ViralAdvertising(1));
        }

        [TestMethod]
        public void ViralAdvertising_DayThree_ReturnsNine()
        {
            // Assert
            Assert.AreEqual(9, Solution.ViralAdvertising(3));
        }
    }
}
