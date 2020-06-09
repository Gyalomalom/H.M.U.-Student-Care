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
            int b = Form1.Items.Count();
            lbShoppingList.Items.Clear();
            lblTotalPrice.Text = GetTotal() + " €";

            for (int a = 0; a < b; a++)
            {
                lbShoppingList.Items.Add(ShoppingInfo(a));
            }

        }

        private String ShoppingInfo(int a) //a method for creating the strings displayed in the shopping list
        {
            String info = Form1.Items[a] + "\t" + Form1.Amount[a] + "\t" + (Form1.Prices[a] * Form1.Amount[a]).ToString("0.00") + " €" + "\t" + Form1.Categ[a];
            return info;
        }

        private void ShowMax() //method for displaying the most expensive items
        {
            lbShoppingList.Items.Clear();
            double max = Form1.Prices.Max();
            int a = Form1.Items.Count();

            for (int i = 0; i < a; i++)
            {
                if (Form1.Prices[i] == max)
                {
                    String maxadd = Form1.Items[i] + "\t" + Form1.Amount[i] + "\t" + (Form1.Prices[i] * Form1.Amount[i]).ToString("0.00") + " €" + "\t" + Form1.Categ[i];
                    lbShoppingList.Items.Add(maxadd);
                }
            }

        }
        private void ShowMin() //method for displaying the cheapest items
        {
            lbShoppingList.Items.Clear();
            double min = Form1.Prices.Min();
            int a = Form1.Items.Count();

            for (int i = 0; i < a; i++)
            {
                if (Form1.Prices[i] == min)
                {
                    String minadd = Form1.Items[i] + "\t" + Form1.Amount[i] + "\t" + (Form1.Prices[i] * Form1.Amount[i]).ToString("0.00") + " €" + "\t" + Form1.Categ[i];
                    lbShoppingList.Items.Add(minadd);
                }
            }
        }
        private void ShowCateg() //method for displaying items based on selected category
        {
            if (cbShowCateg.SelectedIndex > -1)
            {
                int a = Form1.Items.Count();
                int b = cbShowCateg.SelectedIndex;
                lbShoppingList.Items.Clear();

                for (int i = 0; i < a; i++)
                {
                    if (Form1.Categ[i] == Convert.ToString((Categories)b))
                    {
                        string s = Form1.Items[i] + "\t" + Form1.Amount[i] + "\t" + (Form1.Prices[i] * Form1.Amount[i]).ToString("0.00") + " €" + "\t" + Form1.Categ[i];
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
                if (!Form1.Items.Contains(name))
                {
                    Form1.Items.Add(name);
                    Form1.Prices.Add(price);
                    Form1.Categ.Add(categ);
                    Form1.Amount.Add(1);
                    ShoppingList();
                }
                else
                {
                    int index = Form1.Items.IndexOf(name);
                    Form1.Amount[index]++;
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
                int i = Form1.Items.IndexOf(name);
                if (Form1.Items.Contains(name))
                {
                    Form1.Items.RemoveAt(i);
                    Form1.Prices.RemoveAt(i);
                    Form1.Categ.RemoveAt(i);
                    Form1.Amount.RemoveAt(i);
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
                    Form1.Items.RemoveAt(i);
                    Form1.Prices.RemoveAt(i);
                    Form1.Categ.RemoveAt(i);
                    Form1.Amount.RemoveAt(i);
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
                    Form1.Amount[i]++;
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
                    if (Form1.Amount[i] > 1)
                    {
                        Form1.Amount[i]--;
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
            int a = Form1.Items.Count();
            double total = 0;
            for (int i = 0; i < a; i++)
            {
                total = total + Form1.Amount[i] * Form1.Prices[i];
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
