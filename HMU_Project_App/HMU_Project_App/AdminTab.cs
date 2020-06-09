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


        private void AdminTab_Load(object sender, EventArgs e)
        {
            UpdateRules();
            passChange1.SendToBack();
        }
        public void UpdateComplaints()
        {
            lbComplaints.Items.Clear();

            foreach (Complaints value in Form1.ListComplaints)
            {
                lbComplaints.Items.Add(value.GetComplaintInfo());
            }
        }

        private void BtnReadComplaints_Click(object sender, EventArgs e)
        {
            UpdateComplaints();
        }
        public void UpdateRules()
        {
            lbRules.Items.Clear();
            int index = 0;
            foreach (string value in Form1.ListRules)
            {
                lbRules.Items.Add(Form1.ListRules[index]);
                index++;
            }
        }
        private void BtnAddRule_Click(object sender, EventArgs e)
        {
            if (tbRuleContent.Text != "")
            {
                Form1.ListRules.Add(tbRuleContent.Text);
                UpdateRules();
                tbRuleContent.Text = "";
            }
            else
            {
                MessageBox.Show("Rule field is empty. Please write a rule.");
            }
            
        }

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
                for (index = 0; index <= Form1.ListRules.Count - 1; index++)
                {
                    if (selectedRule == Form1.ListRules[index])
                    {
                        Form1.ListRules[index] = tbRuleContent.Text;
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
                for (index = 0; index <= Form1.ListRules.Count - 1; index++)
                {
                    if (selectedRule == Form1.ListRules[index])
                    {
                        Form1.ListRules.RemoveAt(index);
                    }
                }

            }
            UpdateRules();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        
        }

        private void btnPassChange_Click(object sender, EventArgs e)
        {
            passChange1.BringToFront();
        }
    }
}
