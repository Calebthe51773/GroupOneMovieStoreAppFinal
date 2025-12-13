namespace GroupOneMovieStoreAppFinal
{
    public class Movie
    {
        public string Title { get; set; }
        public bool IsCheckedOut { get; set; }

        public Movie() { }

        public Movie(string title)
        {
            Title = title;
            IsCheckedOut = false;
        }

        public override string ToString() => Title;
    }
}
