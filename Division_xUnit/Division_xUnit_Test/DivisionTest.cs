using Division_xUnit;
using System;
using Xunit;

namespace Division_xUnit_Test
{
    public class DivisionTest
    {

        Division division = new Division();

        [Fact]
        public void When_Numerator_10_And_Denomiator_5_Then_Quotient_2()
        {
            var expected = 2;

            var actual = division.Divide(10, 5);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_Numerator_Negative_8_And_Denomiator_2_Then_Quotient_Negative_4()
        {
            var expected = -4;

            var actual = division.Divide(-8, 2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(95,5, 19)]
        [InlineData(144, 12, 12)]
        [InlineData(-30, 6, -5)]
        [InlineData(88, -2, -44)]
        [InlineData(-249, -3, 83)]
        public void DivisionTheoery(int numerator, int denomiator, int expectedQuotient)
        {
            var actualQuotient = division.Divide(numerator, denomiator);

            Assert.Equal(expectedQuotient, actualQuotient);
        }
    }
}
