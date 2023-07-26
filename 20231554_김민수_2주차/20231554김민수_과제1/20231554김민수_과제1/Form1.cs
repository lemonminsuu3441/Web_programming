using System;
using System.Windows.Forms;

namespace _20231554김민수_과제1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iDat01 = int.Parse(textBox1.Text);
            label1.Text = "결과는" + iDat01 + "입니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double iDat02 = double.Parse(textBox1.Text);
            label1.Text = "결과는" + iDat02 + "입니다.";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iDat03 = int.Parse(textBox1.Text);
            string sData01 = "332";
            string sData02 = iDat03 + sData01;
            label1.Text = "결과는" + iDat03 + "+" + sData01 + "=" + sData02 + "입니다.";
        }
    }
}