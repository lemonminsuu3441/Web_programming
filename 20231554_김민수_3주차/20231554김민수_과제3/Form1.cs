using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231554김민수_과제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             try
            {
                double iData01 = double.Parse(textBox1.Text); //가로
                double iData02 = double.Parse(textBox1.Text); //세로
                double iData03 = double.Parse(textBox1.Text); //높이

                double iData04 = (iData01 / 100) * (iData02
                    / 100) * (iData03 / 100);
                
                label7.Text = "직육면체 가로: " + iData01 / 100 
                + "m 세로: "+ iData02 / 100 + "m 높이:"+ iData03 / 100 + "m 의\n부피는" + iData04 + "m 입니다.";
            }
            catch(Exception ex)
             {

             }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                int iData02 = int.Parse(textBox1.Text);
                int iData03 = int.Parse(textBox1.Text);

                int iData04 = iData01 * 10 * iData02
                    * 10 * iData03 * 10;
                
                label7.Text = "직육면체 가로: " + iData01 * 10 
                + "mm 세로: "+ iData02 * 10 + "mm 높이:"+ iData03 * 10 + "mm 의\n부피는" + iData04 + "mm 입니다.";
            }
            catch(Exception ex)
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                
            
            try
            {
                int iData01 = int.Parse(textBox1.Text); //가로
                int iData02 = int.Parse(textBox1.Text); //세로
                int iData03 = int.Parse(textBox1.Text); //높이

                int iData04 = iData01  * iData02
                    * iData03;
                
                label7.Text = "직육면체 가로: " + iData01 
                + "cm 세로: "+ iData02  + "cm 높이:"+ iData03  + "cm 의\n부피는" + iData04 + "cm 입니다.";
            }
            catch (Exception ex)
            {
     
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = "결과가 표시되는 곳 입니다.";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
