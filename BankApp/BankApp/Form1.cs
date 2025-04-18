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
            RetRandomID();
            lblName.Text = Program.clients[vScrollBar1.Value].Name;
            txtBalance.Text = Program.clients[vScrollBar1.Value].Balance.ToString();
        }

        private void RetRandomID()
        {
            Random rnd = new Random();
            pictureBox1.Image = imageList1.Images[vScrollBar1.Value];
            lblID.Text = "ID:" + rnd.Next(1000000, 9999999).ToString();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPassword fmPass = new frmPassword();
            fmPass.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            RetRandomID();
            lblName.Text = Program.clients[vScrollBar1.Value].Name;
            txtBalance.Text = Program.clients[vScrollBar1.Value].Balance.ToString();
        }

    }
}
