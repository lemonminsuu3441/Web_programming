﻿using System;
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
                int[] Array01 = new int[10];
                string str1 = "";
                System.Random Rannum = new System.Random();
                for(int i=0; i< 10; i++)
                {
                    Array01[i] = Rannum.Next(1, 100);
                }
                for (int i = 0; i < 10; i++)
                {
                    if (1 % 2 != 0)
                    {
                        str1 = str1 + "iarray[" + i + "] = " + Array01[i] + "\n";
                    }
                    else
                    {
                        str1 = str1 + "iarray[" + i + "] = " + Array01[i];
                    }
                    label1.Text = str1;
                }
            }
            catch
            {

            }
        }
    }
}
