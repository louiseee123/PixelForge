using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class manage : Form
    {
        private string firstName;
        private string lastName;


        public manage(string firstName, string lastName)
        {
            InitializeComponent();
            this.firstName = firstName;
            this.lastName = lastName;



        }
        private void manage_Load(object sender, EventArgs e)
        {

            welcometext.Text = firstName;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            history hist = new history();
            hist.Show();
            this.Hide();
        }
    }

}
