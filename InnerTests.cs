using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pr2Tests
{
    [TestClass]
    class InnerTests
    {
        [TestMethod]
        public void IsMult()
        {
            int a = 3;
            int b = 2;
            int expected = 6;

            MathOperations m = new MathOperations();
            int actual = m.M(a, b);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void IsDivide()
        {
            int a = 4;
            int b = 2;
            int expected = 2;

            MathOperations m = new MathOperations();
            int actual = m.D(a, b);

            Assert.AreEqual(expected, actual);

        }
    }
}
