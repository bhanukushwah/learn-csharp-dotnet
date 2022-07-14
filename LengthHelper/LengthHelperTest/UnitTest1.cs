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

        [Fact]
        public void GetLengthShouldThrowEceptionOnNull()
        {
            var lengthHelper = new LengthHelper();

            var exception = Assert.Throws<NullReferenceException>(() => lengthHelper.GetLength(null));
            Console.WriteLine(exception.Message);
            Assert.Equal("Object reference not set to an instance of an object.", exception.Message);
        }
    }
}