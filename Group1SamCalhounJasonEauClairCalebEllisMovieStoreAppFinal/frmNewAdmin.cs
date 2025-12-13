using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupOneMovieStoreAppFinal
{
    public partial class frmNewAdmin : Form
    {
        public frmNewAdmin()
        {
            InitializeComponent();
        }
        private Users admin;
        public Users AssignNewAdmin()
        {
            this.ShowDialog();
            return admin;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string errmsg = "";
            errmsg += Validators.IsPresent(txtFirstName.Text, nameof(Users.FirstName));
            errmsg += Validators.IsPresent(txtLastName.Text, nameof(Users.LastName));
            errmsg += Validators.IsValidContactInfo(txtContactInfo.Text, nameof(Users.ContactInfo));
            if (errmsg == "")
            {
                admin = new Users()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    ContactInfo = txtContactInfo.Text,
                    IsAdmin = true
                };
                this.Close();
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
