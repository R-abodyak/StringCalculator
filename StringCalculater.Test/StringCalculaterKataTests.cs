using Xunit;
namespace StringCalculator.Core.Test
{
    public class StringCalaculaterKataTests
    {
        [Fact]
        public void EmptyStringArugmentForAdd()
        {
            var stringCalculater = new StringCalculator();
            int result = stringCalculater.add("");
            Assert.Equal(0, result);

        }
        [Fact]
        public void OneStringArugmentForAdd()
        {
            var stringCalculater = new StringCalculator();
            int result = stringCalculater.add("1");
            Assert.Equal(1, result);

        }
        [Fact]
        public void TwoStringArugmentForAdd()
        {
            var stringCalculater = new StringCalculator();
            int result = stringCalculater.add("1,4");
            Assert.Equal(5, result);

        }
    }
}