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
        CheckBox[] chkngr;
        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
            chkngr = new CheckBox[5];
            chkngr[0] = checkBox1;
            chkngr[1] = checkBox2;
            chkngr[2] = checkBox3;
            chkngr[3] = checkBox4;
            chkngr[4] = checkBox5;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int iPrice = 0;
            listBox2.Items.Clear();
            listBox2.Items.Add("선택차종:");
            if (radioButton1.Checked == true)
            {
                listBox2.Items.Add("       승용차");
                iPrice = iPrice + 100;
                label6.Image = Properties.Resources.car_1;
            }
            else if (radioButton2.Checked == true)
            {
                listBox2.Items.Add("       트럭");
                iPrice = iPrice + 80;
                label6.Image = Properties.Resources.car_2;
            }
            else if (radioButton3.Checked == true)
            {
                listBox2.Items.Add("       봉고차");
                iPrice = iPrice + 50;
                label6.Image = Properties.Resources.car_3;
            }

            listBox2.Items.Add("----------------------");
            listBox2.Items.Add("선택옵션");
            if (checkBox1.Checked == true)
            {
                listBox2.Items.Add("       썬루프");
                iPrice = iPrice + 1;
            }
            if (checkBox2.Checked == true)
            {
                listBox2.Items.Add("        자동온도조절장치");
                iPrice = iPrice + 2;
            }
            if (checkBox3.Checked == true)
            {
                listBox2.Items.Add("        GPS");
                iPrice = iPrice + 3;
            }
            if (checkBox4.Checked == true)
            {
                listBox2.Items.Add("        도난방지시스템");
                iPrice = iPrice + 2;
            }
            if (checkBox5.Checked == true)
            {
                listBox2.Items.Add("        에어백");
                iPrice = iPrice + 10;
            }

            listBox2.Items.Add("----------------------");
            listBox2.Items.Add("결제방법:");
            if (comboBox1.SelectedIndex == 0)
            {
                listBox2.Items.Add("       일시불");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox2.Items.Add("      무통장입금");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox2.Items.Add("      신용카드");
            }

            listBox2.Items.Add("----------------------");
            listBox2.Items.Add("견적금액");
            listBox2.Items.Add("          " + iPrice + "만원");
            label1.Text = "견적가:" + iPrice + "만원";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
