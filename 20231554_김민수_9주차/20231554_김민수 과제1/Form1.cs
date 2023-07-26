using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231554_김민수_과제1
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int data01 = int.Parse(textBox1.Text);
                int result = 0;
                count++;

                for (int i = 1; i < data01; i++)
                {
                    if (data01 < 5000)
                    {
                        result += i;
                    }
                }
                label1.Text = "합 :" + result;
                label3.Text = "이용횟수 :" + count + "회";
            }

            catch
            {

            }
        }
    }
}
