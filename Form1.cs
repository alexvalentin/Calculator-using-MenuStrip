using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                rezultat.Text = (Convert.ToDouble(nr1.Text) + Convert.ToDouble(nr2.Text)).ToString();
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
                rezultat.Text = (Convert.ToDouble(nr1.Text) - Convert.ToDouble(nr2.Text)).ToString();
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
                rezultat.Text = (Convert.ToDouble(nr1.Text) * Convert.ToDouble(nr2.Text)).ToString();
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
                rezultat.Text = (Convert.ToDouble(nr1.Text) / Convert.ToDouble(nr2.Text)).ToString();
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
                rezultat.Text = (Convert.ToDouble(nr1.Text) % Convert.ToDouble(nr2.Text)).ToString();
            }

            catch (Exception erorr)
            {
                MessageBox.Show("Error!", "System error! " + erorr);
            }
        }
    }
}
