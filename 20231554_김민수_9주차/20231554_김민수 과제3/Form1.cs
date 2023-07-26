using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231554_김민수_과제3
{
    public partial class Form1 : Form
    {
        int result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int data01 = int.Parse(textBox1.Text);

                if(data01 < 1000)
                {
                    result +=  data01;
                    label1.Text = "김민수 계좌잔고:" + result + "원";
                }
                else if(data01 >= 1000)
                {
                    label1.Text = "정상적인 금액을 입금해주세요.";
                }
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int data02 = int.Parse(textBox2.Text);

                if(data02 <= result)
                {
                    result -= data02;
                label1.Text = "김민수 계좌잔고:" + result + "원";
                }
                else if(data02 > result)
                {
                    label1.Text = "정상적인 금액을 입금해주세요";
                }
            }
            catch
            {

            }
        }
    }
}
