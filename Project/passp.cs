using System;
using System.Windows.Forms;

namespace Project
{
    public partial class passp : Form
    {
        public string EnteredPassword { get; private set; }

        public passp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form and indicate that the user canceled the action
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Retrieve the entered password and close the form
            EnteredPassword = maskedTextBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
