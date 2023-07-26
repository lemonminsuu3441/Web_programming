namespace 기말족보1
{
    public partial class Form1 : Form
    {
        int[] Array01;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Array01 = new int[6];
                System.Random Rannum = new System.Random();
                string str = "초기화 된 배열\n" + "\n";

                for (int i = 0; i < 6; i++)
                {
                    Array01[i] = Rannum.Next(1, 101);
                }
                for (int i = 0; i < 6; i++)
                {
                    if ((i + 1) % 3 == 0)
                    {
                        str += "        iarray[" + i + "] = " + Array01[i] + "\n";
                    }
                    else
                    {
                        str += "        iarray[" + i + "] = " + Array01[i] + "";
                    }
                    label1.Text = str;
                }
            }
            catch
            {
                label1.Text = "배열을 나열하는데 문제가 발생했습니다.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double vud = 0;
                for (int i = 0; i < Array01.Length; i++)
                {
                    vud += Array01[i];
                }
                double answer = vud / Array01.Length;
                label4.Text = "배열의 평균은: " + answer;
            }
            catch
            {
                label4.Text = "배열을 먼저 나열해주세요!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int min = Array01.Min();
                label3.Text = "배열의 최소값은: " + min;
            }
            catch
            {
                label3.Text = "배열을 먼저 나열해주세요!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int max = Array01.Max();
                label2.Text = "배열의 최댓값은: " + max;
            }
            catch
            {
                label2.Text = "배열을 먼저 나열해주세요!";
            }
        }
    }
}