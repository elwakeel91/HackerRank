using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.UnitTests
{
    [TestClass]
    public class ProgramTest
    {
        /// <summary>
        /// Given 5 prisoners, 2 sweets and starting seat 1 - Return prisoner 2
        /// </summary>
        [TestMethod]
        public void SaveThePrisoner_FivePrisonersTwoSweetsSeatOne_ReturnsSeatTwo()
        {
            // Arrange
            int prisoners = 5;
            int sweets = 2;
            int startingSeat = 1;

            // Assert
            Assert.AreEqual(2, Solution.SaveThePrisoner(prisoners, sweets, startingSeat));
        }

        /// <summary>
        /// Given 7 prisoners, 19 sweets and starting seat 2 - Return prisoner 6
        /// </summary>
        [TestMethod]
        public void SaveThePrisoner_SevenPrisonersNineteenSweetsSeatTwo_ReturnsSeatSix()
        {
            // Arrange
            int prisoners = 7;
            int sweets = 19;
            int startingSeat = 2;

            // Assert
            Assert.AreEqual(6, Solution.SaveThePrisoner(prisoners, sweets, startingSeat));
        }

        /// <summary>
        /// Given 352926151 prisoners, 380324688 sweets and starting seat 94730870 - Return prisoner 122129406
        /// </summary>
        [TestMethod]
        public void SaveThePrisoner_LargeNumbers_ReturnsCorrectSeat()
        {
            // Arrange
            int prisoners = 352926151;
            int sweets = 380324688;
            int startingSeat = 94730870;

            // Assert
            Assert.AreEqual(122129406, Solution.SaveThePrisoner(prisoners, sweets, startingSeat));
        }
    }
}
