using System;
using System.Windows.Forms;

namespace GroupOneMovieStoreAppFinal
{
    public partial class frmRentalStore : Form
    {
        private User _currentUser;

        public frmRentalStore(User currentUser)
        {
            InitializeComponent();
            Load += frmRentalStore_Load;
            cbxTitleLibrary.SelectedIndexChanged += cbxTitleLibrary_SelectedIndexChanged;
        }

        private void frmRentalStore_Load(object sender, EventArgs e)
        {
            AdminDB.LoadUsers();

            cbxTitleLibrary.DataSource = AdminDB.Users;
            cbxTitleLibrary.DisplayMember = "Username";
            cbxTitleLibrary.SelectedIndex = -1;

            btnAdminControls.Enabled = false;
        }

        private void cbxTitleLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentUser = cbxTitleLibrary.SelectedItem as User;
            btnAdminControls.Enabled = _currentUser != null && _currentUser.IsAdmin;
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
            // VALIDATION
            if (_currentUser == null)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            if (!Validators.IsNotEmpty(txtFirstName.Text))
            {
                MessageBox.Show("First name is required.");
                txtFirstName.Focus();
                return;
            }

            if (!Validators.IsNotEmpty(txtLastName.Text))
            {
                MessageBox.Show("Last name is required.");
                txtLastName.Focus();
                return;
            }

            if (!Validators.IsNotEmpty(txtContactInfo.Text))
            {
                MessageBox.Show("Contact information is required.");
                txtContactInfo.Focus();
                return;
            }

            txtResults.Text =
                $"User: {_currentUser.Username}\r\n" +
                $"Customer: {txtFirstName.Text} {txtLastName.Text}\r\n" +
                $"Contact: {txtContactInfo.Text}";
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            txtResults.Text = "Movie checked in.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
