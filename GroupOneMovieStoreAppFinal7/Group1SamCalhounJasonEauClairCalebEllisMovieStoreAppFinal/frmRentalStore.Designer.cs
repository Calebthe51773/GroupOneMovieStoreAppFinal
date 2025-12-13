namespace GroupOneMovieStoreAppFinal
{
    partial class frmRentalStore
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            cbxTitleLibrary = new ComboBox();
            btnAdminControls = new Button();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            btnExit = new Button();
            txtResults = new TextBox();
            label3 = new Label();
            txtContactInfo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "First name: ";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(163, 12);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 23);
            txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Last name: ";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(163, 41);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 23);
            txtLastName.TabIndex = 3;
            // 
            // cbxTitleLibrary
            // 
            cbxTitleLibrary.FormattingEnabled = true;
            cbxTitleLibrary.Location = new Point(148, 102);
            cbxTitleLibrary.Name = "cbxTitleLibrary";
            cbxTitleLibrary.Size = new Size(165, 23);
            cbxTitleLibrary.TabIndex = 4;
            // 
            // btnAdminControls
            // 
            btnAdminControls.Location = new Point(12, 102);
            btnAdminControls.Name = "btnAdminControls";
            btnAdminControls.Size = new Size(111, 23);
            btnAdminControls.TabIndex = 5;
            btnAdminControls.Text = "&Admin Controls";
            btnAdminControls.UseVisualStyleBackColor = true;
            btnAdminControls.Click += btnAdminControls_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(12, 214);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(75, 23);
            btnCheckOut.TabIndex = 6;
            btnCheckOut.Text = "Check &Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(93, 214);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(75, 23);
            btnCheckIn.TabIndex = 7;
            btnCheckIn.Text = "Check &In";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(238, 214);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtResults
            // 
            txtResults.BackColor = SystemColors.Control;
            txtResults.Location = new Point(47, 142);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.Size = new Size(266, 66);
            txtResults.TabIndex = 9;
            txtResults.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 10;
            label3.Text = "Contact Info:";
            // 
            // txtContactInfo
            // 
            txtContactInfo.Location = new Point(163, 73);
            txtContactInfo.Name = "txtContactInfo";
            txtContactInfo.Size = new Size(150, 23);
            txtContactInfo.TabIndex = 11;
            // 
            // frmRentalStore
            // 
            AcceptButton = btnCheckOut;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(325, 249);
            Controls.Add(txtContactInfo);
            Controls.Add(label3);
            Controls.Add(txtResults);
            Controls.Add(btnExit);
            Controls.Add(btnCheckIn);
            Controls.Add(btnCheckOut);
            Controls.Add(btnAdminControls);
            Controls.Add(cbxTitleLibrary);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "frmRentalStore";
            Text = "Sam, Jason, and Caleb's Movie Shack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private ComboBox cbxTitleLibrary;
        private Button btnAdminControls;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private Button btnExit;
        private TextBox txtResults;
        private Label label3;
        private TextBox txtContactInfo;
    }
}
