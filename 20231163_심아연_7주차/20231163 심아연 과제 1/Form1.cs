using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231163_심아연_과제_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                label1.Text = "";

                if (a > b)
                {
                    label1.Text = "시작 단수가 마지막 단수 보다 작거나 같아야 합니다.";
                }
                if (2 > a || b > 9)
                {
                    label1.Text = "2와 9사이 수를 입력하세요";
                }
                else if (2 <= a && 9 <= b)
                {
                    label1.Text = " 구구단" + a + "까지" + b + "단 까지 입니다.\n";
                    for (int i = a; i <= b; i++)
                    {
                        for (int j = 2; j < 10; j++)
                        {
                            label1.Text += i + "*" + j + "=" + i * j + "\n";
                        }
                        label1.Text += "\n";
                    }
                }
            }
            catch(Exception ex)
            {
                label1.Text = "입력 문자열 형식이 잘못되었습니다.";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
