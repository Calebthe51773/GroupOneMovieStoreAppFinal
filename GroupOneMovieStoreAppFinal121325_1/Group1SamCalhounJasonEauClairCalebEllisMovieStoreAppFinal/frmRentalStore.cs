using System;
using System.Linq;
using System.Windows.Forms;

namespace GroupOneMovieStoreAppFinal
{
    public partial class frmRentalStore : Form
    {
        private User _currentUser;
        private Movie _currentMovie;

        public frmRentalStore(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;

            Load += frmRentalStore_Load;
            cbxTitleLibrary.SelectedIndexChanged += cbxTitleLibrary_SelectedIndexChanged;
        }

        private void frmRentalStore_Load(object sender, EventArgs e)
        {
            AdminDB.LoadUsers();
            MovieLibraryDB.LoadMovies();
            RefreshMovieComboBox();

            btnAdminControls.Enabled = _currentUser != null && _currentUser.IsAdmin;
        }

        private void RefreshMovieComboBox()
        {
            cbxTitleLibrary.DataSource = MovieLibraryDB.Movies
                .Where(m => !m.IsCheckedOut)
                .ToList();
            cbxTitleLibrary.DisplayMember = "Title";
            cbxTitleLibrary.SelectedIndex = -1;
        }

        private void cbxTitleLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = cbxTitleLibrary.SelectedItem as Movie;
        }

        private void btnAdminControls_Click(object sender, EventArgs e)
        {
            if (_currentUser == null || !_currentUser.IsAdmin)
            {
                MessageBox.Show("Admin access required.");
                return;
            }
            new frmAdminControls().ShowDialog();
        }

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

            // Check out for 7 days
            _currentMovie.CheckOut(7);
            MovieLibraryDB.SaveMovies();

            txtResults.Text =
                $"User: {_currentUser.Username}\r\n" +
                $"Customer: {txtFirstName.Text} {txtLastName.Text}\r\n" +
                $"Contact: {txtContactInfo.Text}\r\n" +
                $"Checked Out: {_currentMovie.Title} (Due: {_currentMovie.DueDate?.ToShortDateString()})";

            RefreshMovieComboBox();
        }

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();

            // Optionally, exit the entire application if this is the main form
            // Application.Exit();
        }


    }
}

