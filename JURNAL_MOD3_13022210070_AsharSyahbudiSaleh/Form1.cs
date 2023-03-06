using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JURNAL_MOD3_13022210070_AsharSyahbudiSaleh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a, b;

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "" + button8.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                a = int.Parse(textBox1.Text);
            }
            textBox1.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "" + button1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "" + button7.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "" + button5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "" + button4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "" + button3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "" + button6.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "" + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "" + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "" + button11.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (b == 0)
            {
                b = int.Parse(textBox1.Text);
            }
            textBox1.Text = "" + (a + b);
            a = a+ b;
            b = 0;
        }
    }
}
