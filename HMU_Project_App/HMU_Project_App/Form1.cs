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
            lblTotalPrice.Text = "0.00 €";
        }
        List<string> ListRules = new List<string>();
        private Complaints complaint;
        List<Complaints> ListComplaints = new List<Complaints>();

        List<string> Items = new List<string>(); //lists for storing shopping list data
        List<double> Prices = new List<double>();
        List<string> Categ = new List<string>();
        List<int> Amount = new List<int>();

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

        /*The ResetAdminParamaters method resets all textboxes, passwords, checkbox statuses and unsubmitted rules from the admin panel*/
        public void ResetAdminParameters ()
        {
            tbRuleContent.Text = "";
            tbCurrentPass.Text = "";
            tbNewPass.Text = "";
            cbShowPass.Checked = false;
            tbAdminPass.Text = "";
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
            TempAndLightPort.Open();
        }
        /*the following section pertains to the shopping list feature*/

        private enum Categories //enum for storing item categories 
        {
            Fruit,
            Dairy,
            Meat,
            Vegetable,
            Breads,
            Other
        }
        private void ShoppingList() //method to display the items in the shopping list
        {
            int b = Items.Count();
            lbShoppingList.Items.Clear();
            lblTotalPrice.Text = GetTotal() + " €";

            for (int a = 0; a < b; a++)
            {
                lbShoppingList.Items.Add(ShoppingInfo(a));
            }

        }

        private String ShoppingInfo(int a) //a method for creating the strings displayed in the shopping list
        {
            String info = Items[a] + "\t" + Amount[a] + "\t" + (Prices[a] * Amount[a]).ToString("0.00") + " €" + "\t" + Categ[a];
            return info;
        }

        private void ShowMax() //method for displaying the most expensive items
        {
            lbShoppingList.Items.Clear();
            double max = Prices.Max();
            int a = Items.Count();

            for (int i = 0; i < a; i++)
            {
                if (Prices[i] == max)
                {
                    String maxadd = Items[i] + "\t" + Amount[i] + "\t" + (Prices[i] * Amount[i]).ToString("0.00") + " €" + "\t" + Categ[i];
                    lbShoppingList.Items.Add(maxadd);
                }
            }

        }
        private void ShowMin() //method for displaying the cheapest items
        {
            lbShoppingList.Items.Clear();
            double min = Prices.Min();
            int a = Items.Count();

            for (int i = 0; i < a; i++)
            {
                if (Prices[i] == min)
                {
                    String minadd = Items[i] + "\t" + Amount[i] + "\t" + (Prices[i] * Amount[i]).ToString("0.00") + " €" + "\t" + Categ[i];
                    lbShoppingList.Items.Add(minadd);
                }
            }
        }
        private void ShowCateg() //method for displaying items based on selected category
        {
            if (cbShowCateg.SelectedIndex > -1)
            {
                int a = Items.Count();
                int b = cbShowCateg.SelectedIndex;
                lbShoppingList.Items.Clear();

                for (int i = 0; i < a; i++)
                {
                    if (Categ[i] == Convert.ToString((Categories)b))
                    {
                        string s = Items[i] + "\t" + Amount[i] + "\t" + (Prices[i] * Amount[i]).ToString("0.00") + " €" + "\t" + Categ[i];
                        lbShoppingList.Items.Add(s);
                    }
                }
            }
            else
                MessageBox.Show("Please select a category.");
        }

        private void AddItem() //method for adding a new item to the shopping list
        {
            if (!string.IsNullOrWhiteSpace(tbName.Text) && !string.IsNullOrWhiteSpace(tbPrice.Text) && cbCategory.SelectedIndex > -1)
            {
                int i = cbCategory.SelectedIndex;
                string name = tbName.Text;
                double price = Convert.ToDouble(tbPrice.Text);
                string categ = Convert.ToString((Categories)i);
                if (!Items.Contains(name))
                {
                    Items.Add(name);
                    Prices.Add(price);
                    Categ.Add(categ);
                    Amount.Add(1);
                    ShoppingList();
                }
                else
                {
                    int index = Items.IndexOf(name);
                    Amount[index]++;
                    ShoppingList();
                }
            }
            else
                MessageBox.Show("Please enter price, item name and select category.");
        }

        private void RemoveItem() //method for manually removing an item from the shopping list
        {
            if (!string.IsNullOrWhiteSpace(tbName.Text))
            {
                string name = tbName.Text;
                int i = Items.IndexOf(name);
                if (Items.Contains(name))
                {
                    Items.RemoveAt(i);
                    Prices.RemoveAt(i);
                    Categ.RemoveAt(i);
                    Amount.RemoveAt(i);
                    ShoppingList();
                }
                else
                    MessageBox.Show("Item is not in the shopping list.");
            }
            else
                MessageBox.Show("Please enter item name to remove.");
        }

        private void RemoveSelected() //method for removing a selected item from the list
        {
            if (rbAll.Checked)
            {
                if (lbShoppingList.SelectedIndex > -1)
                {
                    int i = lbShoppingList.SelectedIndex;
                    Items.RemoveAt(i);
                    Prices.RemoveAt(i);
                    Categ.RemoveAt(i);
                    Amount.RemoveAt(i);
                    ShoppingList();
                }
                else
                    MessageBox.Show("Please select an item.");
            }
            else
                MessageBox.Show("Please select 'Display all'.");
        }

        private void AddAmount() //method which increases the amount of a selected item in the shopping list
        {
            if (rbAll.Checked)
            {


                if (lbShoppingList.SelectedIndex > -1)
                {
                    int i = lbShoppingList.SelectedIndex;
                    Amount[i]++;
                    ShoppingList();
                }
                else
                    MessageBox.Show("Please select an item.");
            }
            else
                MessageBox.Show("Please select 'Display all'.");
        }

        private void DecreaseAmount() //method which decreases the amount of a selected item in the shopping list
        {
            if (rbAll.Checked)
            {


                if (lbShoppingList.SelectedIndex > -1)
                {
                    int i = lbShoppingList.SelectedIndex;
                    if (Amount[i] > 1)
                    {
                        Amount[i]--;
                        ShoppingList();
                    }
                    else
                        MessageBox.Show("Minimum amount reached.");
                }
                else
                    MessageBox.Show("Please select an item.");
            }
            else
                MessageBox.Show("Please select 'Display all'.");
        }

        private string GetTotal() //method for calculating the total price of items in the shopping list
        {
            int a = Items.Count();
            double total = 0;
            for (int i = 0; i < a; i++)
            {
                total = total + Amount[i] * Prices[i];
            }
            return total.ToString("0.00");
            ;
        }

        /*end of shopping list section*/


        /*The btnAdminLogin click event compares the enetered value in the tbAdminPass with our password variable, and if
        correct, opens the admin panel. Else it gives an error message and lets you enter the password again*/
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (tbAdminPass.Text == adminPassword)
            {
                tabGeneral.TabPages.Add(tabAdminPanel);
                tbAdminPass.Text = "";
                tabGeneral.SelectedTab = tabGeneral.TabPages["tabAdminPanel"];
                UpdateRules();
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
                else if ((!String.IsNullOrWhiteSpace(tbCurrentPass.Text)) && (!String.IsNullOrWhiteSpace(tbNewPass.Text)))
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
            else
            {
                MessageBox.Show("You've entered the wrong value for your current password. Please try again.");
                ResetAdminParameters();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /*Following method removes the Admin Panel tab and calls the ResetAdminParameters method*/
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            tabGeneral.TabPages.Remove(tabAdminPanel);
            ResetAdminParameters();
        }
        /*Following method removes the Admin Panel tab and calls the ResetAdminParameters method*/
        private void btnReturnToDash_Click(object sender, EventArgs e)
        {
            tabGeneral.TabPages.Remove(tabAdminLogin);
            ResetAdminParameters();
        }

        private void btnBackToAdmin_Click(object sender, EventArgs e)
        {
            tabGeneral.TabPages.Remove(tabPassChange);
            tabGeneral.TabPages.Add(tabAdminPanel);
            tabGeneral.SelectedTab = tabGeneral.TabPages["tabAdminPanel"];
            ResetAdminParameters();
        }

        private void btnDeleteRule_Click(object sender, EventArgs e)
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

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void BtnRmvSelected_Click(object sender, EventArgs e)
        {
            RemoveSelected();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        private void BtnAddAmount_Click(object sender, EventArgs e)
        {
            AddAmount();
        }

        private void BtnTakeAmount_Click(object sender, EventArgs e)
        {
            DecreaseAmount();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (rbMax.Checked)
            {
                ShowMax();
            }
            else if (rbMin.Checked)
            {
                ShowMin();
            }
            else if (rbAll.Checked)
            {
                ShoppingList();
            }
            else if (rbCategory.Checked)
            {
                ShowCateg();
            }
        }

        private void timerTempAndLight_Tick(object sender, EventArgs e)
        {
            if (TempAndLightPort.BytesToRead > 0)
            {
                string message = TempAndLightPort.ReadLine();
                message = message.Trim();
                float RealTemp;

                if (float.TryParse(message, out RealTemp))//see if message is float (only temperature can be converted to int)
                {
                    lblTemperature.Text = "The temperature is currently: " + RealTemp + "°C";
                }
                switch (message) //filter message for strings
                {
                    case "LIGHT_DETECTED":
                        {
                            pnlGarbage.BackColor = Color.PaleGreen;
                            lblGarbage.Text = "Garbage has been set out!";

                        }
                        break;
                    case "NO_LIGHT_DETECTED":
                        {
                            pnlGarbage.BackColor = Color.Yellow;
                            lblGarbage.Text = "Garbage is not set out yet.";
                        }
                        break;
                }
            }
        }

        private void pnlGarbage_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
