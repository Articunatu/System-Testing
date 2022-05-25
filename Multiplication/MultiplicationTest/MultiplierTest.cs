using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplicationApp;

namespace MultiplicationTest
{
    [TestClass]
    public class MultiplierTest
    {
        [TestMethod]
        public void GetProduct_When_Factor1_5_And_Factor2_9_Then_Result_45()
        {
            Multiplier m = new Multiplier();

            int expected = 44;
            int actual = m.Product(5, 9);

            Assert.AreEqual(expected, actual);
        }
    }
}
