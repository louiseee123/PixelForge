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

            string email = textuser.Text;
            string password = maskedpassword.Text;

            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            try
            {
                mySqlConnection.Open();

                string query = "SELECT firstname FROM user WHERE email = @Email AND password = @Password";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@Email", email);
                mySqlCommand.Parameters.AddWithValue("@Password", password);

                object result = mySqlCommand.ExecuteScalar();

                if (result != null)
                {
                    string firstName = result.ToString();

                    // Pass the first name to the Dashboard
                    Dashboard dashboard = new Dashboard(firstName);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.");
                }
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
