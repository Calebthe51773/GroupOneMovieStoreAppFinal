
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

        private TextBox GetTxtResults()
        {
            return txtResults;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(TextBox txtResults)
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
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "First name: ";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(186, 16);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(171, 27);
            txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 59);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Last name: ";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(186, 55);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(171, 27);
            txtLastName.TabIndex = 3;
            // 
            // cbxTitleLibrary
            // 
            cbxTitleLibrary.FormattingEnabled = true;
            cbxTitleLibrary.Location = new Point(169, 136);
            cbxTitleLibrary.Margin = new Padding(3, 4, 3, 4);
            cbxTitleLibrary.Name = "cbxTitleLibrary";
            cbxTitleLibrary.Size = new Size(188, 28);
            cbxTitleLibrary.TabIndex = 4;
            // 
            // btnAdminControls
            // 
            btnAdminControls.Location = new Point(14, 136);
            btnAdminControls.Margin = new Padding(3, 4, 3, 4);
            btnAdminControls.Name = "btnAdminControls";
            btnAdminControls.Size = new Size(127, 31);
            btnAdminControls.TabIndex = 5;
            btnAdminControls.Text = "&Admin Controls";
            btnAdminControls.UseVisualStyleBackColor = true;
            btnAdminControls.Click += btnAdminControls_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(14, 285);
            btnCheckOut.Margin = new Padding(3, 4, 3, 4);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(86, 31);
            btnCheckOut.TabIndex = 6;
            btnCheckOut.Text = "Check &Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(106, 285);
            btnCheckIn.Margin = new Padding(3, 4, 3, 4);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(86, 31);
            btnCheckIn.TabIndex = 7;
            btnCheckIn.Text = "Check &In";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(272, 285);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtResults
            // 
            txtResults.BackColor = SystemColors.Control;
            txtResults.Location = new Point(54, 189);
            txtResults.Margin = new Padding(3, 4, 3, 4);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.Size = new Size(303, 87);
            txtResults.TabIndex = 9;
            txtResults.TabStop = false;
            txtResults.TextChanged += txtResults_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 101);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 10;
            label3.Text = "Contact Info:";
            // 
            // txtContactInfo
            // 
            txtContactInfo.Location = new Point(186, 97);
            txtContactInfo.Margin = new Padding(3, 4, 3, 4);
            txtContactInfo.Name = "txtContactInfo";
            txtContactInfo.Size = new Size(171, 27);
            txtContactInfo.TabIndex = 11;
            // 
            // frmRentalStore
            // 
            AcceptButton = btnCheckOut;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(371, 332);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRentalStore";
            Text = "Sam, Jason, and Caleb's Movie Shack";
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtResults_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
