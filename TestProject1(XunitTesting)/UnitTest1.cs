using System;
using Xunit;

namespace TestProject1_XunitTesting_
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int p = 0;
            p = 20;
            Assert.True(p==20, "Assert passed");
        }
    }
}
