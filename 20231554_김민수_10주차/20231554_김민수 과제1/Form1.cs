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
                int[] Array01 = new int[100];
                for (int i = 0; i < 100; i++)
                {
                    Array01[i] = i + 1;
                }

                string str1 = "";
                int cnt = 0;
                foreach(int d in Array01)
                {
                    cnt++;
                    if(cnt % 10 == 0)
                    {
                        str1 += d + "\n";
                    }
                    else
                    {
                        str1 += d + " ";
                    }
                } label1.Text = str1;
            }
            catch
            {

            }
        }
    }
}
