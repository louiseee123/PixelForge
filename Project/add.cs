
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class add : Form
    {
        private System.Windows.Forms.TextBox prodnameTextBox;
        private System.Windows.Forms.TextBox prodcodeTextBox;
        private System.Windows.Forms.TextBox prodpriceTextBox;
        private string firstName;
        private string lastName;
        public add()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=localhost;user=root;database=pixelforge;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            // Access the Text properties of the TextBox controls
            string productname = prodname.Text.ToString();
            string productcode = prodcode.Text.ToString();
            string productprice = prodprice.Text.ToString();



            if (String.IsNullOrEmpty(productname) || String.IsNullOrEmpty(productcode) ||
               String.IsNullOrEmpty(productprice))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            try
            {
                // Open the connection
                mySqlConnection.Open();

                // Prepare the SQL insert query
                string query = "INSERT INTO product (productname, productprice, productcode) VALUES (@ProductName, @ProductPrice, @ProductCode)";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

                // Add parameters to the command
                mySqlCommand.Parameters.AddWithValue("@ProductName", productname);
                mySqlCommand.Parameters.AddWithValue("@ProductPrice", productprice);
                mySqlCommand.Parameters.AddWithValue("@ProductCode", productcode);

                // Execute the query
                int result = mySqlCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Product successfully added!");
                    prodname.Clear();
                    prodcode.Clear();
                    prodprice.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to register. Please try again.");
                    prodname.Clear();
                    prodcode.Clear();
                    prodprice.Clear();
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("An error occurred: " + ex.Message);
                prodname.Clear();
                prodcode.Clear();
                prodprice.Clear();
            }
            finally
            {
                // Close the connection
                mySqlConnection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prodlist prodl = new prodlist();
            prodl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manage hatdog = new manage(firstName, lastName);
            hatdog.Show();
            this.Hide();

        }
    }
}
