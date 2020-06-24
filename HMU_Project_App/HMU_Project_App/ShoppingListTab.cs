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
    public partial class ShoppingListTab : UserControl
    {
        public ShoppingListTab()
        {
            InitializeComponent();
            lblTotalPrice.Text = "0.00 €";
        }


        private void BgEdit_Enter(object sender, EventArgs e)
        {

        }
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
            int b = HMU_MainForm.Items.Count();
            lbShoppingList.Items.Clear();
            lblTotalPrice.Text = GetTotal() + " €";

            for (int a = 0; a < b; a++)
            {
                lbShoppingList.Items.Add(ShoppingInfo(a));
            }

        }

        private String ShoppingInfo(int a) //a method for creating the strings displayed in the shopping list
        {
            String info = HMU_MainForm.Items[a] + "\t" + HMU_MainForm.Amount[a] + "\t" + (HMU_MainForm.Prices[a] * HMU_MainForm.Amount[a]).ToString("0.00") + " €" + "\t" + HMU_MainForm.Categ[a];
            return info;
        }

        private void ShowMax() //method for displaying the most expensive items
        {
            lbShoppingList.Items.Clear();
            double max = HMU_MainForm.Prices.Max();
            int a = HMU_MainForm.Items.Count();

            for (int i = 0; i < a; i++)
            {
                if (HMU_MainForm.Prices[i] == max)
                {
                    String maxadd = HMU_MainForm.Items[i] + "\t" + HMU_MainForm.Amount[i] + "\t" + (HMU_MainForm.Prices[i] * HMU_MainForm.Amount[i]).ToString("0.00") + " €" + "\t" + HMU_MainForm.Categ[i];
                    lbShoppingList.Items.Add(maxadd);
                }
            }

        }
        private void ShowMin() //method for displaying the cheapest items
        {
            lbShoppingList.Items.Clear();
            double min = HMU_MainForm.Prices.Min();
            int a = HMU_MainForm.Items.Count();

            for (int i = 0; i < a; i++)
            {
                if (HMU_MainForm.Prices[i] == min)
                {
                    String minadd = HMU_MainForm.Items[i] + "\t" + HMU_MainForm.Amount[i] + "\t" + (HMU_MainForm.Prices[i] * HMU_MainForm.Amount[i]).ToString("0.00") + " €" + "\t" + HMU_MainForm.Categ[i];
                    lbShoppingList.Items.Add(minadd);
                }
            }
        }
        private void ShowCateg() //method for displaying items based on selected category
        {
            if (cbShowCateg.SelectedIndex > -1)
            {
                int a = HMU_MainForm.Items.Count();
                int b = cbShowCateg.SelectedIndex;
                lbShoppingList.Items.Clear();

                for (int i = 0; i < a; i++)
                {
                    if (HMU_MainForm.Categ[i] == Convert.ToString((Categories)b))
                    {
                        string s = HMU_MainForm.Items[i] + "\t" + HMU_MainForm.Amount[i] + "\t" + (HMU_MainForm.Prices[i] * HMU_MainForm.Amount[i]).ToString("0.00") + " €" + "\t" + HMU_MainForm.Categ[i];
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
                if (!HMU_MainForm.Items.Contains(name))
                {
                    HMU_MainForm.Items.Add(name);
                    HMU_MainForm.Prices.Add(price);
                    HMU_MainForm.Categ.Add(categ);
                    HMU_MainForm.Amount.Add(1);
                    ShoppingList();
                }
                else
                {
                    int index = HMU_MainForm.Items.IndexOf(name);
                    HMU_MainForm.Amount[index]++;
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
                int i = HMU_MainForm.Items.IndexOf(name);
                if (HMU_MainForm.Items.Contains(name))
                {
                    HMU_MainForm.Items.RemoveAt(i);
                    HMU_MainForm.Prices.RemoveAt(i);
                    HMU_MainForm.Categ.RemoveAt(i);
                    HMU_MainForm.Amount.RemoveAt(i);
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
                    HMU_MainForm.Items.RemoveAt(i);
                    HMU_MainForm.Prices.RemoveAt(i);
                    HMU_MainForm.Categ.RemoveAt(i);
                    HMU_MainForm.Amount.RemoveAt(i);
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
                    HMU_MainForm.Amount[i]++;
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
                    if (HMU_MainForm.Amount[i] > 1)
                    {
                        HMU_MainForm.Amount[i]--;
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
            int a = HMU_MainForm.Items.Count();
            double total = 0;
            for (int i = 0; i < a; i++)
            {
                total = total + HMU_MainForm.Amount[i] * HMU_MainForm.Prices[i];
            }
            return total.ToString("0.00");
            ;
        }

        private void ShoppingListTab_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        private void btnRmvSelected_Click(object sender, EventArgs e)
        {
            RemoveSelected();
        }

        private void btnShow_Click(object sender, EventArgs e)
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

        private void btnAddAmount_Click(object sender, EventArgs e)
        {
            AddAmount();
        }

        private void btnTakeAmount_Click(object sender, EventArgs e)
        {
            DecreaseAmount();
        }
    }
}
