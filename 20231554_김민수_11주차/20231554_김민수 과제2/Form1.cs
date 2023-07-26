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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] data1;
                data1 = new string[4];
                data1[0] = "바보";
                data1[1] = "메롱";
                data1[2] = "님아";
                data1[3] = "8억";

                string str = textBox1.Text;
                foreach(string str1 in data1)
                {
                    int fp = str.IndexOf(str1);
                    while (fp>=0)
                    {
                        string bstr = str.Substring(0, fp); //앞부분
                        string astr = str.Substring(fp + str1.Length); //뒷부분
                        str = bstr + "(금지어)" + astr;
                        fp = str.IndexOf(str1);
                    }
                }
                textBox1.Text = str;
            }
            catch
            {

            }
        }
    }
}
