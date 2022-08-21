using ExtensionMethods;

namespace ExtensionMethodTestProject
{
    public class ExtensionMentodTestClass
    {
        [Fact]
        public void Should_Return_The_Amount_With_Currency()
        {
            string inputAmount = "78";
            string amount = inputAmount.ToCurrency();

            Assert.Equal("$78", amount);
        }

        [Theory]
        [InlineData("")]
        public void Empty_Input_ThrowsArgumentNullException(string amount)
        {
            Assert.Throws<ArgumentNullException>(() => amount.ToCurrency());
        }

        [Theory]
        [InlineData("abs")]
        [InlineData("5ds4")]
        [InlineData("b33")]
        public void Wrong_Input_ThrowsArgumentException(string amount)
        {
            Assert.Throws<ArgumentException>(() => amount.ToCurrency());
        }
    }
}