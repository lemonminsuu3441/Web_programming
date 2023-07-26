namespace 웹프로그래밍_기말3
{
    public partial class Form1 : Form
    {
        bool hasfilename = false;
        string sfilename = "";

        bool isDrag = false;
        bool Modified = false;
        Bitmap MyBitmap;
        Pen myPen = new Pen(Color.Black, 2);
        private Point Point1;
        private Point Point2;
        public Form1()
        {
            InitializeComponent();
        }

        private void 보통Width2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPen.Width = 2;
        }

        private void 파일열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modified == true)
                {
                    DialogResult answer = MessageBox.Show(
                        "변경된 내용을 저장하고 새로 만들겠습니까?", "저장",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        if (hasfilename == true)
                        {
                            System.IO.StreamWriter fs =
                                System.IO.File.CreateText(sfilename);
                            fs.Close();
                            Modified = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                sfilename = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs =
                                    System.IO.File.CreateText(sfilename);
                                fs.Close();
                                hasfilename = true;
                                Modified = false;
                            }
                        }
                        MyBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        pictureBox1.Image = MyBitmap;

                        Graphics g = Graphics.FromImage(pictureBox1.Image);
                        g.Clear(Color.White);
                        g.Dispose();
                        Modified = false;
                    }
                    else if (answer == DialogResult.No)
                    {
                        MyBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        pictureBox1.Image = MyBitmap;

                        Graphics g = Graphics.FromImage(pictureBox1.Image);
                        g.Clear(Color.White);
                        g.Dispose();
                        Modified = false;
                    }

                }

                Modified = false;
                hasfilename = false;
                sfilename = "";
            }
            catch
            {
                MessageBox.Show("새 파일을 준비하는 도중 이상이 발생했습니다.",
                    "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            Point1.X = e.X;
            Point1.Y = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = MyBitmap;

            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            g.Dispose();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                Point2.X = e.X;
                Point2.Y = e.Y;
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                g.DrawLine(myPen, Point1, Point2);
                pictureBox1.Refresh();
                g.Dispose();
                Point1 = Point2;
                Modified = true;
            }
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modified == true)
            {
                DialogResult answer = MessageBox.Show(
                    "변경된 내용을 저장하시겠습니까?", "저장",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    if (hasfilename == true)
                    {
                        System.IO.StreamWriter fs =
                            System.IO.File.CreateText(sfilename);
                        fs.WriteLine(pictureBox1.Image);
                        fs.Close();
                        Modified = false;
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            sfilename = saveFileDialog1.FileName;
                            System.IO.StreamWriter fs =
                                System.IO.File.CreateText(sfilename);
                            fs.WriteLine(pictureBox1.Image);
                            fs.Close();
                            hasfilename = true;
                            Modified = false;
                        }
                    }
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        sfilename = openFileDialog1.FileName;
                        System.IO.StreamReader fs =
                            System.IO.File.OpenText(sfilename);
                        fs.Close();
                        hasfilename = true;
                        Modified = false;
                    }

                }
                else if (answer == DialogResult.No)
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        sfilename = openFileDialog1.FileName;
                        System.IO.StreamReader fs =
                            System.IO.File.OpenText(sfilename);
                        fs.Close();
                        hasfilename = true;
                        Modified = false;
                    }

                }
            }
        }

        private void 저장SToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (hasfilename == true)
            {
                System.IO.StreamWriter fs =
                    System.IO.File.CreateText(sfilename);
                fs.Close();
                Modified = false;
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog1.FilterIndex == 1)
                    {
                        pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else if (saveFileDialog1.FilterIndex == 2)
                    {
                        pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    }
                    else if (saveFileDialog1.FilterIndex == 3)
                    {
                        pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                    }
                    Modified = false;
                }
            }
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 굵게ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPen.Width = 5;
        }

        private void 색변경CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                myPen.Color = colorDialog1.Color;
            }
        }

        private void 실선ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        private void 점선ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void 실점선ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Modified)
            {
                DialogResult answer = MessageBox.Show("변경된 내용을 저장하고 종료 하겠습니까?",
                    " 그림판", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                    저장SToolStripMenuItem1_Click(sender, e);
                else if (answer == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}