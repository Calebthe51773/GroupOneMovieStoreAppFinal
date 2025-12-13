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
    public partial class frmNewTitle : Form
    {
        public frmNewTitle()
        {
            InitializeComponent();
        }
        private Titles title;
        public Titles AddTitle()
        {
            this.ShowDialog();
            return title;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string errmsg = "";
            errmsg += Validators.IsPresent(txtTitleName.Text, nameof(Titles.TitleName));
            if (errmsg == "")
            {
                title = new Titles()
                {
                    TitleName = txtTitleName.Text
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
