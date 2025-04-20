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

namespace BankApp
{
    public partial class frmTrans : Form
    {
        private int isTransaction = 1;
        int tempClient = 0;
        public frmTrans()
        {
            InitializeComponent();
        }

        public frmTrans(string frmName, int intType)
        {
            InitializeComponent();
            this.Text = frmName;
            vScrollBar1.Visible = false;
            tempClient = Program.intCurrentUser; ;
            vScrollBar1.Value = tempClient;
            switch (intType)
            {
                case 1:
                    //txtID.BackColor = System.Drawing.Color.White;
                    //txtName.BackColor = System.Drawing.Color.White;
                    vScrollBar1.Visible = true;
                    break;
                case 2:
                   // txtID.BackColor = System.Drawing.Color.DarkCyan;
                    //txtName.BackColor = System.Drawing.Color.DarkCyan;
                    break;

                case 3:
                    //txtID.BackColor = System.Drawing.Color.DarkCyan;
                    //txtName.BackColor = System.Drawing.Color.DarkCyan;
                    break;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTrans_Load(object sender, EventArgs e)
        {
            txtID.Text = Program.clients[Program.intCurrentUser].Id;
            txtName.Text = Program.clients[Program.intCurrentUser].Name;

        }
        private void uClient()
        {

            txtID.Text = Program.clients[vScrollBar1.Value].Id;
            txtName.Text = Program.clients[vScrollBar1.Value].Name;

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            tempClient = vScrollBar1.Value;
            uClient();
            //lblStat.Text = tempClient.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
