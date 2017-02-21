using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        private Youbmi _bmi;
        public Form1()
        {
            InitializeComponent();
            _bmi = new Youbmi();
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            YOGO(1);
        }
        private void YOGO(int a)
        {
            try
            {


                _bmi.Tall = double.Parse(textBox1.Text);
                _bmi.wid = double.Parse(textBox2.Text);
                if(_bmi.Tall<=0 || _bmi.wid<=0 || _bmi.Tall>=300 || _bmi.wid>=350)
                {
                    MessageBox.Show("請輸入正常身高體重");
                }

                else if (_bmi.GetBmi() < 18.5)
                {
                    MessageBox.Show("你的BMI:" + _bmi.GetBmi().ToString() + " 過輕");
                }
                else
                if (18.5 <= _bmi.GetBmi() && _bmi.GetBmi() < 24)
                {
                    MessageBox.Show("你的BMI:" + _bmi.GetBmi().ToString() + " 正常");
                }
                else
                if (27 <= _bmi.GetBmi() && _bmi.GetBmi() < 30)
                {
                    MessageBox.Show("你的BMI:" + _bmi.GetBmi().ToString() + " 輕度肥胖");
                }
                else
                if (30 <= _bmi.GetBmi() && _bmi.GetBmi() < 35)
                {
                    MessageBox.Show("你的BMI:" + _bmi.GetBmi().ToString() + " 中度肥胖");
                }
                else
                if (_bmi.GetBmi() >= 35)
                {
                    MessageBox.Show("你的BMI:" + _bmi.GetBmi().ToString() + " 重度肥胖");
                }

            }
            catch
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
