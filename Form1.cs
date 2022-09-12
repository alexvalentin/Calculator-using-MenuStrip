using System;
using System.Windows.Forms;

namespace Calculator___MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, EventArgs e)
        {
        }

        private void adunare_Click(object sender, EventArgs e)
        {
            try
            { 
                finalResultTB.Text = (Convert.ToDouble(firstNumberTB.Text) + Convert.ToDouble(secondNumberTB.Text)).ToString();
            }

            catch (Exception erorr)
            {
                MessageBox.Show("Error!", "System error! " + erorr);
            }
        }

        private void scadere_Click(object sender, EventArgs e)
        {
            try
            {
                finalResultTB.Text = (Convert.ToDouble(firstNumberTB.Text) - Convert.ToDouble(secondNumberTB.Text)).ToString();
            }

            catch (Exception erorr)
            {
                MessageBox.Show("Error!", "System error! " + erorr);
            }
        }

        private void inmultire_Click(object sender, EventArgs e)
        {
            try
            {
                finalResultTB.Text = (Convert.ToDouble(firstNumberTB.Text) * Convert.ToDouble(secondNumberTB.Text)).ToString();
            }

            catch (Exception erorr)
            {
                MessageBox.Show("Error!", "System error! " + erorr);
            }
        }

        private void divizare_Click(object sender, EventArgs e)
        {
            try
            {
                finalResultTB.Text = (Convert.ToDouble(firstNumberTB.Text) / Convert.ToDouble(secondNumberTB.Text)).ToString();
            }

            catch (Exception erorr)
            {
                MessageBox.Show("Error!", "System error! " + erorr);
            }
        }

        private void modulo_Click(object sender, EventArgs e)
        {
            try
            {
                finalResultTB.Text = (Convert.ToDouble(firstNumberTB.Text) % Convert.ToDouble(secondNumberTB.Text)).ToString();
            }

            catch (Exception erorr)
            {
                MessageBox.Show("Error!", "System error! " + erorr);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNumberTB.Text = "";
            secondNumberTB.Text = "";
            finalResultTB.Text = "";
        }
    }
}
