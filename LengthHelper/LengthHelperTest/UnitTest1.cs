using System;
using Xunit;
using LengthHelperNamespace;

namespace LengthHelperTest
{
    public class UnitTest1
    {
        [Fact]
        public void GetLengthShouldBeEqual()
        {
            var lengthHelper = new LengthHelper();
            Assert.Equal(11, lengthHelper.GetLength("HelloWorld!"));
        }

        [Fact]
        public void GetLengthShouldNotBeEqual()
        {
            var lengthHelper = new LengthHelper();
            Assert.NotEqual(6, lengthHelper.GetLength("NOTEQUAL"));
        }

        [Fact]
        public void GetLengthShouldBeEmpty()
        {
            var lengthHelper = new LengthHelper();
            Assert.Equal(0, lengthHelper.GetLength(""));
        }
    }
}