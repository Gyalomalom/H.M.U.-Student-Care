using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*This application is part of the H.M.U. (Housmate Management Utility) project designed by
group 6 for the Advanced Phase Software Engineering course at Fontys University of Applied Sciences
and as such should not be copied or redistributed without permission from the authors.
The members of group 6 and thus the sole authors of this code are:
Aleksandar Nasev, David Horvath and Paulius Stankevičius.

For contact purposes, please refer to one of the following e-mails:
a.nasev@student.fontys.nl;
david.horvath@student.fontys.nl;
p.stankevicius@student.fontys.nl;*/
namespace HMU_Project_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListRules.Add("No smoking in the building.");
            ListRules.Add("No loud gatherings after 22:00.");
            ListRules.Add("Garbage bin must be taken out on time.");
        }
        List<string> ListRules = new List<string>();
        private Complaints complaint;
        List<Complaints> ListComplaints = new List<Complaints>();

        string adminPassword = "password";

        /*The UpdateRules method clears and then repopulates the lbRules listbox to show updated data.*/
        public void UpdateRules()
        {
            lbRules.Items.Clear();
            int index = 0;
            foreach (string value in ListRules)
            {
                lbRules.Items.Add(ListRules[index]);
                index++;
            }
        }
        /*The ViewRules method adds the ListRules to the ViewRules listbox */
        public void ViewRules()
        {
            lbViewRules.Items.Clear();
            int index = 0;
            foreach (string value in ListRules)
            {
                lbViewRules.Items.Add(ListRules[index]);
                index++;
            }
        }

        /*The UpdateComplaints method clears and then repopulates the lbComplaints listbox to show updated data.*/
        public void UpdateComplaints()
        {
            lbComplaints.Items.Clear();

            foreach (Complaints value in ListComplaints)
            {
                lbComplaints.Items.Add(value.GetComplaintInfo());
            }
        }
        /*The btnAddRule click event reads the rule from the tbRuleContent and adds it to the ListRules. It then calls the
         * UpdateRules method to re-populate lbRules.*/
        private void btnAddRule_Click(object sender, EventArgs e)
        {
            if (tbRuleContent.Text != "")
            {
                ListRules.Add(tbRuleContent.Text);
                UpdateRules();
                tbRuleContent.Text = "";
            }
            else
            {
                MessageBox.Show("Rule field is empty. Please write a rule.");
            }

        }
        /*the btnEditRule click event compares the selected rule to the rules already in the list, and when it finds it,
        it replaces the one in the list with a new one in tbRuleContent. It then calls the UpdateRules method to repopulate lbRules*/
        private void btnEditRule_Click(object sender, EventArgs e)
        {
            int index = 0;
            int selectedRuleIndex = lbRules.SelectedIndex;
            if (selectedRuleIndex < 0)
            {
                MessageBox.Show("Please select a rule.");
            }
            else
            {
                string selectedRule = lbRules.Items[selectedRuleIndex].ToString();
                for (index = 0; index <= ListRules.Count - 1; index++)
                {
                    if (selectedRule == ListRules[index])
                    {
                        ListRules[index] = tbRuleContent.Text;
                    }
                }

            }
            UpdateRules();
            tbRuleContent.Text = "";
        }
        /*The btnReadComplaints click event calls the UpdateComplaints method to repopulate lbComplaints*/
        private void btnReadComplaints_Click(object sender, EventArgs e)
        {
            UpdateComplaints();
        }
        /*on our form load we make all the panels that need special events to access invisible*/
        private void Form1_Load(object sender, EventArgs e)
        {
            tabGeneral.TabPages.Remove(tabAdminLogin);
            tabGeneral.TabPages.Remove(tabAdminPanel);
            tabGeneral.TabPages.Remove(tabPassChange);
        }
        /*The btnAdminLogin click event compares the enetered value in the tbAdminPass with our password variable, and if
        correct, opens the admin panel. Else it gives an error message and lets you enter the password again*/
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (tbAdminPass.Text == adminPassword)
            {
                tabGeneral.TabPages.Add(tabAdminPanel);
                tbAdminPass.Text = "";
                tabGeneral.SelectedTab = tabGeneral.TabPages["tabAdminPanel"];
                tabGeneral.TabPages.Remove(tabAdminLogin);
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
        /*the btnAdmin click event opens the admin login panel*/
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            tabGeneral.TabPages.Add(tabAdminLogin);
            tabGeneral.SelectedTab = tabGeneral.TabPages["tabAdminLogin"];
        }
        /*btnSetNewPass click event compares the value of our stored password with the one in the textbox, and if correct,
        changes the stored password to the one in tbNewPass*/
        private void btnSetNewPass_Click(object sender, EventArgs e)
        {
            if (tbCurrentPass.Text == adminPassword)
            {
                if (tbCurrentPass.Text == tbNewPass.Text)
                {
                    MessageBox.Show("You're trying to use the same password as your current one. Please enter a new password.");
                    tbCurrentPass.Text = "";
                    tbNewPass.Text = "";
                }
                else if ((tbCurrentPass.Text != "") && (tbNewPass.Text != ""))
                {
                    adminPassword = tbNewPass.Text;
                    MessageBox.Show("Password changed successfully. Please log in again.");
                    tbCurrentPass.Text = "";
                    tbNewPass.Text = "";
                    tabGeneral.TabPages.Remove(tabPassChange);
                    tabGeneral.TabPages.Add(tabAdminLogin);
                    tabGeneral.SelectedTab = tabGeneral.TabPages["tabAdminLogin"];

                }
                else
                {
                    MessageBox.Show("One of your fields was empty. Please make sure you enter your current and intended new password.");
                }

            }
        }
        /*Closes admin panel, opens the Password change panel and sets focus to it*/
        private void btnPassChange_Click(object sender, EventArgs e)
        {
            tabGeneral.TabPages.Remove(tabAdminPanel);
            tabGeneral.TabPages.Add(tabPassChange);
            tabGeneral.SelectedTab = tabGeneral.TabPages["tabPassChange"];
        }

        /* private void cbShowPass_CheckedChanged(object sender, EventArgs e)
         {


         }*/
        /*Shows password if checked, masks password otherwise*/
        private void cbShowPass_CheckStateChanged(object sender, EventArgs e)
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
        /*The BtnAddComplaint_click event reads the input data and adds the object to a list*/
        private void BtnAddComplaint_Click(object sender, EventArgs e)
        {
            if (tbComplaints.Text != "")
            {
                string c = tbComplaints.Text;
                string d = DateTime.Now.ToString();

                complaint = new Complaints(d, c);

                ListComplaints.Add(complaint);

                tbComplaints.Text = "";
            }
            else
            {
                MessageBox.Show("Complaint field is empty. Please write a complaint.");
            }
        }
        /*Displays house rules in a listbox*/
        private void btnViewRules_Click(object sender, EventArgs e)
        {
            ViewRules();
        }
        /*Hides house rules*/
        private void btnHideRules_Click(object sender, EventArgs e)
        {
                lbViewRules.Items.Clear();
        }
    }
}
