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
    public partial class LoginTab : UserControl
    {
        /*When we initialize the tab we also clear the password window*/
        public LoginTab()
        {
            InitializeComponent();
            tbAdminPass.Text = "";
        }


        /*Exception handling for empty fields or wrong password. On success, field is cleared and this is sent to back, allowing the user to acess admin tab*/
        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            if (tbAdminPass.Text == HMU_MainForm.adminPassword)
            {
                this.SendToBack();
                tbAdminPass.Text = "";

            }
            else if (tbAdminPass.Text=="")
            {
                MessageBox.Show("Password field is empty. Please enter a password.");
                tbAdminPass.Text = "";
            }
            else
            {
                MessageBox.Show("You've entered the wrong password. Please try again.");
                tbAdminPass.Text = "";
            }
        }
    }
}
