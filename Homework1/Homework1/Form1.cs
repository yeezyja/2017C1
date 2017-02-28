using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var list = CreateData();
            dataGridView1.DataSource = list;
        }
        private List<Class1> CreateData()
        {
            char[] splits = new char[] { ',' };
            string fileName = "11111.csv";
            List<Class1> result = new List<Class1>();
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                for (int i = 1; i < lines.Count(); i++)
                {
                    string[] items = lines[i].Split(splits);

                    var directory = new Class1
                    {
                        Seq = int.Parse(items[0]),
                        Name = items[1],
                        Phone = items[2],
                        Address = items[3],
                       
                    };
                    result.Add(directory);
                }
            }
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = CreateData();
            var input = textBox1.Text;
            var person = list.SingleOrDefault((x) => x.Name == input.ToString());

            MessageBox.Show("你找到了" + person.Name + "-" + person.Phone + "-" + person.Address);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
