using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class transaction : Form
    {
        public transaction()
        {
            InitializeComponent();
            // Ensure you are updating the correct label
            total.Text = $"₱{TotalAmount:F2}";

        }
        public decimal TotalAmount { get; set; }
        private void transaction_Load(object sender, EventArgs e)
        {
            // Display the total amount in the label
            total.Text = $"₱{TotalAmount:F2}";
            MessageBox.Show($"Total amount passed: ₱{TotalAmount:F2}");
          


        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(cash.Text, out decimal cashAmount))
            {
                if (cashAmount >= TotalAmount)
                {
                    // Calculate the change
                    decimal changeAmount = cashAmount - TotalAmount;

                    // Display the change in the label
                    change.Text = $"₱{changeAmount:F2}";
                }
                else
                {
                    // Show error if cash is insufficient
                    MessageBox.Show("Insufficient cash. Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Show error if cash input is invalid
                MessageBox.Show("Please enter a valid cash amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
