using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Asn1.Ocsp;
namespace BankApp
{
    public partial class BankApp : Form
    {


        public BankApp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BankApp_Load(object sender, EventArgs e)
        {
            vScrollBar1.Value = Program.intCurrentUser; // set value of scrollbar is current user
            updateClient();
            listView1.Columns.Add("ID", 165);
            listView1.Columns.Add("From", 150);
            listView1.Columns.Add("To", 150);
            listView1.Columns.Add("Money", 150);
            listView1.Columns.Add("Time", 190);
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPassword fmPass = new frmPassword();
            fmPass.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            frmTrans fmTran = new frmTrans("Deposit", 3);// call Form4, set Type 3
            fmTran.Show();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Program.intCurrentUser = vScrollBar1.Value;
            updateClient();
        }

        private void updateClient()
        {
            pictureBox1.Image = imageList1.Images[Program.intCurrentUser];
            lblID.Text = Program.bankAccs[Program.intCurrentUser].ID;
            lblName.Text = Program.bankAccs[Program.intCurrentUser].Name;
            txtBalance.Text = Program.bankAccs[Program.intCurrentUser].Balance.ToString();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            frmTrans fmTran = new frmTrans("Tranfer money to", 1); // call Form4, set Type 1
            fmTran.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            frmTrans fmTran = new frmTrans("Withdraw", 2); // call Form4, set Type 2
            fmTran.Show();
        }

        private void BankApp_Activated(object sender, EventArgs e)
        {
            updateClient();
        }
        public void updateListView(string col1, string col2, string col3, string col4, string col5)
        {
            // Create one row (ListViewItem with subitems)
            ListViewItem row = new ListViewItem(col1);     // First column
            row.SubItems.Add(col2);                        // Second column
            row.SubItems.Add(col3);                        // Third column
            row.SubItems.Add(col4);                        // Fourth column
            row.SubItems.Add(col5);                        // Fifth column

            // Add row to ListView
            listView1.Items.Add(row);
        }



        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void BankApp_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void BankApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
