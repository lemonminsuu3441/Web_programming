using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231163_심아연_과제_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            if (a == 0 || a == 1)
            {
                label1.Text = a + "은 소수가 아닙니다.";
            }
            for (int b = 2; b <= a; b++)
            {
                if (a == b)
                {
                    label1.Text = a + "은 소수입니다.";
                    break;
                }
                if (a % b == 0)
                {
                    label1.Text = a + "은 소수가 아닙니다.";
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
