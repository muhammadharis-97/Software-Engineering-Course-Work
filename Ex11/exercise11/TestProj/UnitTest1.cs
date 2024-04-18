using exercise11;

namespace TestProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int res = Calculator.Sum(12, 2);
            Assert.AreEqual(14, res);

        }

        [TestMethod]
        public void TestMethod2()
        {
            int res1 = Calculator.Sub(23, 6);
            Assert.AreEqual(13, res1);
        }
    }
}