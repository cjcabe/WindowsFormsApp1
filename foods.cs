using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class foods : Form
    {
        int popcornPrice = 70;
        int softdrinkPrice = 60;
        int hotdogPrice = 90;
        int nachosPrice = 110;
        public foods()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            txtPopcornQty.Text = "0";
            txtSoftdrinkQty.Text = "0";
            txtHotdogQty.Text = "0";
            txtNachosQty.Text = "0";

            lblTotalAmount.Text = "₱ 0.00";

            txtPopcornQty.ReadOnly = true;
            txtSoftdrinkQty.ReadOnly = true;
            txtHotdogQty.ReadOnly = true;
            txtNachosQty.ReadOnly = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPopcornPlus_Click(object sender, EventArgs e)
        {
            txtPopcornQty.Text = (int.Parse(txtPopcornQty.Text) + 1).ToString();
            
        }

        private void btnPopcornMinus_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(txtSoftdrinkQty.Text);
            if (qty > 0) qty--;
            txtSoftdrinkQty.Text = qty.ToString();
        }

        private void btnNachosPlus_Click(object sender, EventArgs e)
        {
            txtNachosQty.Text = (int.Parse(txtNachosQty.Text) + 1).ToString();
        }

        private void btnNachosMinus_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(txtNachosQty.Text);
            if (qty > 0) qty--;
            txtNachosQty.Text = qty.ToString();
        }

        private void btnHotdogPlus_Click(object sender, EventArgs e)
        {
            txtHotdogQty.Text = (int.Parse(txtHotdogQty.Text) + 1).ToString();
        }

        private void btnHotdogMinus_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(txtHotdogQty.Text);
            if (qty > 0) qty--;
            txtHotdogQty.Text = qty.ToString();
        }

        private void btnSoftdrinkPlus_Click(object sender, EventArgs e)
        {
            txtSoftdrinkQty.Text = (int.Parse(txtSoftdrinkQty.Text) + 1).ToString();
        }

        private void btnSoftdrinkMinus_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(txtSoftdrinkQty.Text);
            if (qty > 0) qty--;
            txtSoftdrinkQty.Text = qty.ToString();
        }
        private void UpdateTotal()
        {
            int total =
                int.Parse(txtPopcornQty.Text) * popcornPrice +
                int.Parse(txtSoftdrinkQty.Text) * softdrinkPrice +
                int.Parse(txtHotdogQty.Text) * hotdogPrice +
                int.Parse(txtNachosQty.Text) * nachosPrice;

            lblTotalAmount.Text = "₱ " + total.ToString("N2");
        }

        private void txtPopcornQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNachosQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHotdogQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoftdrinkQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
