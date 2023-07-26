namespace 기말족보_2번
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
                label1.Text = textBox1.Text + " 님의 정보";

                string radiovalue = "";
                if (radioButton1.Checked)
                {
                    radiovalue = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    radiovalue = radioButton2.Text;
                }
                label5.Text = "성별 : " + radiovalue;

                label6.Text = "생년월일 : " + comboBox1.SelectedItem + " 년 " + comboBox2.SelectedItem + " 월 " + comboBox3.SelectedItem + " 일 ";
            }
            catch
            {

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            int index = comboBox2.SelectedIndex + 1;

            if (index == 1 || index == 3 || index == 5 || index == 7 || index == 8 || index == 10 || index == 12)
            {
                for (int i = 0; i < 31; i++)
                {
                    comboBox3.Items.Add(i + 1);
                }
            }
            else if (index == 4 || index == 6 || index == 9 || index == 11)
            {
                for (int i = 0; i < 30; i++)
                {
                    comboBox3.Items.Add(i + 1);
                }
            }
            else
            {
                for (int i = 0; i < 28; i++)
                {
                    comboBox3.Items.Add(i + 1);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}