namespace GroupOneMovieStoreAppFinal
{
    partial class frmNewTitle
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
            txtTitleName = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtTitleName
            // 
            txtTitleName.Location = new Point(86, 12);
            txtTitleName.Name = "txtTitleName";
            txtTitleName.Size = new Size(148, 23);
            txtTitleName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Title name: ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(78, 41);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(159, 41);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmNewTitle
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(263, 83);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txtTitleName);
            Name = "frmNewTitle";
            Text = "New Title";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitleName;
        private Label label1;
        private Button btnSave;
        private Button btnExit;
    }
}