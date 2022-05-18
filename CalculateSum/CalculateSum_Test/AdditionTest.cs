using CalculateSum;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateSum_Test
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void Two_Odd_Sums_And_Two_Even_Sums()
        {
            Math m = new Math();

            var sum1 = m.Sum(8, 8);
            (sum1 % 2).Should().Be(0);

            var sum2 = m.Sum(16, 8);
            (sum2 % 2).Should().Be(0);

            var sum3 = m.Sum(40, 5);
            (sum3 % 2).Should().Be(1);

            var sum4 = m.Sum(18, 11);
            (sum4 % 2).Should().Be(1);
        }
    }
}
