﻿using System;
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
        public LoginTab()
        {
            InitializeComponent();
        }


        string pass = "password";


        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            if (tbAdminPass.Text == pass)
            {
                this.SendToBack();

            }
            else if (tbAdminPass.Text == "")
            {
                MessageBox.Show("Password field is empty. Please enter a password.");
            }
            else
            {
                MessageBox.Show("You've entered the wrong password. Please try again.");
                tbAdminPass.Text = "";
            }
        }

        private void TbAdminPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginTab_Load(object sender, EventArgs e)
        {

        }
    }
}
