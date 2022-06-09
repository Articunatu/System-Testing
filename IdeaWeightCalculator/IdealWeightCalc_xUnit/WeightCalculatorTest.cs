using IdeaWeightCalculator;
using System;
using Xunit;

namespace IdealWeightCalc_xUnit
{
    public class WeightCalculatorTest
    {
        [Fact]
        public void GetIdealWeightBody_Gender_M_And_Height_180_Return_72_5()
        {
            WeightCalculator sut = new WeightCalculator
            {
                Gender = 'm',
                Height = 180
            };

            var actual = sut.GetIdealBodyWeight();

            var expected = 72.5;

            Assert.Equal(actual, expected);
        }

        public int Sum(int augend, int addend)
        {
            return augend + addend;
        }

        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Sum(1, 3));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Sum(1, 2));
        }

        public bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void TheoryTest(int value)
        {
            Assert.True(IsOdd(value));
        }
    }
}
