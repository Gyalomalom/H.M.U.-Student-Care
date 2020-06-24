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
    public partial class AdminTab : UserControl
    {
        public AdminTab()
        {
            InitializeComponent();
        }
        /*method fills in the rules listbox with all values of ListRules. It is called on the adminTab load event and via button click*/
        public void UpdateRules()
        {
            lbRules.Items.Clear();
            int index = 0;
            foreach (string value in HMU_MainForm.ListRules)
            {
                lbRules.Items.Add(HMU_MainForm.ListRules[index]);
                index++;
            }
        }
        /*method fills in the rules listbox with all values of ListRules. It is called on the adminTab load event and via button click*/
        public void UpdateComplaints()
        {
            lbComplaints.Items.Clear();

            foreach (Complaints value in HMU_MainForm.ListComplaints)
            {
                lbComplaints.Items.Add(value.GetComplaintInfo());
            }
        }

        /*On loading the tab, updates rules and complaints with their appropriate methdo*/
        private void AdminTab_Load(object sender, EventArgs e)
        {
            UpdateRules();
            UpdateComplaints();
            tabPassChange.SendToBack();
        }

        /*Update complaints listbox*/
        private void BtnReadComplaints_Click(object sender, EventArgs e)
        {
            UpdateComplaints();
        }

        /*Adds a rule to the list*/
        private void BtnAddRule_Click(object sender, EventArgs e)
        {
            if (tbRuleContent.Text != "")
            {
                HMU_MainForm.ListRules.Add(tbRuleContent.Text);
                UpdateRules();
                tbRuleContent.Text = "";
            }
            else
            {
                MessageBox.Show("Rule field is empty. Please write a rule.");
            }
            
        }
        /*Locates and replaces a rule on the list with a new one*/
        private void BtnEditRule_Click(object sender, EventArgs e)
        {
            int index = 0;
            int selectedRuleIndex = lbRules.SelectedIndex;
            if (selectedRuleIndex < 0)
            {
                MessageBox.Show("Please select a rule.");
            }
            else if (!String.IsNullOrWhiteSpace(tbRuleContent.Text)) //check if field is empty
            {
                string selectedRule = lbRules.Items[selectedRuleIndex].ToString();
                for (index = 0; index <= HMU_MainForm.ListRules.Count - 1; index++)
                {
                    if (selectedRule == HMU_MainForm.ListRules[index])
                    {
                        HMU_MainForm.ListRules[index] = tbRuleContent.Text;
                    }
                }

            }
            else
            {
                MessageBox.Show("Error: trying to replace existing rule without giving a value for the new rule. Please enter a new rule to replace the existing one with. If you wish to delete a rule, please use the 'Delete Rule' button.");
            }
            UpdateRules();
            tbRuleContent.Text = "";
        }

        /*Locates and deletes a rule from the list*/
        private void BtnDeleteRule_Click(object sender, EventArgs e)
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
                for (index = 0; index <= HMU_MainForm.ListRules.Count - 1; index++)
                {
                    if (selectedRule == HMU_MainForm.ListRules[index])
                    {
                        HMU_MainForm.ListRules.RemoveAt(index);
                    }
                }

            }
            UpdateRules();
        }

        /*focuses on the passChange tab*/
        private void btnPassChange_Click(object sender, EventArgs e)
        {
            tabPassChange.BringToFront();
        }

        private void tabPassChange_Enter(object sender, EventArgs e)
        {
            UpdateComplaints();
            UpdateRules();

        }
    }
}
