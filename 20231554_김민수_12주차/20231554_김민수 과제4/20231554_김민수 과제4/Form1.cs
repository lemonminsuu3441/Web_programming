using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231554_김민수_과제4
{
    public partial class Form1 : Form
    {
        CheckBox[] chkngr;
        const int CHKBOX_COUNT = 7;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            chkngr = new CheckBox[CHKBOX_COUNT];
            chkngr[0] = checkBox1;
            chkngr[1] = checkBox2;
            chkngr[2] = checkBox3;
            chkngr[3] = checkBox4;
            chkngr[4] = checkBox5;
            chkngr[5] = checkBox6;
            chkngr[6] = checkBox7;
            for (int i = 0; i < CHKBOX_COUNT; i++ )
            {
                if(chkngr[i].Checked == true)
                {
                    listBox1.Items.Add(chkngr[i].Text);
                }
            }
        }
    }
}
