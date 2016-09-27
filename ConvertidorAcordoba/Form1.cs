using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertidorAcordoba
{
    public partial class Form1 : Form
    {
        double Dollars;
        double Cordoba;
        double Taca;

        public Form1()
        {
            InitializeComponent();

          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Dollars = double.Parse(txtUSDollars.Text);
                Taca = double.Parse(txtTacaDecambio.Text);
                Cordoba = Dollars * Taca;
                txtNicCordobas.Text = Cordoba.ToString();
            }
            catch { };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUSDollars_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUSDollars_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    double Dollars;
                    double Cordoba;
                    double Taca;
                    Dollars = double.Parse(txtUSDollars.Text);
                    Taca = double.Parse(txtTacaDecambio.Text);
                    Cordoba = Dollars * Taca;
                    txtNicCordobas.Text = Cordoba.ToString();
                }
            }
            catch { }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                Cordoba = double.Parse(txCordobas.Text);
                Taca = double.Parse(txTaca.Text);
                Dollars = Cordoba / Taca;
                txDollars.Text = Dollars.ToString();
            }

            catch { };
        }
    }
}
