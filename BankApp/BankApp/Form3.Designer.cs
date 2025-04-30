namespace BankApp
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            mskUPass = new MaskedTextBox();
            txtUName = new TextBox();
            btnLogin = new Button();
            btnClose = new Button();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 213);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 290);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // mskUPass
            // 
            mskUPass.Location = new Point(282, 287);
            mskUPass.Name = "mskUPass";
            mskUPass.PasswordChar = '*';
            mskUPass.Size = new Size(565, 39);
            mskUPass.TabIndex = 2;
            // 
            // txtUName
            // 
            txtUName.Location = new Point(282, 210);
            txtUName.Name = "txtUName";
            txtUName.Size = new Size(565, 39);
            txtUName.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(451, 393);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(181, 62);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.Enter += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(666, 393);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(181, 62);
            btnClose.TabIndex = 4;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(203, 60);
            label3.Name = "label3";
            label3.Size = new Size(668, 71);
            label3.TabIndex = 7;
            label3.Text = "Welcome to Torrens Bank";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(22, 357);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(244, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(930, 529);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(txtUName);
            Controls.Add(mskUPass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmLogin";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login BankApp";
            TopMost = true;
            FormClosed += frmLogin_FormClosed;
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private MaskedTextBox mskUPass;
        private TextBox txtUName;
        private Button btnLogin;
        private Button btnClose;
        private Label label3;
        private PictureBox pictureBox2;
    }
}