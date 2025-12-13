using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupOneMovieStoreAppFinal
{
    public partial class frmAdminControls : Form
    {
        public frmAdminControls()
        {
            InitializeComponent();
        }
        private List<Users> users;
        private List<Titles> library;
        private void frmAdminControls_Load(object sender, EventArgs e) 
        {
            users = UserDB.GetUsers();
            library = MovieLibraryDB.GetTitles();
            RefreshListBoxes();

        }
        private void RefreshListBoxes()
        {
            lstAdmins.Items.Clear();
            foreach (Users user in users)
                if (user.IsAdmin == false)
                {
                    {
                        lstAdmins.Items.Add(user.GetUserInfo());
                    }
                }
            lstMovieTitles.Items.Clear();
            foreach (Titles title in library)
            {
                lstMovieTitles.Items.Add(title.GetTitleText());
            }
            lstOverdue.Items.Clear();
            foreach (Users user in users)
                if (user.MovieCheckedOut.CheckDate.AddMonths(1) > DateTime.Today)
                {
                    {
                        lstOverdue.Items.Add(user.GetUserInfo());
                    }
                }
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            frmNewAdmin newAdminForm = new frmNewAdmin();
            Users user = newAdminForm.AssignNewAdmin();
            if (user != null)
            {

            }
        }

        private void btnRemoveAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTitle_Click(object sender, EventArgs e)
        {
            frmNewTitle newTitleForm = new frmNewTitle();
            Titles title = newTitleForm.AddTitle();
            if (title != null)
            {
                library.Add(title);
                MovieLibraryDB.SaveTitles(library);
                RefreshListBoxes();
            }
        }

        private void btnRemoveTitle_Click(object sender, EventArgs e)
        {
            int i = lstMovieTitles.SelectedIndex;
            if (i != -1)
            {
                Titles title = library[i];
                string confirm = $"Are you sure you want to delete {title.TitleName}?";
                DialogResult button = MessageBox.Show(confirm, "Confirm Delete", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    library.Remove(title);
                    MovieLibraryDB.SaveTitles(library);
                    RefreshListBoxes();
                }
            }
        }

        private void btnReturnStore_Click(object sender, EventArgs e) 
        {
            this.Close();
        }
    }
}
