namespace GroupOneMovieStoreAppFinal
{
    partial class frmAdminControls
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddAdmin = new Button();
            btnRemoveAdmin = new Button();
            btnAddTitle = new Button();
            btnRemoveTitle = new Button();
            lstAdmins = new ListBox();
            lstMovieTitles = new ListBox();
            btnReturnStore = new Button();
            lstOverdue = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNewAdmin = new TextBox();
            txtNewTitle = new TextBox();
            SuspendLayout();
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.Location = new Point(14, 40);
            btnAddAdmin.Margin = new Padding(3, 4, 3, 4);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(86, 51);
            btnAddAdmin.TabIndex = 0;
            btnAddAdmin.Text = "Add Admin";
            btnAddAdmin.UseVisualStyleBackColor = true;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // btnRemoveAdmin
            // 
            btnRemoveAdmin.Location = new Point(14, 99);
            btnRemoveAdmin.Margin = new Padding(3, 4, 3, 4);
            btnRemoveAdmin.Name = "btnRemoveAdmin";
            btnRemoveAdmin.Size = new Size(86, 51);
            btnRemoveAdmin.TabIndex = 1;
            btnRemoveAdmin.Text = "Remove Admin";
            btnRemoveAdmin.UseVisualStyleBackColor = true;
            btnRemoveAdmin.Click += btnRemoveAdmin_Click;
            // 
            // btnAddTitle
            // 
            btnAddTitle.Location = new Point(14, 252);
            btnAddTitle.Margin = new Padding(3, 4, 3, 4);
            btnAddTitle.Name = "btnAddTitle";
            btnAddTitle.Size = new Size(86, 31);
            btnAddTitle.TabIndex = 2;
            btnAddTitle.Text = "Add Title";
            btnAddTitle.UseVisualStyleBackColor = true;
            btnAddTitle.Click += btnAddTitle_Click;
            // 
            // btnRemoveTitle
            // 
            btnRemoveTitle.Location = new Point(14, 291);
            btnRemoveTitle.Margin = new Padding(3, 4, 3, 4);
            btnRemoveTitle.Name = "btnRemoveTitle";
            btnRemoveTitle.Size = new Size(86, 51);
            btnRemoveTitle.TabIndex = 3;
            btnRemoveTitle.Text = "Remove Title";
            btnRemoveTitle.UseVisualStyleBackColor = true;
            btnRemoveTitle.Click += btnRemoveTitle_Click;
            // 
            // lstAdmins
            // 
            lstAdmins.FormattingEnabled = true;
            lstAdmins.Location = new Point(122, 99);
            lstAdmins.Margin = new Padding(3, 4, 3, 4);
            lstAdmins.Name = "lstAdmins";
            lstAdmins.Size = new Size(369, 84);
            lstAdmins.TabIndex = 4;
            lstAdmins.SelectedIndexChanged += lstAdmins_SelectedIndexChanged;
            // 
            // lstMovieTitles
            // 
            lstMovieTitles.FormattingEnabled = true;
            lstMovieTitles.Location = new Point(122, 317);
            lstMovieTitles.Margin = new Padding(3, 4, 3, 4);
            lstMovieTitles.Name = "lstMovieTitles";
            lstMovieTitles.Size = new Size(369, 104);
            lstMovieTitles.TabIndex = 5;
            lstMovieTitles.SelectedIndexChanged += lstMovieTitles_SelectedIndexChanged;
            // 
            // btnReturnStore
            // 
            btnReturnStore.Location = new Point(185, 633);
            btnReturnStore.Margin = new Padding(3, 4, 3, 4);
            btnReturnStore.Name = "btnReturnStore";
            btnReturnStore.Size = new Size(107, 31);
            btnReturnStore.TabIndex = 6;
            btnReturnStore.Text = "Return to Store";
            btnReturnStore.UseVisualStyleBackColor = true;
            btnReturnStore.Click += btnReturnStore_Click;
            // 
            // lstOverdue
            // 
            lstOverdue.FormattingEnabled = true;
            lstOverdue.Location = new Point(14, 499);
            lstOverdue.Margin = new Padding(3, 4, 3, 4);
            lstOverdue.Name = "lstOverdue";
            lstOverdue.Size = new Size(477, 124);
            lstOverdue.TabIndex = 7;
            lstOverdue.SelectedIndexChanged += lstOverdue_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 19);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 8;
            label1.Text = "Administrators:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 228);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 9;
            label2.Text = "Title Library:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 475);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 10;
            label3.Text = "Overdue Rentors: ";
            // 
            // txtNewAdmin
            // 
            txtNewAdmin.Location = new Point(129, 48);
            txtNewAdmin.Name = "txtNewAdmin";
            txtNewAdmin.Size = new Size(321, 27);
            txtNewAdmin.TabIndex = 11;
            // 
            // txtNewTitle
            // 
            txtNewTitle.Location = new Point(132, 263);
            txtNewTitle.Name = "txtNewTitle";
            txtNewTitle.Size = new Size(318, 27);
            txtNewTitle.TabIndex = 12;
            // 
            // frmAdminControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnReturnStore;
            ClientSize = new Size(587, 673);
            Controls.Add(txtNewTitle);
            Controls.Add(txtNewAdmin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstOverdue);
            Controls.Add(btnReturnStore);
            Controls.Add(lstMovieTitles);
            Controls.Add(lstAdmins);
            Controls.Add(btnRemoveTitle);
            Controls.Add(btnAddTitle);
            Controls.Add(btnRemoveAdmin);
            Controls.Add(btnAddAdmin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAdminControls";
            Text = "Administrative Controls";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddAdmin;
        private Button btnRemoveAdmin;
        private Button btnAddTitle;
        private Button btnRemoveTitle;
        private ListBox lstAdmins;
        private ListBox lstMovieTitles;
        private Button btnReturnStore;
        private ListBox lstOverdue;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNewAdmin;
        private TextBox txtNewTitle;
    }
}