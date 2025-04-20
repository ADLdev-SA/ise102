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
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPassword fmPass = new frmPassword();
            fmPass.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            frmTrans fmTran = new frmTrans("Deposit",3);
            fmTran.Show();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Program.intCurrentUser = vScrollBar1.Value;
            updateClient();
           // label1.Text = vScrollBar1.Value.ToString();
        }

        private void updateClient()
        {
            pictureBox1.Image = imageList1.Images[vScrollBar1.Value];
            lblID.Text = Program.clients[vScrollBar1.Value].Id;
            lblName.Text = Program.clients[vScrollBar1.Value].Name;
            txtBalance.Text = Program.clients[vScrollBar1.Value].Balance.ToString();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            frmTrans fmTran = new frmTrans("Tranfer money to",1);
            fmTran.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            frmTrans fmTran = new frmTrans("Withdraw",2);
            fmTran.Show();
        }
    }
}
