using System;
using Xunit;

namespace myMicroserviceTest
{
    public class BasicTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(10, Add(5, 5));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
