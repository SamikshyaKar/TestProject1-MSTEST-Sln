using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1_MSTEST__1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int p = 10;
            p = 15;
            Assert.IsFalse(p < 15, "Test passed");
        }

        [TestMethod]
        public void TestMethod2()
        {
            int p = 10;
            p = 15;
            Assert.IsTrue(p == 15, "Test passed");
        }

        [TestMethod]
        public void TestMethod3()
        {
            int p = 10;
            p = 15;
            Assert.IsNotNull(p == 15, "Test passed");
        }
    }
}
