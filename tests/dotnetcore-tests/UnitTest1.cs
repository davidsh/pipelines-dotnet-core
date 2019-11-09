using System;
using Xunit;
using Xunit.Abstractions;

namespace dotnetcore_tests
{
    public class UnitTest1
    {
        private ITestOutputHelper _output;

        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void PassingTest()
        {
            _output.WriteLine("PassingTest");
        }

        [Fact]
        public void FailingTest()
        {
            _output.WriteLine("FailingTest");
            int i = 5;
            Assert.Equal(4, i);
        }
    }
}
