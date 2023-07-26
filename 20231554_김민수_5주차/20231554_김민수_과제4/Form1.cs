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
                string sdata01 = textBox1.Text;
                switch (sdata01)
                {
                    case "int":
                        int int_Min = int.MinValue;
                        int int_Max = int.MaxValue;
                        label1.Text = sdata01 + "의 허용값은" +
                        int_Min + "~" + int_Max;
                        break;

                    case "double":
                        double double_Min = double.MinValue;
                        double double_Max = double.MaxValue;
                        label1.Text = sdata01 + "의 하용값은" +
                        double_Min + "~" +
                        double_Max;
                        break;

                    case "byte":
                        byte byte_Min = byte.MinValue;
                        byte byte_Max = byte.MaxValue;
                        label1.Text = sdata01 + "의 하용값은" +
                        byte_Min + "~" +
                        byte_Max;
                        break;

                    case "short":
                        short short_Min = short.MinValue;
                        short short_Max = short.MaxValue;
                        label1.Text = sdata01 + "의 하용값은" +
                        short_Min + "~" +
                        short_Max;
                        break;

                    case "float":
                        float float_Min = float.MinValue;
                        float float_Max = float.MaxValue;
                        label1.Text = sdata01 + "의 하용값은" + 
                        float_Min + "~" +
                        float_Max;
                        break;

                    case "long":
                        long long_Min = long.MinValue;
                        long long_Max = long.MaxValue;
                        label1.Text = sdata01 + "의 하용값은" +
                        long_Min + "~" +
                        long_Max;
                        break;

                    case "sbyte":
                        sbyte sbyte_Min = sbyte.MinValue;
                        sbyte sbyte_Max = sbyte.MaxValue;
                        label1.Text = sdata01 + "의 하용값은" +
                        sbyte_Min + "~" +
                        sbyte_Max;
                        break;

                    case "ushort":
                        ushort ushort_Min = ushort.MinValue;
                        ushort ushort_Max = ushort.MaxValue;
                        label1.Text = sdata01 + "의 하용값은" +
                        ushort_Min + "~" +
                        ushort_Max;
                        break;

                    case "uint":
                        uint uint_Min = uint.MinValue;
                        uint uint_Max = uint.MaxValue;
                        label1.Text = sdata01 + "의 하용값은" +
                        uint_Min + "~" +
                        uint_Max;
                        break;

                    case "ulong":
                        ulong ulong_Min = ulong.MinValue;
                        ulong ulong_Max = ulong.MaxValue;
                        label1.Text = sdata01 + "의 하용값은" +
                        ulong_Min + "~" +
                        ulong_Max;
                        break;

                    default:
                        label1.Text = "알 수 없는 데이터 타입입니다.";
                        break;
                }
            }
            catch
            {

            }
        }
    }
}
