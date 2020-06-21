namespace BasicGuards.Tests.Extensions.GuarExtensionsUnitTests
{
    using System;
    using BasicGuards.Extensions;
    using Xunit;

    /// <summary>
    /// Tests the ThrowIfNullOrWhitespace method in the GuardExtensions file.
    /// </summary>
    public partial class GuardExtensionsTests
    {
        [Fact]
        public void Given_NullInputParameter_When_CallThrowIfNull_Should_ThrowAnArgumentNullException()
        {
            // Arrange
            var input = default(int?);

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => input.ThrowIfNull(nameof(input)));
        }

        [Fact]
        public void Given_CustomExceptionMessage_When_CallThrowIfNull_Should_AssignTheMessageToTheException()
        {
            // Arrange
            var message = "A custom error message";
            var input = default(int?);

            // Act
            var exception = Record.Exception(() => input.ThrowIfNull(nameof(input), message));

            // Assert
            Assert.Contains(message, exception.Message, StringComparison.InvariantCulture);
        }
    }
}
