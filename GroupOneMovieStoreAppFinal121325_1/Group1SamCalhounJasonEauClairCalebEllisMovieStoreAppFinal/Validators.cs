namespace GroupOneMovieStoreAppFinal
{
    /// <summary>
    /// Provides helper methods for validating user input.
    /// </summary>
    public static class Validators
    {
        /// <summary>
        /// Determines whether the specified input string
        /// is not null, empty, or composed only of whitespace.
        /// </summary>
        /// <param name="input">The string value to validate.</param>
        /// <returns>
        /// True if the input contains non-whitespace characters;
        /// otherwise, false.
        /// </returns>
        public static bool IsNotEmpty(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }
    }
}
