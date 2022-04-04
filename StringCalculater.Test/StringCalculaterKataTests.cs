using Xunit;
namespace StringCalculator.Core.Test
{
    public class StringCalaculaterKataTests
    {
        StringCalculator stringCalculater;
        public StringCalaculaterKataTests()
        {
             stringCalculater = new StringCalculator();

        }
        [Fact]
        public void EmptyStringArugmentForAdd()
        {
            int result = stringCalculater.add("");
            Assert.Equal(0, result);

        }
        [Fact]
        public void OneStringArugmentForAdd()
        {
            int result = stringCalculater.add("12");
            Assert.Equal(12, result);

        }
        [Fact]
        public void TwoStringArugmentForAdd()
        {
            int result = stringCalculater.add("2,4");
            Assert.Equal(6, result);

        }
        [Theory]
        [InlineData("2,4,1",7)]
        [InlineData("2,4,1,1",8)]
        [InlineData("2,4,1,1,1",9)]
        public void ManyStringArugmentForAdd(string InputString , int expectedAnswer )
        {
            int result = stringCalculater.add(InputString);
            Assert.Equal(expectedAnswer, result);

        }
        [Fact]
        public void handleNewLineDelimeter()
        {
            int result = stringCalculater.add("1\n,");
            Assert.Equal(6, result);

        }
    }
}