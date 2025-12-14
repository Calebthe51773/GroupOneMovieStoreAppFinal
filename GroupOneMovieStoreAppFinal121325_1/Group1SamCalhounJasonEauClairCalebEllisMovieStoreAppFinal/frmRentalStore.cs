using System;
using System.Linq;
using System.Windows.Forms;

namespace GroupOneMovieStoreAppFinal
{
    /// <summary>
    /// Main rental store form used to check movies in and out.
    /// Handles movie selection, customer validation, and admin access.
    /// </summary>
    public partial class frmRentalStore : Form
    {
        /// <summary>
        /// Currently logged-in user.
        /// </summary>
        private User _currentUser;

        /// <summary>
        /// Currently selected movie from the library.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Initializes the rental store form and sets the current user.
        /// </summary>
        /// <param name="currentUser">The user currently logged into the system.</param>
        public frmRentalStore(User currentUser)
        {
            InitializeComponent(GetTxtResults());
            _currentUser = currentUser;

            Load += frmRentalStore_Load;
            cbxTitleLibrary.SelectedIndexChanged += cbxTitleLibrary_SelectedIndexChanged;
        }

        /// <summary>
        /// Loads users and movies when the form opens.
        /// Enables admin controls if the user has admin privileges.
        /// </summary>
        private void frmRentalStore_Load(object sender, EventArgs e)
        {
            AdminDB.LoadUsers();
            MovieLibraryDB.LoadMovies();
            RefreshMovieComboBox();

            btnAdminControls.Enabled = _currentUser != null && _currentUser.IsAdmin;
        }

        /// <summary>
        /// Refreshes the movie combo box to show only movies
        /// that are not currently checked out.
        /// </summary>
        private void RefreshMovieComboBox()
        {
            cbxTitleLibrary.DataSource = MovieLibraryDB.Movies
                .Where(m => !m.IsCheckedOut)
                .ToList();
            cbxTitleLibrary.DisplayMember = "Title";
            cbxTitleLibrary.SelectedIndex = -1;
        }

        /// <summary>
        /// Updates the current movie when the combo box selection changes.
        /// </summary>
        private void cbxTitleLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = cbxTitleLibrary.SelectedItem as Movie;
        }

        /// <summary>
        /// Opens the admin control panel if the user has admin privileges.
        /// </summary>
        private void btnAdminControls_Click(object sender, EventArgs e)
        {
            if (_currentUser == null || !_currentUser.IsAdmin)
            {
                MessageBox.Show("Admin access required.");
                return;
            }

            new frmAdminControls().ShowDialog();
        }

        /// <summary>
        /// Checks out the selected movie after validating customer input.
        /// Assigns a 7-day due date and updates the movie database.
        /// </summary>
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            if (_currentMovie == null)
            {
                MessageBox.Show("Please select a movie to check out.");
                return;
            }

            if (!Validators.IsNotEmpty(txtFirstName.Text) ||
                !Validators.IsNotEmpty(txtLastName.Text) ||
                !Validators.IsNotEmpty(txtContactInfo.Text))
            {
                MessageBox.Show("All customer fields are required.");
                return;
            }

            // Check out movie for 7 days
            _currentMovie.CheckOut(7);
            MovieLibraryDB.SaveMovies();

            txtResults.Text =
                $"User: {_currentUser.Username}\r\n" +
                $"Customer: {txtFirstName.Text} {txtLastName.Text}\r\n" +
                $"Contact: {txtContactInfo.Text}\r\n" +
                $"Checked Out: {_currentMovie.Title} (Due: {_currentMovie.DueDate?.ToShortDateString()})";

            RefreshMovieComboBox();
        }

        /// <summary>
        /// Checks in the currently selected movie and updates the database.
        /// </summary>
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (_currentMovie == null)
            {
                MessageBox.Show("Please select a movie to check in.");
                return;
            }

            _currentMovie.CheckIn();
            MovieLibraryDB.SaveMovies();

            txtResults.Text = $"Movie checked in: {_currentMovie.Title}";
            RefreshMovieComboBox();
        }

        /// <summary>
        /// Closes the rental store form.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            // Application.Exit(); // Use if this is the main form
        }
    }
}
