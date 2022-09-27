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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double nota1a, nota2a, nota3a, nota1b, nota2b, nota3b, nota1c, nota2c, nota3c, mediaa, mediab, mediac;

            nota1a = Convert.ToDouble(textBox1.Text);
            nota2a = Convert.ToDouble(textBox5.Text);
            nota3a = Convert.ToDouble(textBox4.Text);

            nota1b = Convert.ToDouble(textBox6.Text);
            nota2b = Convert.ToDouble(textBox2.Text);
            nota3b = Convert.ToDouble(textBox3.Text);

            nota1c = Convert.ToDouble(textBox9.Text);
            nota2c = Convert.ToDouble(textBox7.Text);
            nota3c = Convert.ToDouble(textBox8.Text);

            mediaa = (nota1a + nota2a + nota3a) / 3;
            mediab = (nota1b + nota2b + nota3b) / 3;
            mediac = (nota1c + nota2c + nota3c) / 3;

            label6.Text = mediaa.ToString("N");
            label16.Text = mediab.ToString("N");
            label18.Text = mediac.ToString("N");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            label6.Text = "";
            label16.Text = "";
            label18.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
