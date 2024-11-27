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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void createacc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            // MySQL connection string, adjust 'password' if needed
            string mysqlCon = "server=localhost;user=root;database=pixelforge;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            // Retrieve user input from the form
            string email = emailtb.Text.ToString(); 
            string firstName = fnametb.Text.ToString();    // TextBox for first name
            string lastName = lnametb.Text.ToString();     // TextBox for last name
            string password = maskedpassword.Text.ToString();  // MaskedTextBox for password

            // Determine gender based on radio button selection
            string gender = "";
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "Female";
            }

            // Check if any input field is empty
            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(firstName) ||
                String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            try
            {
                // Open the connection
                mySqlConnection.Open();

                // Prepare the SQL insert query
                string query = "INSERT INTO user (email, firstname, lastname, password, gender) VALUES (@Email, @FirstName, @LastName, @Password, @Gender)";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

                // Add parameters to the command
                mySqlCommand.Parameters.AddWithValue("@Email", email);
                mySqlCommand.Parameters.AddWithValue("@FirstName", firstName);
                mySqlCommand.Parameters.AddWithValue("@LastName", lastName);
                mySqlCommand.Parameters.AddWithValue("@Password", password);
                mySqlCommand.Parameters.AddWithValue("@Gender", gender);

                // Execute the query
                int result = mySqlCommand.ExecuteNonQuery();

                // Check if the insertion was successful
                if (result > 0)
                {
                    MessageBox.Show("Registration successful!");
                    Form1 login = new Form1();
                    login.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Failed to register. Please try again.");
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the connection
                mySqlConnection.Close();
            }
        }
    }
}
