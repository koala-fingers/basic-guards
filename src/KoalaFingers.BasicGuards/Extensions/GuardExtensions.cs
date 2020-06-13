namespace KoalaFingers.BasicGuards.Extensions
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
        /// <returns>The string value if valid, otherwise throws an argument exception.</returns>
        public static string ThrowIfNullOrWhitespace(this string stringValue, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(stringValue) || string.IsNullOrEmpty(stringValue))
            {
                throw new System.ArgumentException(propertyName);
            }

            return stringValue;
        }
    }
}
