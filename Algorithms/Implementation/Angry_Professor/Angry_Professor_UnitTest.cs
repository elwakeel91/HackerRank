using System;
using HackerRank_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.UnitTests
{
    [TestClass]
    public class ProgramTest
    {
        /// <summary>
        /// Test AngryProfessor method: Lessons is cancelled returns "YES"
        /// </summary>
        [TestMethod]
        public void AngryProfessor_LessonIsCancelled_ReturnsYes()
        {
            // Arrange
            int minimumNumberOnTime = 3;
            int numberOfStudents = 4;
            int[] arrivalTimes = new int[] { -2, -3, 2, 1 };
            var expectedResult = "YES";

            // Act
            var result = Solution.angryProfessor(numberOfStudents, minimumNumberOnTime, arrivalTimes);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        /// <summary>
        /// Test AngryProfessor method: Lesson is NOT cancelled returns "NO"
        /// </summary>
        [TestMethod]
        public void AngryProfessor_LessonIsNotCancelled_ReturnsNo()
        {
            // Arrange
            int numberOfStudents = 4;
            int minimumNumberOnTime = 3;
            int[] arrivalTimes = new int[] { -4, -2, 0, 1 };
            var expectedResult = "NO";

            // Act
            var result = Solution.angryProfessor(numberOfStudents, minimumNumberOnTime, arrivalTimes);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
