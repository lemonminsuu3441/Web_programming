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
                int idata01 = int.Parse(textBox1.Text);
                switch(idata01)
                {
                    case 1:
                        label1.Text = "one";
                        break;

                    case 2:
                        label1.Text = "two";
                        break;

                    case 3:
                        label1.Text = "three";
                        break;

                    case 4:
                        label1.Text = "four";
                        break;

                    case 5:
                        label1.Text = "five";
                        break;

                    default:
                        label1.Text = "알 수 없는 수 입니다.";
                        break;
                }
            }
            catch
            {

            }
        }
    }
}
