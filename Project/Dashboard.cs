using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Dashboard : Form
    {
        private string firstName;
        private string lastName;
        private int labelYPosition = 100;
        private Label totalPriceLabel;
        private decimal total = 0;
        public Dashboard(string firstName, string lastName)
        {
            InitializeComponent();
            this.firstName = firstName;
            this.lastName = lastName;
            InitializeTotalPriceLabel();




        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Display the welcome message when the form loads
            name.Text =firstName;


        }
        private void ResetTransaction()
        {
            total = 0;  // Reset the total amount
            totalPriceLabel.Text = "₱0.00";  // Reset the total price label
            list.Text = "";  // Clear the product list
            paytext.Text = "";  // Clear the payment field
            price.Text = "₱0.00";
            prodtext.Text = "";

        }

        private void UpdateTotalPrice(decimal price)
        {
            if (totalPriceLabel == null)
            {
                MessageBox.Show("Total Price label is not initialized.");
                return;
            }

            decimal totalPrice = 0m;

            // Retrieve the current total price, making sure to check for the initial label format
            if (decimal.TryParse(totalPriceLabel.Text.Replace("₱", ""), out totalPrice))
            {
                totalPrice += price;
            }

            // Set the new total price
            totalPriceLabel.Text = $"Total: ₱{totalPrice:F2}";
        }
        private void InitializeTotalPriceLabel()
        {
            // Ensure the label is initialized before use
            totalPriceLabel = new Label();
            totalPriceLabel.Text = "Total: ₱0.00";  // Initial value
            totalPriceLabel.Font = new Font("Arial", 12F);
            totalPriceLabel.Location = new Point(500, labelYPosition);  // Adjust position
            totalPriceLabel.AutoSize = true;

            // Add the total price label to the form
            this.Controls.Add(totalPriceLabel);
        }





        private void button1_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=localhost;user=root;database=pixelforge;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            // Ensure the barcode is not empty and is a valid number
            if (string.IsNullOrEmpty(prodtext.Text))
            {
                MessageBox.Show("Please enter a barcode.");
                return;
            }

            int barcode;

            // Try to parse the barcode input to an integer
            if (!int.TryParse(prodtext.Text, out barcode))
            {
                MessageBox.Show("Please enter a valid barcode.");
                return;
            }

            try
            {
                mySqlConnection.Open();

                // SQL query to fetch the product details by barcode
                string query = "SELECT productname, productprice FROM product WHERE productcode = @Barcode";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

                // Add the barcode parameter to the query
                mySqlCommand.Parameters.AddWithValue("@Barcode", barcode);

                // Execute the query and get the result
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    string productName = reader["productname"].ToString();
                    decimal productPrice = Convert.ToDecimal(reader["productprice"]);


                    list.Text += $"{productName} - ₱{productPrice:F2}\n";


                    // Update the total price
                    total += productPrice;
                    price.Text = $"₱{total:F2}";


                    {
                        Text = productName;
                        Location = new Point(10, 100);
                    };
                    this.Controls.Add(label3);



                    UpdateTotalPrice(productPrice);

                }
                else
                {
                    // If no product was found, show a message
                    MessageBox.Show("Product not found.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }

        }

        private void transacbut_Click(object sender, EventArgs e)
        {

            // Ensure the customer entered a payment amount
            if (string.IsNullOrEmpty(paytext.Text))
            {
                MessageBox.Show("Please enter the payment amount.");
                return;
            }

            // Parse the payment amount
            if (!decimal.TryParse(paytext.Text, out decimal payment))
            {
                MessageBox.Show("Please enter a valid payment amount.");
                return;
            }

            // Check if the payment is sufficient
            if (payment < total)
            {
                MessageBox.Show("Insufficient payment. Please collect the full amount.");
                return;
            }

            // Calculate the change
            decimal change = payment - total;
            string formattedDateTime = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt");
            // Prepare the makeshift receipt
            StringBuilder receipt = new StringBuilder();

            receipt.AppendLine("----------------------- PixelForge -----------------------\n\n");
            receipt.AppendLine($"Cashier: {firstName}");
            receipt.AppendLine($"Date: {formattedDateTime}");
            receipt.AppendLine("\nProducts Purchased:\n");
            receipt.AppendLine(list.Text); // This will display the product list from the `list.Text` label
            receipt.AppendLine($"Total: ₱{total:F2}");
            receipt.AppendLine($"Payment: ₱{payment:F2}");
            receipt.AppendLine($"Change: ₱{change:F2}");
            receipt.AppendLine("\n\n----------------------------------------------------------");

            MessageBox.Show(receipt.ToString(), "Transaction Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            RecordTransaction(receipt.ToString());
           
            ResetTransaction();
        }


        private void managebut_Click(object sender, EventArgs e)
        {

            manage manform = new manage(firstName, lastName);
            manform.Show();
            this.Hide();

        }
        private void RecordTransaction(string receiptDetails)
        {
            string mysqlCon = "server=localhost;user=root;database=pixelforge;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();

                

                // Get the current date and time
                DateTime transactionDateTime = DateTime.Now;

                // SQL query to insert the transaction record
                string query = "INSERT INTO transaction (date, receipt) VALUES (@DateTime, @Receipt)";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

                // Add parameters for the query
              
                mySqlCommand.Parameters.AddWithValue("@DateTime", transactionDateTime);
                mySqlCommand.Parameters.AddWithValue("@Receipt", receiptDetails);

                // Execute the query
                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Transaction recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recording transaction: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
    }
}
