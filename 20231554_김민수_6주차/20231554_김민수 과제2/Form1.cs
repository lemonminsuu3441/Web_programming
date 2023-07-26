using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231554_김민수_과제2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ulong a = ulong.Parse(textBox1.Text);
                ulong b = ulong.Parse(textBox2.Text);
                ulong sum = 0;
                ulong mul = 1;

                if (a >= 1 && a <= 20 && a != b && b >= 1 && b <= 20)
                {
                    for (ulong i = a; i <= b; i++)
                    {
                        sum = sum + i;
                        mul = mul * i;
                    }

                    label1.Text = a + "부터" + b + "까지의 합은" + sum + "\n 곱은" + mul + "입니다.";
                }
                else if (a == b || a > b)
                {
                    label1.Text = "시작값은 마지막값 보다 작은 값이어야 합니다.";
                }
            }
            catch
            {

            }
        }
    }
}
