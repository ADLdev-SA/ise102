﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankApp
{
    public partial class frmPassword : Form
    {
        
        public frmPassword()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string strMessage = "";
            //calculate hashPasswor from current pass
            string hashPass = Program.toolObj.CreateHash(mskCurPass.Text);

            // compare hashPass with Global Hash, compare NewPass with ConfirmPass
            if (hashPass == Program.hashPassWord)
            {
                if (txtNewPass.Text==txtConPass.Text)
                {
                    if (Program.toolObj.CheckPassFormat(txtNewPass.Text, ref strMessage))
                    {
                        // everything okay
                        //calculate the hash, save to global hashPassword
                        Program.hashPassWord = Program.toolObj.CreateHash(txtNewPass.Text);

                        // save to config file, keep User Name, hashPassword
                        Program.toolObj.WriteToFile("bkPass.txt", Program.userName + "#" + Program.hashPassWord);

                        // close this form, goback to main form.
                        Program.fmBank.Show();
                        this.Close();
                    }
                    else
                    {
                        //not okay, show message
                        MessageBox.Show(strMessage, "Change Password Failed");
                    }                       
                }
                else
                {
                    // not match
                    MessageBox.Show("New password and confirmation do not match", "Change Password Failed");
                }

            }
            else
            {
                // wrong current password
                MessageBox.Show("Check your current password!", "Change Password Failed");
            }
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {

        }

        private void frmPassword_FormClosed(object sender, EventArgs e)
        {
            Program.fmBank.Show();
        }
    }
}
