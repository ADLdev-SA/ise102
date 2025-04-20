namespace BankApp
{
    partial class BankApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankApp));
            lblName = new Label();
            btnTransfer = new Button();
            groupBox3 = new GroupBox();
            lblID = new Label();
            vScrollBar1 = new VScrollBar();
            pictureBox1 = new PictureBox();
            btnWithdraw = new Button();
            btnDeposit = new Button();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            txtBalance = new TextBox();
            btnClose = new Button();
            imageList1 = new ImageList(components);
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            btnPassword = new Button();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Blue;
            lblName.Location = new Point(198, 77);
            lblName.Name = "lblName";
            lblName.Size = new Size(263, 59);
            lblName.TabIndex = 3;
            lblName.Text = "David John";
            // 
            // btnTransfer
            // 
            btnTransfer.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold);
            btnTransfer.Location = new Point(34, 170);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(204, 84);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "&Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblID);
            groupBox3.Controls.Add(vScrollBar1);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(lblName);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(821, 215);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Client";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(47, 183);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 30);
            lblID.TabIndex = 7;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Dock = DockStyle.Left;
            vScrollBar1.LargeChange = 1;
            vScrollBar1.Location = new Point(3, 35);
            vScrollBar1.Maximum = 4;
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(28, 177);
            vScrollBar1.TabIndex = 6;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(34, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold);
            btnWithdraw.Location = new Point(317, 170);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(204, 84);
            btnWithdraw.TabIndex = 9;
            btnWithdraw.Text = "&Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Bold);
            btnDeposit.Location = new Point(598, 170);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(204, 84);
            btnDeposit.TabIndex = 10;
            btnDeposit.Text = "&Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(btnTransfer);
            groupBox1.Controls.Add(btnDeposit);
            groupBox1.Controls.Add(btnWithdraw);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(821, 276);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Balance";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtBalance);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 107);
            panel1.TabIndex = 11;
            // 
            // txtBalance
            // 
            txtBalance.Dock = DockStyle.Fill;
            txtBalance.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBalance.ForeColor = Color.Navy;
            txtBalance.Location = new Point(0, 0);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(815, 107);
            txtBalance.TabIndex = 0;
            txtBalance.Text = "250000";
            txtBalance.TextAlign = HorizontalAlignment.Center;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(598, 751);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(204, 84);
            btnClose.TabIndex = 12;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "m1.jpg");
            imageList1.Images.SetKeyName(1, "m2.jpg");
            imageList1.Images.SetKeyName(2, "m3.jpg");
            imageList1.Images.SetKeyName(3, "m4.png");
            imageList1.Images.SetKeyName(4, "m5.png");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 491);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(821, 255);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Transactions";
            // 
            // listView1
            // 
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(3, 35);
            listView1.Name = "listView1";
            listView1.Size = new Size(815, 217);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnPassword
            // 
            btnPassword.Location = new Point(317, 752);
            btnPassword.Name = "btnPassword";
            btnPassword.Size = new Size(204, 84);
            btnPassword.TabIndex = 14;
            btnPassword.Text = "&Password";
            btnPassword.UseVisualStyleBackColor = true;
            btnPassword.Click += btnPassword_Click;
            // 
            // BankApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(821, 856);
            Controls.Add(btnPassword);
            Controls.Add(groupBox2);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BankApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Torrens Bank - ISE102 branch";
            Load += BankApp_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblName;
        private Button btnTransfer;
        private GroupBox groupBox3;
        private Button btnWithdraw;
        private Button btnDeposit;
        private GroupBox groupBox1;
        private Panel panel1;
        private TextBox txtBalance;
        private Button btnClose;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private GroupBox groupBox2;
        private ListView listView1;
        private Button btnPassword;
        private VScrollBar vScrollBar1;
        private Label lblID;
    }
}
