namespace BasicGuards.Extensions
{
    /// <summary>
    /// Guard clauses extensions.
    /// </summary>
    public static class GuardExtensions
    {
        /// <summary>
        /// Validates if the provided string value is not null or whitespace.
        /// </summary>
        /// <param name="stringValue">String value to validate.</param>
        /// <param name="propertyName">Name of the tested property.</param>
        /// <param name="message">Optional exception message.</param>
        /// <returns>The string value if valid, otherwise throws an argument exception.</returns>
        public static string ThrowIfNullOrWhitespace(this string stringValue, string propertyName, string message = null)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
            {
                var ex = message is null
                    ? new System.ArgumentException(propertyName)
                    : new System.ArgumentNullException(propertyName, message);

                throw ex;
            }

            return stringValue;
        }
    }
}
