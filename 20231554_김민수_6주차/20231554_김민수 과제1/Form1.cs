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
                string sdata01="";

                for(int i = 1; i<= idata01; i++)
                {
                    sdata01 = sdata01 + i + ",";
                }
                label1.Text ="수행된 i값: " + sdata01;
            }
            catch
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
