using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231554김민수_과제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sData01 = textBox1.Text;
            string sData02 = textBox2.Text;

            label5.Text = "성명은 " + sData01 + "\n학번은 " + sData02;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sData03 = textBox3.Text;
            string sData04 = textBox4.Text;

            label6.Text = "유선 전화번호는 " + sData03 + "\n무선 전화번호는 " + sData04;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
