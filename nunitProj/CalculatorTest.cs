using System;
using NUnit.Framework;
using nunitDemo;

namespace nunitProj
{
    [TestFixture]
    public class CalculatorTest
    {
        Calculator calc;
        [SetUp]
        public void SetUp()
        {
            calc = new Calculator();
        }


        [TearDown]
        public void TearDown()
        {
            calc.Dispose();
        }


        [Test, Order(3)]
        public void Test_Add_Method()
        {
            var result = calc.add(20, 40);
            Assert.AreEqual(60, result);
        }


        [Test, Order(1)]
        public void Test_Sustract_Method()
        {
            //var sub_result = calc.subtract(20, 40);
            //Assert.AreEqual(20, sub_result);
            Assert.Catch<SystemException>(() => calc.subtract(3, 4));
            Assert.Throws<ArgumentException>(() => calc.subtract(3, 4));
        }


        [TestCase(2,3,5),Order(2)]
        [TestCase(5, 5, 10)]
        [TestCase(6, 6, 12)]
        public void Multiple_argument_passed(int n1, int n2, int expectedResult)
        {
            var Add_Result = calc.add(n1, n2);
            Assert.AreEqual(expectedResult, Add_Result);
        }


        [Ignore("Ignore Test")]
        public void Test_Method_To_Be_Ignored()
        {

        }
    }
}
