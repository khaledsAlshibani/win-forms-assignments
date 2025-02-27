using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace product_entry_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCategories();
        }

        private void InitializeCategories()
        {
            Product_Categories.Items.Add("Mobiles");
            Product_Categories.Items.Add("Laptops");
            Product_Categories.Items.Add("Cars");
            Product_Categories.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            string productName = Product_Name.Text.Trim();
            string category = Product_Categories.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Please enter a product name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string productEntry = $"{productName} - {category}";
            Products_Listing.Items.Add(productEntry);
            Product_Name.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Products_Listing.SelectedItem != null)
            {
                Products_Listing.Items.Remove(Products_Listing.SelectedItem);
            } else
            {
                MessageBox.Show("Select a product to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
