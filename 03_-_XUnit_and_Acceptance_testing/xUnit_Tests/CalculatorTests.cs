using _03___XUnit_and_Acceptance_testing;
using System;
using Xunit;

namespace xUnit_Tests
{
    public class CalculatorTests
    {
        ///Arrange
        Calculator calculator = new Calculator();

        [Fact]
        public void Addition_When_Augend_21_And_Addend_79_Then_Sum_100()
        {
            ///Act
            int sumResult = calculator.Addition(21, 79);

            ///Assert
            Assert.Equal(100, sumResult);
        }

        [Fact]
        public void Subtraction_When_Minuend_15_And_Subtrahend_25_Then_Difference_Negative_10()
        {
            int diffResult = calculator.Subtraction(15, 25);

            Assert.Equal(-10, diffResult);
        }

        [Theory]
        [InlineData(-5, 19, -95)]
        [InlineData(12, 3, 36)]
        [InlineData(111, 11, 1221)]
        [InlineData(484, -20, -9680)]
        [InlineData(-99, 3, -297)]
        public void MultiplicationTheory(int multiplicand, int multiplier, int product)
        {
            int productResult = calculator.Multiplication(multiplicand, multiplier);

            Assert.Equal(product, productResult);
        }

        [Fact]
        public void Division_When_Dividant_Negative_32_And_Divisor_8_Then_Product_Negative_4()
        {
            int diffResult = calculator.Division(-32, 8);

            Assert.Equal(-4, diffResult);
        }


    }
}
