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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double salfixo, totalvendas, sal_, salf_;
            string nome;
            int taxa;

            taxa = 20;
            nome = Convert.ToString(textBox1.Text);
            salfixo = Convert.ToDouble(textBox2.Text);
            totalvendas = Convert.ToDouble(textBox3.Text);

            sal_ = totalvendas * taxa;
            sal_ = sal_ / 100;
            salf_ = salfixo + sal_;

            label6.Text = "Nome do vendedor: " + nome + "\n" + "Salário fixo: " + salfixo + "\n" + "Salário final: " + salf_.ToString("C");
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
