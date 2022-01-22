using NUnit.Framework;

namespace TestProject1Nunitfortesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            int p = 10;
            p = 15;
            Assert.IsTrue(p == 15, "Test passed");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}