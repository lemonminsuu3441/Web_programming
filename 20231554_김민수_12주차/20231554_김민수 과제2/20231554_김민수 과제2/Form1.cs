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
        int cnt = 20;
        CheckBox[] chkngr;
        public Form1()
        {
            InitializeComponent();
            chkngr = new CheckBox[20];
            chkngr[0] = checkBox1;
            chkngr[1] = checkBox2;
            chkngr[2] = checkBox3;
            chkngr[3] = checkBox4;
            chkngr[4] = checkBox5;
            chkngr[5] = checkBox6;
            chkngr[6] = checkBox7;
            chkngr[7] = checkBox8;
            chkngr[8] = checkBox9;
            chkngr[9] = checkBox10;
            chkngr[10] = checkBox11;
            chkngr[11] = checkBox12;
            chkngr[12] = checkBox13;
            chkngr[13] = checkBox14;
            chkngr[14] = checkBox15;
            chkngr[15] = checkBox16;
            chkngr[16] = checkBox17;
            chkngr[17] = checkBox18;
            chkngr[18] = checkBox19;
            chkngr[19] = checkBox20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Random rannum = new System.Random();
            for(int i=0; i < 20; i++)
            {
                chkngr[i].Text = rannum.Next(1, 100).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double chkcnt = 0;
            double sum = 0;
            double average = 0;

            for(int i=0; i<20;i++)
            {
                listBox1.Items.Add("checkBox" + (i + 1) + "=" + chkngr[i].Text);
            }
            for (int i = 0; i < 20; i++)
            {
                if(chkngr[i].Checked ==true)
                {
                    listBox2.Items.Add("checkBox" + (i + 1) + "=" + chkngr[i].Text);
                    sum += double.Parse(chkngr[i].Text);
                        chkcnt++;
                }
            }
            listBox2.Items.Add("----------------------------");
            listBox2.Items.Add("");
            listBox2.Items.Add("선택된 체크박스의 숫자합계");
            listBox2.Items.Add("숫자합계 ->" + sum);
            listBox2.Items.Add("----------------------------");
            listBox2.Items.Add("");
            listBox2.Items.Add("선택된 체크박스의 숫자평균");
            listBox2.Items.Add("숫자평균 ->" + sum/chkcnt);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            for(int i = 0; i < 20; i++)
            {
                chkngr[i].Text = "checkBox" + (i + 1);
                chkngr[i].Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
