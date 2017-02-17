using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatior02
{
    public partial class Form1 : Form
    {

        double x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            int x = 1;
            label1.Text = GetResult(x);
          

        }
       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void but4_Click(object sender, EventArgs e)
        {
            int x = 4;
            label1.Text = GetResult(x);
        }

        private void but3_Click(object sender, EventArgs e)
        {
            int x = 3;
            label1.Text = GetResult(x);
        }

        private void but2_Click(object sender, EventArgs e)
        {

            int x = 2;
            label1.Text = GetResult(x);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private  string GetResult(int i)
        {
             x = double.Parse(textBox3.Text);
             y = double.Parse(textBox1.Text);
            switch (i)
            {
                case 1:
                    return (x + y).ToString();
                case 2:
                    return (x - y).ToString();
                case 3:
                    return (x * y).ToString();
                default:
                    return (x / y).ToString();
            }
        }
    }
}
