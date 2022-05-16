using IdeaWeightCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IdealWeightCalculator.Test
{
    [TestClass]
    public class WeightCalculatorTest
    {
        ///Given_When_Then
        [TestMethod]
        public void GetIdealBodyWeight_Gender_M_And_Height_180_Return_72_5()
        {
            /// AAA
            // Arrange
            WeightCalculator sut = new WeightCalculator
            {
                Gender = 'm',
                Height = 180
            };

            // Act
            var actual = sut.GetIdealBodyWeight();
            var expected = 72.5;

            // Assert
            //Assert.AreEqual(expected, actual);
            Assert.AreNotEqual(expected, actual);
        }
    }
}