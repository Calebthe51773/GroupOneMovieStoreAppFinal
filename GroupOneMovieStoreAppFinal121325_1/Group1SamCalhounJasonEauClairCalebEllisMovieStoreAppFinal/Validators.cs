namespace GroupOneMovieStoreAppFinal
{
    public static class Validators
    {
        public static bool IsNotEmpty(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }
    }
}
