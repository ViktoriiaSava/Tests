using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pr2Tests;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsAdding()
        {
            int a = 3;
            int b = 2;
            int expected = 5;

            MathOperations m = new MathOperations();
            int actual = m.A(a, b);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void IsSubs()
        {
            int a = 3;
            int b = 2;
            int expected = 1;

            MathOperations m = new MathOperations();
            int actual = m.S(a, b);

            Assert.AreEqual(expected, actual);

        }
    }
}
