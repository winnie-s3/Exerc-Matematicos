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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a, b, c, r, s;
            double d;
            a = Convert.ToInt16(textBox12.Text);
            b = Convert.ToInt16(textBox11.Text);
            c = Convert.ToInt16(textBox10.Text);

            r = (a + b) * 2;
            s = (b + c) * a;
            d = (r + s) / 4;

            label18.Text = ("VALOR D: " + d);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox12.Clear();
            textBox11.Clear();
            textBox10.Clear();
            label18.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
