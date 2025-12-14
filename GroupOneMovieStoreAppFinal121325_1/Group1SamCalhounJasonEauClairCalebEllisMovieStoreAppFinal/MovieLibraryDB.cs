using System.Collections.Generic;

namespace GroupOneMovieStoreAppFinal
{
    /// <summary>
    /// Provides in-memory storage and management for the movie library.
    /// This class is responsible for loading and saving movie data.
    /// </summary>
    public static class MovieLibraryDB
    {
        /// <summary>
        /// Gets or sets the list of movies available in the library.
        /// </summary>
        public static List<Movie> Movies { get; set; } = new List<Movie>();

        /// <summary>
        /// Loads the movie list into memory.
        /// If the movie list is empty, default movies are added.
        /// </summary>
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

        /// <summary>
        /// Would save the added movie list but we did not do this for this project.
        /// </summary>
        public static void SaveMovies()
        {
 
        }
    }
}
