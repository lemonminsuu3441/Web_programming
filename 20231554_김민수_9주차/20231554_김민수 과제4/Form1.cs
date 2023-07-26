using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231554_김민수_과제4
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

                 result += data01;
                 label1.Text = result.ToString();
            }
            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int data01 = int.Parse(textBox1.Text);

                result -= data01;
                label1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int data01 = int.Parse(textBox1.Text);

                result *= data01;
                label1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int data01 = int.Parse(textBox1.Text);
                if(data01 != 0)
                {
                    result /= data01;
                    label1.Text = result.ToString();
                }

               
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
    }
}
