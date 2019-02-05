using System;
using Xunit;

namespace TreeTestsCS
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var greeting = Trees.Say.Hello("Bob");
            Assert.Equal("Hello Bob", greeting);

            var bye = Trees.Say.Bye("Felicia");

            var z = Trees.Say.Add(2, 3);
        }
    }
}
