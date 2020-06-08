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

        List<string> Items = new List<string>(); //lists for storing shopping list data
        List<double> Prices = new List<double>();
        List<string> Categ = new List<string>();
        List<int> Amount = new List<int>();

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

        private void ShoppingListTab_Load(object sender, EventArgs e)
        {

        }
    }
}
