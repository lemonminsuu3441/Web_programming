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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] Array01 = new int[10];
                string str1 = "";
                double vud = 0;
                System.Random Rannum = new System.Random();
                for(int i=0; i< 10; i++)
                {
                    Array01[i] = Rannum.Next(1, 100);
                }
                for (int i = 0; i < 10; i++)
                {
                    if (i % 2 != 0)
                    {
                        str1 = str1 + "iarray[" + i + "] = " + Array01[i] + "\n";
                    }
                    else
                    {
                        str1 = str1 + "iarray[" + i + "] = " + Array01[i]+ "          ";
                    }
                    vud = vud + Array01[i];
                    
                }
                str1 += "\n\n10개 원소의 평균 값은 " + vud / 10;
                label1.Text = str1;
            }
            catch
            {

            }
        }
    }
}
