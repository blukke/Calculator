using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1, n2, s;
            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            s = n1 - n2;
            textBox3.Text = s.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, s;
            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            s = n1 + n2;
            textBox3.Text = s.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            float n1, n2, s;
            n1 = float.Parse(textBox1.Text);
            n2 = float.Parse(textBox2.Text);
            s = n1 / n2;
            textBox3.Text = s.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1, n2, s;
            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            s = n1 * n2;
            textBox3.Text = s.ToString();
        }
    }
}
