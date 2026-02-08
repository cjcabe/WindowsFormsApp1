using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> moviePrices = new Dictionary<string, double>()
        {
            { "Avengers", 300 },
            { "Avatar", 280 },
            { "Titanic", 250 }
        };

        double subtotal = 0;
        double discount = 0;
        double vat = 0;
        double total = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var movie in moviePrices.Keys)
                cmbMovie.Items.Add(movie);

            cmbSchedule.Items.Add("10:00 AM");
            cmbSchedule.Items.Add("1:00 PM");
            cmbSchedule.Items.Add("4:00 PM");
            cmbSchedule.Items.Add("7:00 PM");

            rbRegular.Checked = true;
            numQty.Value = 1;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbMovie.SelectedIndex == -1 || cmbSchedule.SelectedIndex == -1)
            {
                MessageBox.Show("Please select movie and schedule.");
                return;
            }

            double price = moviePrices[cmbMovie.Text];
            int qty = (int)numQty.Value;
            double seatMultiplier = rbVIP.Checked ? 1.5 : 1.0;

            subtotal = price * qty * seatMultiplier;
            discount = chkDiscount.Checked ? subtotal * 0.10 : 0;
            vat = (subtotal - discount) * 0.12;
            total = subtotal - discount + vat;

            txtTotal.Text = total.ToString("₱0.00");

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

       


        {
            if (string.IsNullOrWhiteSpace(txtCash.Text))
            {
                MessageBox.Show("Enter cash amount.");
                return;
            }

            double cash = Convert.ToDouble(txtCash.Text);

            if (cash < total)
            {
                MessageBox.Show("Insufficient cash.");
                return;
            }

            double change = cash - total;
            txtChange.Text = change.ToString("₱0.00");

            //button2.FlatStyle = FlatStyle
            //            button2.FlatSAppearace.BorderSize=3;

    


        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmbMovie.SelectedIndex = -1;
            cmbSchedule.SelectedIndex = -1;
            numQty.Value = 1;
            rbRegular.Checked = true;
            chkDiscount.Checked = false;

            txtCash.Clear();
            txtChange.Clear();
            rtbReceipt.Clear();
        }

        private void PrintReceipt_TextChanged(object sender, EventArgs e)
        {
            //button2.FlatStyle = FlatStyle
            //            button2.FlatSAppearace.BorderSize = 3;



            rtbReceipt.AppendText("🎬 GRAND CINEMA\n");
            rtbReceipt.AppendText("-----------------------------\n");
            rtbReceipt.AppendText($"Movie: {cmbMovie.Text}\n");
            rtbReceipt.AppendText($"Schedule: {cmbSchedule.Text}\n");
            rtbReceipt.AppendText($"Seat: {(rbVIP.Checked ? "VIP" : "Regular")}\n");
            rtbReceipt.AppendText($"Quantity: {numQty.Value}\n\n");

            rtbReceipt.AppendText($"Subtotal: ₱{subtotal:0.00}\n");
            rtbReceipt.AppendText($"Discount: ₱{discount:0.00}\n");
            rtbReceipt.AppendText($"VAT (12%): ₱{vat:0.00}\n");
            rtbReceipt.AppendText("-----------------------------\n");
            rtbReceipt.AppendText($"TOTAL: ₱{total:0.00}\n");
            rtbReceipt.AppendText("Enjoy the movie! 🍿");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
