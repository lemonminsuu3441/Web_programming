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
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = "결과가 나오는 곳 입니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idata01 = int.Parse(textBox1.Text);
                int idata02 = int.Parse(textBox2.Text);
                string sdata01 = textBox3.Text;

                if(sdata01 == "==")
                {
                    bool bdata01 = idata01 == idata02;
                    label1.Text = "숫자" + idata01 + "숫자" + idata02
                        + "이 같은가" + bdata01;
                }
                else if(sdata01 == "!=")
                {
                    bool bdata01 = idata01 != idata02;
                    label1.Text = "숫자" + idata01 + "숫자" + idata02
                        + "이 다른가" + bdata01;
                }
                else if(sdata01 == "<=")
                {
                    bool bdata01 = idata01 <= idata02;
                    label1.Text = "숫자" + idata01 + "숫자" + idata02
                        + "이 작거나 같은가" + bdata01;
                }
                else if(sdata01 == ">=")
                {
                    bool bdata01 = idata01 >= idata02;
                    label1.Text = "숫자" + idata01 + "숫자" + idata02
                        + "이 크거나 같은가" + bdata01;
                }
                else if(sdata01 == "<")
                {
                    bool bdata01 = idata01 < idata02;
                    label1.Text = "숫자" + idata01 + "숫자" + idata02
                        + "이 작은가" + bdata01;
                }
                else if(sdata01 == ">")
                {
                    bool bdata01 = idata01 > idata02;
                    label1.Text = "숫자" + idata01 + "숫자" + idata02
                        + "이 큰가" + bdata01;
                }
                else
                {
                    label1.Text = "알 수 없는 관계연산자입니다.";
                }
            }
            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
