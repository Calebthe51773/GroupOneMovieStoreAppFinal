using System;
using System.Linq;
using System.Windows.Forms;

namespace GroupOneMovieStoreAppFinal
{
    public partial class frmAdminControls : Form
    {
        public frmAdminControls()
        {
            InitializeComponent();
            Load += FrmAdminControls_Load;
        }

        private void FrmAdminControls_Load(object sender, EventArgs e)
        {
            RefreshAdminList();
            RefreshMovieList();
            RefreshOverdueList();
        }

        // -----------------------------
        // Refresh lists
        // -----------------------------
        private void RefreshAdminList()
        {
            lstAdmins.DataSource = null;
            lstAdmins.DataSource = AdminDB.Users.Where(u => u.IsAdmin).ToList();
            lstAdmins.DisplayMember = "Username";
        }

        private void RefreshMovieList()
        {
            lstMovieTitles.DataSource = null;
            lstMovieTitles.DataSource = MovieLibraryDB.Movies;
            lstMovieTitles.DisplayMember = "Title";
        }

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
        private void btnReturnStore_Click(object sender, EventArgs e)
        {
            Close();
        }

        // -----------------------------
        // Optional: handle selection changes
        // -----------------------------
        private void lstAdmins_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Can enable/disable remove button or display details if desired
        }

        private void lstMovieTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: show info about the movie
        }

        private void lstOverdue_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: show overdue details
        }
    }
}
