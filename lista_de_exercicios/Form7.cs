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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero;
            numero = Convert.ToInt32(textBox1.Text);

            label3.Text = numero + " X 1 = " + numero * 1 + "\n" +
                          numero + " X 2 = " + numero * 2 + "\n" +
                          numero + " X 3 = " + numero * 3 + "\n" +
                          numero + " X 4 = " + numero * 4 + "\n" +
                          numero + " X 5 = " + numero * 5 + "\n" +
                          numero + " X 6 = " + numero * 6 + "\n" +
                          numero + " X 7 = " + numero * 7 + "\n" +
                          numero + " X 8 = " + numero * 8 + "\n" +
                          numero + " X 9 = " + numero * 9 + "\n" +
                          numero + " X 10 = " + numero * 10;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
