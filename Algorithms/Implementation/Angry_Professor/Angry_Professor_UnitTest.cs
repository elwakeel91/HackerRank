using System;
using HackerRank_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.UnitTests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void AngryProfessor_LessonIsCancelled_ReturnsYes()
        {
            // Arrange
            int minimumNumberOnTime = 3;
            int numberOfStudents = 4;
            int[] arrivalTimes = new int[] { -2, -3, 2, 1 };

            // Act
            var result = Solution.angryProfessor(numberOfStudents, minimumNumberOnTime, arrivalTimes);

            // Assert
            Assert.AreEqual(result, "YES");
        }

        [TestMethod]
        public void AngryProgessor_LessonIsNotCancelled_ReturnsNo()
        {
            // Arrange
            int numberOfStudents = 4;
            int minimumNumberOnTime = 3;
            int[] arrivalTimes = new int[] { -4, -2, 0, 1 };

            // Act
            var result = Solution.angryProfessor(numberOfStudents, minimumNumberOnTime, arrivalTimes);

            // Assert
            Assert.AreEqual(result, "NO");
        }
    }
}
