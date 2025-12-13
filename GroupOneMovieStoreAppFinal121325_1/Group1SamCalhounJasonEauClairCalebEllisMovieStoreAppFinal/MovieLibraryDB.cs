using System.Collections.Generic;

namespace GroupOneMovieStoreAppFinal
{
    public static class MovieLibraryDB
    {
        public static List<Movie> Movies { get; set; } = new List<Movie>();

        public static void LoadMovies()
        {
            if (Movies.Count == 0)
            {
                Movies.Add(new Movie("The Matrix"));
                Movies.Add(new Movie("Inception"));
                Movies.Add(new Movie("The Godfather"));
                Movies.Add(new Movie("Pulp Fiction"));
                Movies.Add(new Movie("Back to the Future"));
            }
        }

        public static void SaveMovies()
        {
            // In-memory demo, nothing to do. For real DB/file, save here.
        }
    }
}
