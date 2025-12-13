using Microsoft.VisualBasic.ApplicationServices;
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
            _currentUser = currentUser;
            Load += frmRentalStore_Load;
        }

        private void frmRentalStore_Load(object sender, EventArgs e)
        {
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
            txtResults.Text = $"Checked out to {txtFirstName.Text} {txtLastName.Text}";
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            txtResults.Text = "Movie checked in.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
