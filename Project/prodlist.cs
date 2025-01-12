using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class prodlist : Form
    {
        private string connectionString = "server=localhost;user=root;database=pixelforge;password=";
        private ToolTip toolTip;
        private string firstName;
        private string lastName;

        public prodlist()
        {
            InitializeComponent();
            toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            LoadProductList();
            listBoxProducts.SelectedIndexChanged += listBoxProducts_SelectedIndexChanged; // Attach event handler
        }

        private void LoadProductList()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch product names and IDs
                    string query = "SELECT pid, productname FROM product ORDER BY productname ASC";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    // Populate the ListBox with product names
                    while (reader.Read())
                    {
                        string productId = reader["pid"].ToString();
                        string productName = reader["productname"].ToString();

                        // Add the product ID as the value and the product name as the display text
                        listBoxProducts.Items.Add(new ListItem(productName, productId));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product list: " + ex.Message);
            }
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem != null)
            {
                // Get the selected item's product ID
                ListItem selectedItem = (ListItem)listBoxProducts.SelectedItem;
                string productId = selectedItem.Value;

                // Fetch and display product details
                ShowProductDetails(productId);
            }
        }

        private void ShowProductDetails(string productId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch all details of the product by ID
                    string query = "SELECT pid, productname, productcode, productprice FROM product WHERE pid = @ProductId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductId", productId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Construct the product details
                            string productName = reader["productname"].ToString();
                            string barcode = reader["productcode"].ToString();
                            string price = reader["productprice"].ToString();

                            string details = $"Product Name: {productName}\nBarcode: {barcode}\nPrice: ₱{price}";
                            MessageBox.Show(details, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Product details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching product details: " + ex.Message);
            }
        }

        private void prodlist_Load(object sender, EventArgs e)
        {
            // Customize the ListBox for better appearance
            listBoxProducts.Font = new Font("Arial", 16);
            listBoxProducts.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // If you want to navigate to another form when the button is clicked
            manage manform = new manage(firstName, lastName);
            manform.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            add addz = new add();
            addz.Show();
            this.Hide();
        }
    }

    // Helper class to store both display text and a hidden value (product ID)
    public class ListItemz
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public ListItemz(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text; // Display the product name in the ListBox
        }
    }
}
