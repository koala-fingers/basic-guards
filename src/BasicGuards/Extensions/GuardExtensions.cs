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
                    : new System.ArgumentException(propertyName, message);

                throw ex;
            }

            return stringValue;
        }

        /// <summary>
        /// Throws an argument null exception if the provided input is null.
        /// </summary>
        /// <typeparam name="T">Input type.</typeparam>
        /// <param name="input">Input value to validate.</param>
        /// <param name="propertyName">Name of the validating parameter.</param>
        /// <param name="message">Options custom exception message in case of error.</param>
        /// <returns>The input value if not null.</returns>
        public static T ThrowIfNull<T>(this T input, string propertyName, string message = null)
        {
            if (input == null)
            {
                var ex = message is null
                    ? new System.ArgumentNullException(propertyName)
                    : new System.ArgumentNullException(propertyName, message);

                throw ex;
            }

            return input;
        }
    }
}
