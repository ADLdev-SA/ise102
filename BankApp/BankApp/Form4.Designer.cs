namespace BankApp
{
    partial class frmTrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrans));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnOk = new Button();
            button2 = new Button();
            txtID = new TextBox();
            txtName = new TextBox();
            txtMoney = new TextBox();
            pictureBox1 = new PictureBox();
            lblStat = new Label();
            vScrollBar1 = new VScrollBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 39);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 96);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 154);
            label3.Name = "label3";
            label3.Size = new Size(89, 32);
            label3.TabIndex = 2;
            label3.Text = "Money";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(189, 222);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(150, 46);
            btnOk.TabIndex = 3;
            btnOk.Text = "&Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(369, 222);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 4;
            button2.Text = "&Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(126, 35);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(393, 39);
            txtID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(126, 92);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(393, 39);
            txtName.TabIndex = 6;
            // 
            // txtMoney
            // 
            txtMoney.BackColor = SystemColors.Info;
            txtMoney.Location = new Point(126, 154);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(393, 39);
            txtMoney.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 198);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblStat
            // 
            lblStat.AutoSize = true;
            lblStat.Location = new Point(21, 271);
            lblStat.Name = "lblStat";
            lblStat.Size = new Size(83, 32);
            lblStat.TabIndex = 9;
            lblStat.Text = "Status:";
            lblStat.Visible = false;
            // 
            // vScrollBar1
            // 
            vScrollBar1.LargeChange = 1;
            vScrollBar1.Location = new Point(522, 35);
            vScrollBar1.Maximum = 4;
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(25, 158);
            vScrollBar1.TabIndex = 10;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // frmTrans
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 302);
            ControlBox = false;
            Controls.Add(vScrollBar1);
            Controls.Add(lblStat);
            Controls.Add(pictureBox1);
            Controls.Add(txtMoney);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(button2);
            Controls.Add(btnOk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmTrans";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            TopMost = true;
            Load += frmTrans_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnOk;
        private Button button2;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtMoney;
        private PictureBox pictureBox1;
        private Label lblStat;
        private VScrollBar vScrollBar1;
    }
}