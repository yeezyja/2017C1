using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator01
{
    public partial class Form1 : Form
    {
        Double x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void but1_Click(object sender, EventArgs e)
        {
             x = Double.Parse(textBox1.Text);
             y = Double.Parse(textBox2.Text);
            label1.Text = (x + y).ToString();
        }

        private void but3_Click(object sender, EventArgs e)
        {
             x = Double.Parse(textBox1.Text);
             y = Double.Parse(textBox2.Text);
            label1.Text = (x * y).ToString();
        }

        private void but4_Click(object sender, EventArgs e)
        {
            x = Double.Parse(textBox1.Text);
            y = Double.Parse(textBox2.Text);
            label1.Text = (x / y).ToString
                ();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void but2_Click(object sender, EventArgs e)
        {
             x = Double.Parse(textBox1.Text);
             y = Double.Parse(textBox2.Text);
            label1.Text = (x - y).ToString();
        }
    }
}
