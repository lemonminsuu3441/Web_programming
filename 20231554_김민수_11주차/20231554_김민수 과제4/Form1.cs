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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 12345;
                double dNum = 0.05;
                label1.Text = String.Format("귀하의 잔액은 {0:C}입니다. ", num);
                label2.Text = String.Format("귀하의 계좌총액은 {0:C} 이고, 재산순위 상위 {1:P1} 입니다."
                    , num, dNum);
            }
            catch
            {

            }
        }
    }
}
