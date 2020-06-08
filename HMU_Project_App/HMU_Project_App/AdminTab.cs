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
            ListRules.Add("No smoking in the building.");
            ListRules.Add("No loud gatherings after 22:00.");
            ListRules.Add("Garbage bin must be taken out on time.");
        }
        private Complaints complaint;
        List<Complaints> ListComplaints = new List<Complaints>();
        public List<string> ListRules = new List<string>();


        private void AdminTab_Load(object sender, EventArgs e)
        {

        }
        public void UpdateComplaints()
        {
            lbComplaints.Items.Clear();

            foreach (Complaints value in ListComplaints)
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
            foreach (string value in ListRules)
            {
                lbRules.Items.Add(ListRules[index]);
                index++;
            }
        }
        private void BtnAddRule_Click(object sender, EventArgs e)
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
                for (index = 0; index <= ListRules.Count - 1; index++)
                {
                    if (selectedRule == ListRules[index])
                    {
                        ListRules[index] = tbRuleContent.Text;
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
                for (index = 0; index <= ListRules.Count - 1; index++)
                {
                    if (selectedRule == ListRules[index])
                    {
                        ListRules.RemoveAt(index);
                    }
                }

            }
            UpdateRules();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
