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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idata01 = int.Parse(textBox1.Text);

                switch(idata01)
                {
                    case 1:
                        label1.Text = "January";
                        break;

                    case 2:
                        label1.Text = "February";
                        break;

                    case 3:
                        label1.Text = "March";
                        break;

                    case 4:
                        label1.Text = "April";
                        break;

                    case 5:
                        label1.Text = "May";
                        break;

                    case 6:
                        label1.Text = "June";
                        break;

                    case 7:
                        label1.Text = "July";
                        break;

                    case 8:
                        label1.Text = "August";
                        break;

                    case 9:
                        label1.Text = "September";
                        break;

                    case 10:
                        label1.Text = "October";
                        break;

                    case 11:
                        label1.Text = "onNovembere";
                        break;

                    case 12:
                        label1.Text = "December";
                        break;

                    default:
                        label1.Text = "입력 문자의 형식이 잘못 되었습니다.";
                        break;

                }
            }
            catch
            {

            }
        }
    }
}
