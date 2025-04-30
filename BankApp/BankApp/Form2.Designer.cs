namespace BankApp
{
    partial class frmPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPassword));
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNewPass = new TextBox();
            txtConPass = new TextBox();
            fontDialog1 = new FontDialog();
            mskCurPass = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(662, 290);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 65);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 78);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 1;
            label1.Text = "Current password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 146);
            label2.Name = "label2";
            label2.Size = new Size(168, 32);
            label2.TabIndex = 2;
            label2.Text = "New password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 214);
            label3.Name = "label3";
            label3.Size = new Size(206, 32);
            label3.TabIndex = 3;
            label3.Text = "Confirm password";
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(445, 143);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(406, 39);
            txtNewPass.TabIndex = 2;
            // 
            // txtConPass
            // 
            txtConPass.Location = new Point(445, 211);
            txtConPass.Name = "txtConPass";
            txtConPass.Size = new Size(406, 39);
            txtConPass.TabIndex = 3;
            // 
            // mskCurPass
            // 
            mskCurPass.Location = new Point(445, 75);
            mskCurPass.Name = "mskCurPass";
            mskCurPass.PasswordChar = '*';
            mskCurPass.Size = new Size(406, 39);
            mskCurPass.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frmPassword
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 413);
            Controls.Add(pictureBox1);
            Controls.Add(mskCurPass);
            Controls.Add(txtConPass);
            Controls.Add(txtNewPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmPassword";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            TopMost = true;
            Load += frmPassword_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNewPass;
        private TextBox txtConPass;
        private FontDialog fontDialog1;
        private MaskedTextBox mskCurPass;
        private PictureBox pictureBox1;
    }
}