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
                char cdata01 = char.Parse(textBox1.Text);
                switch(cdata01)
                {
                    case'a':                  
                    case'A':
                    case'e':
                    case'E':
                    case'o':
                    case'O':
                    case'i':
                    case'I':
                    case'u':
                    case'U':

                        label1.Text = cdata01 + "은 모음입니다.";
                        break;
                default:
                        label1.Text = cdata01 + "은 자음입니다.";
                        break;
                }
            }
            catch
            {

            }
        }
    }
}
