﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231163_심아연_과제_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            string s = "";
            if (0 < a && a <= 100)
            {
                for (int i = 1; i <= a; i++)
                {
                    if (i % 3 == 0)
                    {
                        s += "짝 ";
                    }
                    else
                        s += i + " ";
                    if (i % 10 == 0)
                    {
                        s += "\n";
                    }

                }
                label1.Text = s;
            }
            if (100 < a)
            {
                label1.Text = "100 이하의 수를 입력하세요";
            }
        }
          
               
            
            
        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1"; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2"; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3"; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4"; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5"; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6"; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7"; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8"; 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9"; 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0"; 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = " ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
