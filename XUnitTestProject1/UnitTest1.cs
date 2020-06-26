using System;
using Xunit;
using hackerrank;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestSockMerckant()
        {
            int[] ar = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int n = 9;
            Challenges ch = new Challenges();
            int result = 3;
            Assert.Equal(result, ch.sockMerchant(n, ar));
        }
    }
}
