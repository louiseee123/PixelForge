using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class history : Form
    {
        private string firstName;
        private string lastName;
        private string connectionString = "server=localhost;user=root;database=pixelforge;password=";
        private ToolTip toolTip;

        public history()
        {
            InitializeComponent();
           
            LoadTransactionHistory();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged; // Attach event handler

        }

        private void LoadTransactionHistory()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch transaction dates and IDs
                    string query = "SELECT tid, date FROM transaction ORDER BY date DESC";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    // Populate the ListBox with transaction dates
                    while (reader.Read())
                    {
                        string transactionId = reader["tid"].ToString();
                        string transactionDate = Convert.ToDateTime(reader["date"]).ToString("MMMM dd, yyyy hh:mm tt");

                        // Add the transaction ID as the value and the date as the display text
                        listBox1.Items.Add(new ListItem(transactionDate, transactionId));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transaction history: " + ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Get the selected item's transaction ID
                ListItem selectedItem = (ListItem)listBox1.SelectedItem;
                string transactionId = selectedItem.Value;

                // Fetch and display transaction details
                ShowTransactionDetails(transactionId);
            }
        }

        private void ShowTransactionDetails(string transactionId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch all details of the transaction by ID
                    string query = "SELECT tid, date, receipt FROM transaction WHERE tid = @TransactionId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TransactionId", transactionId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Construct the transaction details
                            string tid = reader["tid"].ToString();
                            string date = Convert.ToDateTime(reader["date"]).ToString("MMMM dd, yyyy hh:mm tt");
                            string receipt = reader["receipt"].ToString();

                            string details = $"Transaction ID: {tid}\nDate: {date}\nReceipt:\n {receipt}";
                            MessageBox.Show(details, "Transaction Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Transaction details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching transaction details: " + ex.Message);
            }
        }

        private void history_Load(object sender, EventArgs e)
        {
            // Customize the ListBox for better appearance
            listBox1.Font = new Font("Arial", 16);
            listBox1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manage manform = new manage(firstName, lastName);
            manform.Show();
            this.Hide();



        }
    }

    // Helper class to store both display text and a hidden value (transaction ID)
    public class ListItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public ListItem(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text; // Display the date in the ListBox
        }
    }
}