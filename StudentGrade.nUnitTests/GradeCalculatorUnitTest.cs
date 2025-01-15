using NUnit.Framework;
using StudentGrades;

namespace StudentGrade.nUnitTests
{
    public class GradeCalculatorUnitTest
    {
        private GradeCalculator _gradeCalculator { get; set; } = null!;


        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        // Positive Test Cases
        [TestCase(91)]
        [TestCase(95)]
        [TestCase(97)]
        [TestCase(99)]
        public void GetGradePercentage_EqualTest(int percentage)
        {
            // Assign
            //var percentage = 99;

            // Act
            var grade = _gradeCalculator.GetGradePercentage(percentage);

            // Assert
            Assert.AreEqual("A", grade);

        }


        // Negative Test Cases
        [TestCase(1)]
        [TestCase(45)]
        [TestCase(70)]
        [TestCase(89)]
        public void GetGradePercentage_NotEqualTest(int percentage)
        {
            // Assign
            //var percentage = 99;

            // Act
            var grade = _gradeCalculator.GetGradePercentage(percentage);

            // Assert
            Assert.AreNotEqual("A", grade);

        }
    }
}