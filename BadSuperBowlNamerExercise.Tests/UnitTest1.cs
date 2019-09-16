using System;
using Xunit;

namespace BadSuperBowlNamerExercise.Tests
{
    public class NumberToRomanNumeralConverterTests
    {
        [Fact]
        public void Make5NumeralTest()
        {
            // Arrange
            int number = 5;
            var converter = new Converter();

            // Act
            var result = converter.ConvertNumberToNumeral(number);

            // Assert
            Assert.Equal("V", result);
            Console.WriteLine(result);
        }

        [Fact]
        public void Make6NumeralTest()
        {
            // Arrange
            int number = 6;
            var converter = new Converter();

            // Act
            var result = converter.ConvertNumberToNumeral(number);

            // Assert
            Assert.Equal("VI", result);
            Console.WriteLine(result);
        }

        [Fact]
        public void Make25NumeralTest()
        {
            // Arrange
            int number = 25;
            var converter = new Converter();

            // Act
            var result = converter.ConvertNumberToNumeral(number);

            // Assert
            Assert.Equal("XXV", result);
            Console.WriteLine(result);
        }

        [Fact]
        public void Make101NumeralTest()
        {
            // Arrange
            int number = 101;
            var converter = new Converter();

            // Act
            var result = converter.ConvertNumberToNumeral(number);

            // Assert
            Assert.Equal("CI", result);
            Console.WriteLine(result);
        }
    }
}
