using MySql.Data.MySqlClient;



namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=localhost;user=root;database=pixelforge;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            string username = textuser.Text.ToString();
            string password = maskedpassword.Text.ToString();

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in the fields");
                return;
            }

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM user WHERE email = @Email AND password = @Password", mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@Email", username);
                mySqlCommand.Parameters.AddWithValue("@Password", password);

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                // Use a boolean flag to track if login is successful
                bool loginSuccessful = false;

                if (reader.Read())
                {
                    // If a record is found, the credentials are correct
                    loginSuccessful = true;
                }

                reader.Close();
                mySqlConnection.Close();

                // Check the login status
                if (loginSuccessful)
                {
                    MessageBox.Show("Login Successful");
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login, Please try again");
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                if (mySqlConnection.State == System.Data.ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void createacc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();

            // Show Form2
            form2.Show();

            // Optionally hide the current form if needed
            this.Hide();
        }
    }
}
