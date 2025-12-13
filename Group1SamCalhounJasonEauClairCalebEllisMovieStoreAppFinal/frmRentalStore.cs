namespace GroupOneMovieStoreAppFinal
{
    public partial class frmRentalStore : Form
    {
        public frmRentalStore()
        {
            InitializeComponent();
        }
        
        private List <Titles> library;
        private List<Users> users;
        private void frmRentalStore_Load(object sender, EventArgs e)
        {
            library = MovieLibraryDB.GetLibrary();
            RefreshLibraryComboBox();
        }

        private void RefreshLibraryComboBox()
        {
            cbxTitleLibrary.Items.Clear();
            foreach (Titles title in library)
                if (title.CheckedOut == false)
                {
                    {
                        cbxTitleLibrary.Items.Add(title.GetTitleText());
                    }
                }
        }
        public bool SearchUsers()
        {
            bool foundUser = false;
            foreach (Users user in users)
                if (user.FirstName == txtFirstName.Text && user.LastName == txtLastName.Text && user.ContactInfo == txtContactInfo.Text)
                {
                    foundUser = true;
                    break;
                }
            return foundUser;
        }
        private void btnAdminControls_Click(object sender, EventArgs e)
        {
            string errmsg = "";
            errmsg += Validators.IsPresent(txtFirstName.Text, nameof(Users.FirstName));
            errmsg += Validators.IsPresent(txtLastName.Text, nameof(Users.LastName));
            errmsg += Validators.IsValidContactInfo(txtContactInfo.Text, nameof(Users.ContactInfo));
            if (errmsg == "")
            {
                
            }
            else
            {
                MessageBox.Show(errmsg, "Entry Error");
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            string errmsg = "";
            errmsg += Validators.IsPresent(txtFirstName.Text, nameof(Users.FirstName));
            errmsg += Validators.IsPresent(txtLastName.Text, nameof(Users.LastName));
            errmsg += Validators.IsValidContactInfo(txtContactInfo.Text, nameof(Users.ContactInfo));
            if (errmsg == "")
            {

            }
            else
            {
                MessageBox.Show(errmsg, "Entry Error");
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string errmsg = "";
            errmsg += Validators.IsPresent(txtFirstName.Text, nameof(Users.FirstName));
            errmsg += Validators.IsPresent(txtLastName.Text, nameof(Users.LastName));
            errmsg += Validators.IsValidContactInfo(txtContactInfo.Text, nameof(Users.ContactInfo));
            if (errmsg == "")
            {

            }
            else
            {
                MessageBox.Show(errmsg, "Entry Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
