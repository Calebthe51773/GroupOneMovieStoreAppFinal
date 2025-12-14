using System;
using System.Linq;
using System.Windows.Forms;

namespace GroupOneMovieStoreAppFinal
{
    /// <summary>
    /// Admin control form used to manage administrators, movie titles,
    /// and view overdue movies in the system.
    /// </summary>
    public partial class frmAdminControls : Form
    {
        /// <summary>
        /// Initializes the Admin Controls form and registers the load event.
        /// </summary>
        public frmAdminControls()
        {
            InitializeComponent();
            Load += FrmAdminControls_Load;
        }

        /// <summary>
        /// Loads all admin, movie, and overdue lists when the form opens.
        /// </summary>
        private void FrmAdminControls_Load(object sender, EventArgs e)
        {
            RefreshAdminList();
            RefreshMovieList();
            RefreshOverdueList();
        }

        // -----------------------------
        // Refresh lists
        // -----------------------------

        /// <summary>
        /// Refreshes the list of administrator users.
        /// Displays only users with admin privileges.
        /// </summary>
        private void RefreshAdminList()
        {
            lstAdmins.DataSource = null;
            lstAdmins.DataSource = AdminDB.Users.Where(u => u.IsAdmin).ToList();
            lstAdmins.DisplayMember = "Username";
        }

        /// <summary>
        /// Refreshes the list of all movie titles in the library.
        /// </summary>
        private void RefreshMovieList()
        {
            lstMovieTitles.DataSource = null;
            lstMovieTitles.DataSource = MovieLibraryDB.Movies;
            lstMovieTitles.DisplayMember = "Title";
        }

        /// <summary>
        /// Refreshes the list of overdue movies.
        /// Displays movies that are checked out and past their due date.
        /// </summary>
        private void RefreshOverdueList()
        {
            lstOverdue.DataSource = null;
            lstOverdue.DataSource = MovieLibraryDB.Movies
                .Where(m => m.IsOverdue)
                .ToList();
            lstOverdue.DisplayMember = "Title";
        }

        // -----------------------------
        // Admin buttons
        // -----------------------------

        /// <summary>
        /// Adds a new administrator user to the system.
        /// </summary>
        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            string username = txtNewAdmin.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Enter a username.");
                return;
            }

            if (AdminDB.Users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("User already exists.");
                return;
            }

            AdminDB.Users.Add(new User(username, true));
            AdminDB.SaveUsers();
            RefreshAdminList();
            txtNewAdmin.Clear();
        }

        /// <summary>
        /// Removes the selected administrator from the system.
        /// </summary>
        private void btnRemoveAdmin_Click(object sender, EventArgs e)
        {
            User selected = lstAdmins.SelectedItem as User;
            if (selected == null)
            {
                MessageBox.Show("Select an admin to remove.");
                return;
            }

            AdminDB.Users.Remove(selected);
            AdminDB.SaveUsers();
            RefreshAdminList();
        }

        // -----------------------------
        // Movie title buttons
        // -----------------------------

        /// <summary>
        /// Adds a new movie title to the movie library.
        /// </summary>
        private void btnAddTitle_Click(object sender, EventArgs e)
        {
            string title = txtNewTitle.Text.Trim();
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Enter a movie title.");
                return;
            }

            if (MovieLibraryDB.Movies.Any(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Movie already exists.");
                return;
            }

            MovieLibraryDB.Movies.Add(new Movie(title));
            MovieLibraryDB.SaveMovies();
            RefreshMovieList();
            txtNewTitle.Clear();
        }

        /// <summary>
        /// Removes the selected movie title from the library.
        /// </summary>
        private void btnRemoveTitle_Click(object sender, EventArgs e)
        {
            Movie selected = lstMovieTitles.SelectedItem as Movie;
            if (selected == null)
            {
                MessageBox.Show("Select a movie to remove.");
                return;
            }

            MovieLibraryDB.Movies.Remove(selected);
            MovieLibraryDB.SaveMovies();
            RefreshMovieList();
        }

        // -----------------------------
        // Return to store
        // -----------------------------

        /// <summary>
        /// Closes the Admin Controls form and returns to the rental store.
        /// </summary>
        private void btnReturnStore_Click(object sender, EventArgs e)
        {
            Close();
        }

        // -----------------------------
        // Optional: handle selection changes
        // -----------------------------

        /// <summary>
        /// Handles changes in the selected admin user.
        /// </summary>
        private void lstAdmins_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: enable/disable buttons or show admin details
        }

        /// <summary>
        /// Handles changes in the selected movie title.
        /// </summary>
        private void lstMovieTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: display movie details
        }

        /// <summary>
        /// Handles changes in the selected overdue movie.
        /// </summary>
        private void lstOverdue_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: display overdue information
        }
    }
}
