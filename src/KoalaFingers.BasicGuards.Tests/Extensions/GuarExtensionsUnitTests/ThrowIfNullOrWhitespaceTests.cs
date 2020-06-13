namespace KoalaFingers.BasicGuards.Tests.Extensions.GuarExtensionsUnitTests
{
    using System;
    using KoalaFingers.BasicGuards.Extensions;
    using Xunit;

    /// <summary>
    /// Tests the ThrowIfNullOrWhitespace method in the GuardExtensions file.
    /// </summary>
    public partial class GuardExtensionsTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("   ")]
        public void Given_InvalidStringValue_When_CallIsNullOrWhitespace_Should_ThrowAnArgumentException(string input)
        {
            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => input.ThrowIfNullOrWhitespace(nameof(input)));
        }

        [Theory]
        [InlineData("Sample value")]
        [InlineData("Hello world")]
        [InlineData("Input text")]
        public void Given_ValidStringValue_When_CallIsNullOrWhitespace_Should_ReturnTheInputValue(string input)
        {
            // Act
            var result = input.ThrowIfNullOrWhitespace(nameof(input));

            // Assert
            Assert.Same(input, result);
        }
    }
}
