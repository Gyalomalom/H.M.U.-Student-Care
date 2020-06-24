using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMU_Project_App
{
    public partial class PassChange : UserControl
    {
        /*On initialization we make sure this doesn't show over the admin tab*/
        public PassChange()
        {
            InitializeComponent();
            this.SendToBack();
        }

        /*Makes sure old password is entered correctly, compares it to new password and if it is different, changes the value
        of the password variable in the main form to the new value*/
        private void BtnSetNewPass_Click(object sender, EventArgs e)
        {
            if (tbCurrentPass.Text == HMU_MainForm.adminPassword)
            {
                if (tbCurrentPass.Text == tbNewPass.Text)
                {
                    MessageBox.Show("You're trying to use the same password as your current one. Please enter a new password.");
                    tbCurrentPass.Text = "";
                    tbNewPass.Text = "";
                }
                else if ((!String.IsNullOrWhiteSpace(tbCurrentPass.Text)) && (!String.IsNullOrWhiteSpace(tbNewPass.Text)))
                {
                    HMU_MainForm.adminPassword = tbNewPass.Text;
                    MessageBox.Show("Password changed successfully.");
                    tbCurrentPass.Text = "";
                    tbNewPass.Text = "";
                    this.SendToBack();
                    

                }
                else
                {
                    MessageBox.Show("One of your fields was empty. Please make sure you enter your current and intended new password.");
                }

            }
            else
            {
                MessageBox.Show("You've entered the wrong value for your current password. Please try again.");
                
            }
        }

        /*Obscures the password values when checked*/
        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                tbCurrentPass.PasswordChar = '\0';
                tbNewPass.PasswordChar = '\0';
            }
            else
            {
                tbCurrentPass.PasswordChar = '*';
                tbNewPass.PasswordChar = '*';
            }
        }
    }
}
