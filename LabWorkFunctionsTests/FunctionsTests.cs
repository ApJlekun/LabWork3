using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabWorkFunctions.Tests
{
    [TestClass()]
    public class FunctionsTests
    {
        [TestMethod()]
        [DataTestMethod()]
        public void FactorialTest_CorrectValues()
        {
            int x = 5;
            int expected = 120;

            int actual = Functions.GetFactorial(x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_IncorrectValues()
        {
            int x = 0;
            int expected = -1;

            int actual = Functions.GetFactorial(x);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        [DataTestMethod()]
        [DataRow(1.5, 2, 2.25)]
        [DataRow(2, -4, 0.063)]
        public void PowerTest_PositivePower(double x, int n, double expected)
        {
            Assert.AreEqual(expected, Functions.GetPower(x, n), 0.001);
        }

        [TestMethod()]
        [DataTestMethod()]
        public void PowerTest_NegativePower(double x, int n, double expected)
        {
            Assert.AreEqual(expected, Functions.GetPower(x, n), 0.001);
        }
    }
}