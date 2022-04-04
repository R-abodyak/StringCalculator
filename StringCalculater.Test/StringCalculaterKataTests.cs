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
    }
}