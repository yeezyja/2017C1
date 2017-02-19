using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator03
{
    public partial class Form1 : Form
    {
       
        private MyData _data;
        public Form1()
        {
            InitializeComponent();
            _data = new MyData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int _x;
        private int _y;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public int Add()
        {
            return X + Y;

        }
        public int Less()
        {
            return X - Y;

        }

        private void but1_Click(object sender, EventArgs e)
        {
            Calculate(true);
        }

        private void but2_Click(object sender, EventArgs e)
        {
            Calculate(false);
        }
        private void Calculate(bool add)
        {
            _data.X = int.Parse(textBox3.Text);
            _data.Y = int.Parse(textBox1.Text);
            if (add)
            {
                label1.Text = _data.Add().ToString();
            }
            else
            {
                label1.Text = _data.Less().ToString();
            }
        }
    }
}
