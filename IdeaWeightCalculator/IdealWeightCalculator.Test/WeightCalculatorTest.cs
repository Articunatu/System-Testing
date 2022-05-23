using FluentAssertions;
using IdeaWeightCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace IdealWeightCalculator.Test
{
    [TestClass]
    public class WeightCalculatorTest
    {

        //[ClassInitialize]
        //public static void ClassInitializer()
        //{

        //}
        //[ClassCleanup]
        //public static void ClassCleaner()
        //{

        //}

        //[TestInitialize]
        //public void TestInitiallizer()
        //{

        //}
        //[TestCleanup]
        //public void TestCleaner()
        //{

        //}

        /////Given_When_Then
        //[TestMethod]
        //[Description("This test about checking if ideal body weight" + "Of man with 180 cn us equal to 72.5")]
        //[Owner("Anas")]
        //[Priority(1)]
        //[TestCategory("WeightCategory")]
        //public void GetIdealBodyWeight_Gender_M_And_Height_180_Return_72_5()
        //{
        //    /// AAA
        //    // Arrange
        //    WeightCalculator sut = new WeightCalculator
        //    {
        //        Gender = 'm',
        //        Height = 180
        //    };

        //    // Act
        //    var actual = sut.GetIdealBodyWeight();
        //    var expected = 72.5;

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //    //Assert.AreNotEqual(expected, actual);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //[Priority(1)]
        //[Owner("Anas")]
        //[TestCategory("WeightCategory")]
        //public void GetIdealBodyWeight_Gender_F_And_Height_180_Return_0()
        //{
        //    ///AAA

        //    //Arrange
        //    WeightCalculator sut = new WeightCalculator
        //    {
        //        Gender = '0',
        //        Height = 180
        //    };

        //    //Act
        //    var actual = sut.GetIdealBodyWeight();
        //    var expected = 0;

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //[TestCategory("AssertCategory")]
        //[Priority(2)]
        //[Owner("Tobias")]
        //public void Assert_Test()
        //{
        //    Assert.AreEqual(100, 90 + 10);

        //    Assert.AreNotEqual(40, 30);

        //    WeightCalculator cal1 = new WeightCalculator { Gender = 'f', Height = 180 };
        //    WeightCalculator cal2 = cal1;
        //    Assert.AreSame(cal1, cal2); ///Checks if the objects are the same instance

        //    WeightCalculator calculator = new WeightCalculator();
        //    Assert.IsNotInstanceOfType(calculator, typeof(WeightCalculator));
        //    calculator = null;
        //    Assert.IsNull(calculator);

        //    Assert.IsTrue(100 == 90);
        //    Assert.IsFalse(100 == 90);
        //}

        //[TestMethod]
        //[TestCategory("WeightCategory")]
        //[Priority(2)]
        //[Owner("Tobias")]
        //public void StringAssert_Test()
        //{
        //    string name = "Tobias";

        //    //StringAssert.Contains(name, "ias");

        //    //StringAssert.DoesNotMatch(); ///Regular Expression

        //    //StringAssert.EndsWith(name, "s");

        //    string name2 = "tobias";
        //    StringAssert.StartsWith(name, name2.Substring(0, 1).ToUpper() + name2.Substring(1, name2.Length - 1).ToLower());
        //}

        //[TestMethod]
        //[Priority(2)]
        //[Owner("Tobias")]
        //[TestCategory("AssertCategory")]
        //[Ignore]
        //public void CollectionsA()
        //{
        //    List<string> names = new List<string>()
        //    {
        //        "Anas", "Tobias", "Elin"
        //    };

        //    List<string> names1 = new List<string>()
        //    {
        //        "Tobias", "Anas", "Elin"
        //    };

        //    CollectionAssert.AllItemsAreNotNull(names);
        //    CollectionAssert.AllItemsAreInstancesOfType(names, typeof(int));
        //    CollectionAssert.Contains(names, "Elin");

        //    CollectionAssert.AreEqual(names, names1); ///To check if 2 lists are equal and has same reference in the memory

        //    CollectionAssert.AreEquivalent(names, names1); ///To check if 2 lists have the same data and the same order
        //    CollectionAssert.IsNotSubsetOf(names, names1);
        //}

        //[TestMethod]
        //[Owner("Reidar")]
        //[Priority(3)]
        //[TestCategory("AssetCategory")]
        //[Timeout(3000)]
        //public void FluentAssertion_Test()
        //{
        //    string name = "Tobias";

        //    name.Should().StartWith("T").And.EndWith("s");

        //    //int number = 10;
        //    //number.Should().BeGreaterThan(12);
        //    //number.Should().BeLessThanOrEqualTo(-11*-1);

        //    //List<string> names = new List<string>()
        //    //{
        //    //    "Anas", "Tobias", "Elin"
        //    //};

        //    //names.Should().HaveCount(2);
        //    //names.Should().BeEmpty();
        //}

        [TestMethod]
        public void GetBodyWeightDS_WithInput_Return_Correct_Result()
        {
            WeightCalculator calculator = new WeightCalculator();

            List<double> actual = calculator.GetIdealBodyFromDS();

            double[] exp = { 62.5, 62.75, 74 };

            CollectionAssert.AreEqual(exp, actual);
        }
    }
}