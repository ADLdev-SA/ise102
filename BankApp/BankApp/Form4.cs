using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Linq.Expressions;

namespace BankApp
{
    public partial class frmTrans : Form
    {
        private int tranType = 0;
        int toClient = 0; /// index to Receiver
        /// 
        /// </summary>
        public frmTrans()
        {
            InitializeComponent();
        }

        public frmTrans(string frmName, int intType)
        {
            InitializeComponent();
            tranType = intType;
            this.Text = frmName;
            vScrollBar1.Visible = false;
            toClient = Program.intCurrentUser; // update index of the current user
            vScrollBar1.Value = toClient; // set the current value for VScrollBar to current user
            switch (tranType) // setup the form4 depend on Transfer, Withdraw, Deposit
            {
                case 1:
                    // If tranfer money, visible the VScrollBar to choose receiver
                    vScrollBar1.Visible = true; 
                    break;

                case 2:
                    // Withdraw from current user, hide the VScrollBar here, no need
                    break;

                case 3:
                    // Deposit from current user, hide the VScrollBar here, no need
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTrans_Load(object sender, EventArgs e)
        {
            txtID.Text = Program.bankAccs[Program.intCurrentUser].ID;
            txtName.Text = Program.bankAccs[Program.intCurrentUser].Name;
        }
        private void uClient()
        {
            txtID.Text = Program.bankAccs[vScrollBar1.Value].ID;
            txtName.Text = Program.bankAccs[vScrollBar1.Value].Name;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            toClient = vScrollBar1.Value;
            uClient(); // when move scrollbar, update value of the receiver         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This method done all transaction, write the transaction to the ListView.
            //when students add Withdraw(), Deposit(), it will work.

            DateTime now = DateTime.Now;
            decimal decMoney = 0;
            try
            {
                decMoney = Decimal.Parse(txtMoney.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
                return;
            }

            string lastTwoNums = "";
            switch (tranType)
            {
                case 1:
                    // check if FromClient = ToClient, transfer money to different account
                    if (Program.intCurrentUser == toClient)
                    {
                        MessageBox.Show("The sender and the recipient must be different! \n Use scrollbar to choose a receiver!", "Error");

                        return;
                    }
                    if (Program.bankAccs[Program.intCurrentUser].Withdraw(decMoney)
                        && Program.bankAccs[toClient].Deposit(decMoney))
                    {
                        lastTwoNums = Program.bankAccs[Program.intCurrentUser].ID.Substring(Program.bankAccs[Program.intCurrentUser].ID.Length - 2);
                        Program.fmBank.updateListView("T" + lastTwoNums + "-" + Program.toolObj.TransID(), Program.bankAccs[Program.intCurrentUser].ID,
                            Program.bankAccs[toClient].ID, txtMoney.Text.Trim(), now.ToString("HH:mm:ss"));
                    }
                    else
                    {
                        MessageBox.Show("Transaction error!", "Transfer failed");
                    }
                    break;
                case 2:
                    if (Program.bankAccs[Program.intCurrentUser].Withdraw(decMoney))
                    {
                        lastTwoNums = Program.bankAccs[Program.intCurrentUser].ID.Substring(Program.bankAccs[Program.intCurrentUser].ID.Length - 2);
                        Program.fmBank.updateListView("W" + lastTwoNums + "-" + Program.toolObj.TransID(), Program.bankAccs[Program.intCurrentUser].ID,
                            "", "-" + txtMoney.Text.Trim(), now.ToString("HH:mm:ss"));
                    }
                    else
                    {
                        MessageBox.Show("Can't withdraw money!", "Withdraw failed");
                    }
                    break;

                case 3:
                    if (Program.bankAccs[Program.intCurrentUser].Deposit(decMoney))
                    {
                        lastTwoNums = Program.bankAccs[Program.intCurrentUser].ID.Substring(Program.bankAccs[Program.intCurrentUser].ID.Length - 2);
                        Program.fmBank.updateListView("D" + lastTwoNums + "-" + Program.toolObj.TransID(), "",
                            Program.bankAccs[Program.intCurrentUser].ID, "+" + txtMoney.Text.Trim(), now.ToString("HH:mm:ss"));
                    }
                    else
                    {
                        MessageBox.Show("Cant deposit money!", "Deposit failed");
                    }
                    break;

            }
            this.Close();
        }

        private void frmTrans_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
