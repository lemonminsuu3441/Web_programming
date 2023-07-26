using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231554_김민수_과제1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idata01 = int.Parse(textBox1.Text);

                if(idata01 < 0)
                {
                    textBox2.Text = "음수입니다.";
                }
                else if(idata01 < 10)
                {
                    textBox2.Text = "0과 10사이의 수";
                }
                else if(idata01 < 50)
                {
                    textBox2.Text = "10과 50사이의 수";
                }
                else if(idata01 < 100)
                {
                    textBox2.Text = "50과 100사이의 수";
                }
                else
                {
                    textBox2.Text = "100이상의 수";
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

        private void label1_Click_1(object sender, EventArgs e)
        {

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
