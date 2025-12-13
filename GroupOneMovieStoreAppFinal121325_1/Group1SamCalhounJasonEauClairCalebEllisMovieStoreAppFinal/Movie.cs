using System;

namespace GroupOneMovieStoreAppFinal
{
    public class Movie
    {
        public string Title { get; set; }
        public bool IsCheckedOut { get; private set; }
        public DateTime? DueDate { get; private set; }   // null if not checked out
        public bool IsOverdue => IsCheckedOut && DueDate.HasValue && DateTime.Now > DueDate.Value;

        public Movie() { }

        public Movie(string title)
        {
            Title = title;
            IsCheckedOut = false;
            DueDate = null;
        }

        // Check out movie for a specified number of days
        public void CheckOut(int days = 7)
        {
            IsCheckedOut = true;
            DueDate = DateTime.Now.AddDays(days);
        }

        // Check in movie
        public void CheckIn()
        {
            IsCheckedOut = false;
            DueDate = null;
        }

        public override string ToString() => Title;
    }
}
