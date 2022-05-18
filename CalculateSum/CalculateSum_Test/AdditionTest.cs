using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CalculateSum_Test
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void Two_Odd_Sums_And_Two_Even_Sums()
        {
            int[] terms1 = new int[] { 8, 8};
            var sum1 = terms1.Sum() % 2;
            sum1.Should().Be(0);

            int[] terms2 = new int[] { 16, 8 };
            var sum2 = terms2.Sum() % 2;
            sum2.Should().Be(0);

            int[] terms3 = new int[] { 40, 5 };
            var sum3 = terms3.Sum() % 2;
            sum3.Should().Be(1);

            int[] terms4 = new int[] { 18, 1 };
            var sum4 = terms4.Sum() % 2;
            sum4.Should().Be(1);
        }
    }
}
