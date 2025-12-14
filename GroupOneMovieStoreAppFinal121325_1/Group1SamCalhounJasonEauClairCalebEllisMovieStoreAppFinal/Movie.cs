using System;

namespace GroupOneMovieStoreAppFinal
{
    /// <summary>
    /// Represents a movie in the rental store.
    /// Tracks checkout status, due date, and overdue state.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Gets or sets the title of the movie.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets a value indicating whether the movie is currently checked out.
        /// </summary>
        public bool IsCheckedOut { get; private set; }

        /// <summary>
        /// Gets the due date for the movie.
        /// Returns null if the movie is not checked out.
        /// </summary>
        public DateTime? DueDate { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the movie is overdue.
        /// </summary>
        public bool IsOverdue =>
            IsCheckedOut && DueDate.HasValue && DateTime.Now > DueDate.Value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Movie"/> class.
        /// </summary>
        public Movie()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Movie"/> class
        /// with the specified title.
        /// </summary>
        /// <param name="title">The title of the movie.</param>
        public Movie(string title)
        {
            Title = title;
            IsCheckedOut = false;
            DueDate = null;
        }

        /// <summary>
        /// Checks out the movie for the specified number of days.
        /// </summary>
        /// <param name="days">Number of days until the movie is due.</param>
        public void CheckOut(int days = 7)
        {
            IsCheckedOut = true;
            DueDate = DateTime.Now.AddDays(days);
        }

        /// <summary>
        /// Checks the movie back in and clears its due date.
        /// </summary>
        public void CheckIn()
        {
            IsCheckedOut = false;
            DueDate = null;
        }

        /// <summary>
        /// Returns the movie title.
        /// </summary>
        /// <returns>The title of the movie.</returns>
        public override string ToString() => Title;
    }
}
