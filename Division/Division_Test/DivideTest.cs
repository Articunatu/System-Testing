using Division_App;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Division_Test
{
    [TestClass]
    public class DivideTest
    {
        [TestMethod]
        [Priority(1)]
        public void GetRest_Numerator_95_And_Denomiator_5_Return_14()
        {
            Math math = new Math();

            int quota = math.Divide(95, 5);
            int expectedResult = 19;

            Assert.AreEqual(quota, expectedResult);

        }

        [TestMethod]
        [Priority(2)]
        public void GetRest_Numerator_144_And_Denomiator_Negative12_Return_Negative12()
        {
            Math math = new Math();

            int quota = math.Divide(144, -12);
            int expectedResult = -12;

            Assert.AreEqual(quota, expectedResult);
        }
    }
}
