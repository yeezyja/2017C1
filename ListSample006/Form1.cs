using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample006
{
    public partial class Form1 : Form
    {
        List<string> _list;
        private List<string> _leftList;
        private List<string> _rightList;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetListBoxDataSource();
            ChangeDate();
        }
        private void CreateList()
        {
            _list = new List<string>();
            _leftList = new List<string>
            {
                "農夫","狼","羊","菜"
            };
            _rightList = new List<string>();
        }
        private void SetListBoxDataSource()
        {
            listBox1.SelectionMode = SelectionMode.One;
            listBox2.SelectionMode = SelectionMode.One;

            listBox1.DataSource = _list.ToList();
            listBox2.DataSource = _list.ToList();
        }
        private void ChangeDate()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _leftList;
            listBox2.DataSource = _rightList;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "農夫")
            {
                string item = (string)listBox1.SelectedItem;
                _leftList.Remove("農夫");
                _rightList.Add("農夫");
                ChangeDate();
                message();
            }
            if (_leftList.Contains("農夫"))
            {
                if (listBox1.SelectedItem.ToString() == "狼" || listBox1.SelectedItem.ToString() == "菜" || listBox1.SelectedItem.ToString() == "羊")
                {
                    _leftList.Remove("農夫");
                    _rightList.Add("農夫");
                    string item = (string)listBox1.SelectedItem;
                    _leftList.Remove(item);
                    _rightList.Add(item);
                    ChangeDate();
                    message();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox2.SelectedItem.ToString() == "農夫")
            {
                string item = (string)listBox2.SelectedItem;
                _rightList.Remove(item);
                _leftList.Add(item);
                ChangeDate();
                message();
            }
            if (_rightList.Contains("農夫"))
            {
                if (listBox2.SelectedItem.ToString() == "狼" || listBox2.SelectedItem.ToString() == "菜" || listBox2.SelectedItem.ToString() == "羊")
                {
                    _rightList.Remove("農夫");
                    _leftList.Add("農夫");
                    string item = (string)listBox2.SelectedItem;
                    _rightList.Remove(item);
                    _leftList.Add(item);
                    ChangeDate();
                    message();
                }
            }
        }
        private void message()
        {
            if (_rightList.Contains("農夫") && _rightList.Contains("羊") && _rightList.Contains("菜") && _rightList.Contains("狼"))
            {
                MessageBox.Show("你贏了");
            }

            if (_rightList.Contains("農夫") == false)
            {
                if (_rightList.Contains("羊") && _rightList.Contains("狼"))
                {
                    MessageBox.Show("羊被狼吃掉了");
                    CreateList();
                    SetListBoxDataSource();
                    ChangeDate();
                }
                else if (_rightList.Contains("羊") && _rightList.Contains("菜"))
                {
                    MessageBox.Show("菜被羊吃掉了");
                    CreateList();
                    SetListBoxDataSource();
                    ChangeDate();
                }
            }
            if (_leftList.Contains("農夫") == false)
            {
                if (_leftList.Contains("羊") && _leftList.Contains("狼"))
                {
                    MessageBox.Show("羊被狼吃掉了");
                    CreateList();
                    SetListBoxDataSource();
                    ChangeDate();
                }
                else if (_leftList.Contains("羊") && _leftList.Contains("菜"))
                {
                    MessageBox.Show("菜被羊吃掉了");
                    CreateList();
                    SetListBoxDataSource();
                    ChangeDate();
                }
            }
        }
    }
}
