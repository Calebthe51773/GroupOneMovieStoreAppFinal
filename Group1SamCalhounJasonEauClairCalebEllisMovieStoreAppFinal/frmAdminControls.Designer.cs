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
            SuspendLayout();
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.Location = new Point(12, 30);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(75, 38);
            btnAddAdmin.TabIndex = 0;
            btnAddAdmin.Text = "Add Admin";
            btnAddAdmin.UseVisualStyleBackColor = true;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // btnRemoveAdmin
            // 
            btnRemoveAdmin.Location = new Point(12, 74);
            btnRemoveAdmin.Name = "btnRemoveAdmin";
            btnRemoveAdmin.Size = new Size(75, 38);
            btnRemoveAdmin.TabIndex = 1;
            btnRemoveAdmin.Text = "Remove Admin";
            btnRemoveAdmin.UseVisualStyleBackColor = true;
            btnRemoveAdmin.Click += btnRemoveAdmin_Click;
            // 
            // btnAddTitle
            // 
            btnAddTitle.Location = new Point(12, 145);
            btnAddTitle.Name = "btnAddTitle";
            btnAddTitle.Size = new Size(75, 23);
            btnAddTitle.TabIndex = 2;
            btnAddTitle.Text = "Add Title";
            btnAddTitle.UseVisualStyleBackColor = true;
            btnAddTitle.Click += btnAddTitle_Click;
            // 
            // btnRemoveTitle
            // 
            btnRemoveTitle.Location = new Point(12, 174);
            btnRemoveTitle.Name = "btnRemoveTitle";
            btnRemoveTitle.Size = new Size(75, 38);
            btnRemoveTitle.TabIndex = 3;
            btnRemoveTitle.Text = "Remove Title";
            btnRemoveTitle.UseVisualStyleBackColor = true;
            btnRemoveTitle.Click += btnRemoveTitle_Click;
            // 
            // lstAdmins
            // 
            lstAdmins.FormattingEnabled = true;
            lstAdmins.ItemHeight = 15;
            lstAdmins.Location = new Point(107, 30);
            lstAdmins.Name = "lstAdmins";
            lstAdmins.Size = new Size(323, 94);
            lstAdmins.TabIndex = 4;
            // 
            // lstMovieTitles
            // 
            lstMovieTitles.FormattingEnabled = true;
            lstMovieTitles.ItemHeight = 15;
            lstMovieTitles.Location = new Point(107, 145);
            lstMovieTitles.Name = "lstMovieTitles";
            lstMovieTitles.Size = new Size(323, 124);
            lstMovieTitles.TabIndex = 5;
            // 
            // btnReturnStore
            // 
            btnReturnStore.Location = new Point(162, 404);
            btnReturnStore.Name = "btnReturnStore";
            btnReturnStore.Size = new Size(94, 23);
            btnReturnStore.TabIndex = 6;
            btnReturnStore.Text = "Return to Store";
            btnReturnStore.UseVisualStyleBackColor = true;
            btnReturnStore.Click += this.btnReturnStore_Click;
            // 
            // lstOverdue
            // 
            lstOverdue.FormattingEnabled = true;
            lstOverdue.ItemHeight = 15;
            lstOverdue.Location = new Point(12, 304);
            lstOverdue.Name = "lstOverdue";
            lstOverdue.Size = new Size(418, 94);
            lstOverdue.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 12);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 8;
            label1.Text = "Administrators:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 127);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 9;
            label2.Text = "Title Library:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 286);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 10;
            label3.Text = "Overdue Rentors: ";
            // 
            // frmAdminControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnReturnStore;
            ClientSize = new Size(442, 438);
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
    }
}