namespace GroupOneMovieStoreAppFinal
{
    public static class Validators
    {
        public static bool IsNotEmpty(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
