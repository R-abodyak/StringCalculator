using System;
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
        [InlineData("2,4,1", 7)]
        [InlineData("2,4,1,1", 8)]
        [InlineData("2,4,1,1,1", 9)]
        public void ManyStringArugmentForAdd(string InputString, int expectedAnswer)
        {
            int result = stringCalculater.add(InputString);
            Assert.Equal(expectedAnswer, result);
        }
        [Fact]
        public void handleNewLineDelimeter()
        {
            int result = stringCalculater.add("1\n2,3");
            Assert.Equal(6, result);
        }
        [Theory]
        [InlineData("//;\n1;2", 3)]
        public void SupportAnyDelimeter(string input, int output)
        {
            int result = stringCalculater.add(input);
            Assert.Equal(output, result);
        }
        [Theory]
        [InlineData("-1,2,3", "negatives are not allowed :-1")]
        [InlineData("//;\n-1;2", "negatives are not allowed :-1")]
        public void NegativeNumberTest(string input, string output)
        {   //write testing that check throwing exception 
            Action act = () => stringCalculater.add(input);
            //assert
            // The exception that is thrown when one of the arguments provided to a method is not valid.
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            //The thrown exception can be used for even more detailed assertions.
            Assert.Equal(output, exception.Message);
        }
        [Theory]
        [InlineData("//;\n1000;2", 2)]
        [InlineData("//*\n5*1000", 5)]
        public void handleBigNumbers(string InputString, int expectedAnswer)
        {
            int result = stringCalculater.add(InputString);
            Assert.Equal(expectedAnswer, result);
        }
    }
}