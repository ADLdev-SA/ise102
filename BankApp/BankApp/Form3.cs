using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace BankApp
{
    public partial class frmLogin : Form
    {
        // Default User Name and Password
        // Name: davidjohn@gmail.com
        // Pass: ise102
        // Hash: ea22261ddb8bcab6b21bcaefe3fa4c1367668ccff063c9f05106484773ef153e


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string hashPass = Program.toolObj.CreateHash(mskUPass.Text);

           string data = Program.toolObj.ReadFromFile("bkPass.txt");

            // Split by #
           string[] logParams = data.Split('#');

            // label4.Text = Program.toolObj.CreateHash(mskUPass.Text);

            Program.userName = logParams[0];
            Program.hashPassWord = logParams[1];

            // label4.Text = hashPass;

            if ((txtUName.Text == Program.userName) & (hashPass == Program.hashPassWord))
            {
                Program.fmBank.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid user ID or password!", "Login failed");
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
