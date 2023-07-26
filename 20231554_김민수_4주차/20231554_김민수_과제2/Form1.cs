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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idata01 = int.Parse(textBox1.Text);
                double ddata01 = double.Parse(textBox2.Text);

                if (idata01 == 1)
                {
                    double result = ddata01 * 3.28;
                    textBox3.Text = "결과는" + result;
                }
                else if (idata01 == 2)
                {
                    double result = ddata01 / 3.28;
                    textBox3.Text = "결과는" + result;
                }
                else
                {
                    textBox1.Text = "1 또는 2를 입력하세요.";
                }
            }

            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
