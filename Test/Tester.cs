
using NUnit.Framework;
using PrimeNumbers.PrimeHandler;

namespace Tests
{
    public class TestANumberTests
    {
        TestANumber testANumber = new();
        [Test]
        [TestCase(int.MinValue, false)]
        [TestCase(-1, false)]
        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(10, false)]
        [TestCase(100, false)]
        [TestCase(1005, false)]
        [TestCase(int.MaxValue - 1, false)]
        public void PrimeTester__ExpectedFalse(int numberToTest, bool expected)
        {
            var actual = testANumber.PrimeCalculator(numberToTest);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(5, true)]
        [TestCase(7, true)]
        [TestCase(97, true)]
        public void PrimeTester__ExpectedTrue(int numberToTest, bool expected)
        {
            var actual = testANumber.PrimeCalculator(numberToTest);
            Assert.AreEqual(expected, actual);
        }
    }
}
