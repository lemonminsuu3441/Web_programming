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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str = textBox1.Text;
                int[] iArray = new int[13];
                for(int i=0; i<13; i++)
                {
                    iArray[i] = int.Parse(str.Substring(i, 1));
                }
                int y = 0;
                for(int i=0; i<8; i++)
                {
                    y += iArray[i] * (i + 2);
                }
                for(int i = 8; i < 12; i++)
                {
                    y += iArray[i] * (i - 6);
                }
                int Z = (11 - (y % 11)) % 10;

                if(Z==iArray[12])
                {
                    label1.Text = "올바른 주민번호 입니다.";
                }
                else
                {
                    label1.Text = "잘못된 주민번호 입니다.";
                }
            }
            catch
            {
                
            }
        }
    }
}
