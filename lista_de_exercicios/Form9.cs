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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double alunosm, alunosf, porcm, porcf, qntalunos;

            alunosm = Convert.ToDouble(textBox1.Text);
            alunosf = Convert.ToDouble(textBox3.Text);

            qntalunos = alunosm + alunosf;
            porcm = (alunosm / qntalunos) * 100;
            porcf = (alunosf / qntalunos) * 100;

            label6.Text = "Quantidade de alunos: " + qntalunos + "\n" +
                          "Alunos do sexo masculino (%): " + porcm.ToString("N") + "%" + "\n" +
                          "Alunos do sexo feminino (%): " + porcf.ToString("N") + "%";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            label6.Text = "";
        }
    }
}
