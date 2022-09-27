using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_de_exercicios
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valore, nump, juros, parcjuros, jf, valorparcela, pfinal, valortotal;

            valore = Convert.ToDouble(textBox1.Text);
            nump = Convert.ToDouble(textBox2.Text);
            juros = Convert.ToDouble(textBox3.Text);

            parcjuros = juros / 100;
            jf = parcjuros * valore;
            valorparcela = valore / nump;
            pfinal = valorparcela + jf;
            valortotal = pfinal * nump;

            label6.Text = "Valor das parcelas: " + pfinal.ToString("C") + "\n" +
                          "Valor total a pagar: " + valortotal.ToString("C");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
