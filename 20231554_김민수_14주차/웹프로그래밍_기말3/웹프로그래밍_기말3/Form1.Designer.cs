namespace 웹프로그래밍_기말3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            파일FToolStripMenuItem = new ToolStripMenuItem();
            파일열기OToolStripMenuItem = new ToolStripMenuItem();
            저장SToolStripMenuItem = new ToolStripMenuItem();
            저장SToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            종료XToolStripMenuItem = new ToolStripMenuItem();
            선굵기LToolStripMenuItem = new ToolStripMenuItem();
            보통Width2ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            굵게ToolStripMenuItem = new ToolStripMenuItem();
            선모양SToolStripMenuItem = new ToolStripMenuItem();
            실선ToolStripMenuItem = new ToolStripMenuItem();
            점선ToolStripMenuItem = new ToolStripMenuItem();
            실점선ToolStripMenuItem = new ToolStripMenuItem();
            색변경CToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 파일FToolStripMenuItem, 선굵기LToolStripMenuItem, 선모양SToolStripMenuItem, 색변경CToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(599, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            파일FToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 파일열기OToolStripMenuItem, 저장SToolStripMenuItem, 저장SToolStripMenuItem1, toolStripMenuItem1, 종료XToolStripMenuItem });
            파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            파일FToolStripMenuItem.Size = new Size(57, 20);
            파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 파일열기OToolStripMenuItem
            // 
            파일열기OToolStripMenuItem.Name = "파일열기OToolStripMenuItem";
            파일열기OToolStripMenuItem.Size = new Size(180, 22);
            파일열기OToolStripMenuItem.Text = "새 파일(&N)";
            파일열기OToolStripMenuItem.Click += 파일열기OToolStripMenuItem_Click;
            // 
            // 저장SToolStripMenuItem
            // 
            저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            저장SToolStripMenuItem.Size = new Size(180, 22);
            저장SToolStripMenuItem.Text = "열기(&O)";
            저장SToolStripMenuItem.Click += 저장SToolStripMenuItem_Click;
            // 
            // 저장SToolStripMenuItem1
            // 
            저장SToolStripMenuItem1.Name = "저장SToolStripMenuItem1";
            저장SToolStripMenuItem1.Size = new Size(180, 22);
            저장SToolStripMenuItem1.Text = "저장(&S)";
            저장SToolStripMenuItem1.Click += 저장SToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // 종료XToolStripMenuItem
            // 
            종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            종료XToolStripMenuItem.Size = new Size(180, 22);
            종료XToolStripMenuItem.Text = "종료(&X)";
            종료XToolStripMenuItem.Click += 종료XToolStripMenuItem_Click;
            // 
            // 선굵기LToolStripMenuItem
            // 
            선굵기LToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 보통Width2ToolStripMenuItem, toolStripMenuItem2, 굵게ToolStripMenuItem });
            선굵기LToolStripMenuItem.Name = "선굵기LToolStripMenuItem";
            선굵기LToolStripMenuItem.Size = new Size(73, 20);
            선굵기LToolStripMenuItem.Text = "선 굵기(&L)";
            // 
            // 보통Width2ToolStripMenuItem
            // 
            보통Width2ToolStripMenuItem.Name = "보통Width2ToolStripMenuItem";
            보통Width2ToolStripMenuItem.Size = new Size(98, 22);
            보통Width2ToolStripMenuItem.Text = "보통";
            보통Width2ToolStripMenuItem.Click += 보통Width2ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(95, 6);
            // 
            // 굵게ToolStripMenuItem
            // 
            굵게ToolStripMenuItem.Name = "굵게ToolStripMenuItem";
            굵게ToolStripMenuItem.Size = new Size(98, 22);
            굵게ToolStripMenuItem.Text = "굵게";
            굵게ToolStripMenuItem.Click += 굵게ToolStripMenuItem_Click;
            // 
            // 선모양SToolStripMenuItem
            // 
            선모양SToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 실선ToolStripMenuItem, 점선ToolStripMenuItem, 실점선ToolStripMenuItem });
            선모양SToolStripMenuItem.Name = "선모양SToolStripMenuItem";
            선모양SToolStripMenuItem.Size = new Size(74, 20);
            선모양SToolStripMenuItem.Text = "선 모양(&S)";
            // 
            // 실선ToolStripMenuItem
            // 
            실선ToolStripMenuItem.Name = "실선ToolStripMenuItem";
            실선ToolStripMenuItem.Size = new Size(110, 22);
            실선ToolStripMenuItem.Text = "실선";
            실선ToolStripMenuItem.Click += 실선ToolStripMenuItem_Click;
            // 
            // 점선ToolStripMenuItem
            // 
            점선ToolStripMenuItem.Name = "점선ToolStripMenuItem";
            점선ToolStripMenuItem.Size = new Size(110, 22);
            점선ToolStripMenuItem.Text = "점선";
            점선ToolStripMenuItem.Click += 점선ToolStripMenuItem_Click;
            // 
            // 실점선ToolStripMenuItem
            // 
            실점선ToolStripMenuItem.Name = "실점선ToolStripMenuItem";
            실점선ToolStripMenuItem.Size = new Size(110, 22);
            실점선ToolStripMenuItem.Text = "실점선";
            실점선ToolStripMenuItem.Click += 실점선ToolStripMenuItem_Click;
            // 
            // 색변경CToolStripMenuItem
            // 
            색변경CToolStripMenuItem.Name = "색변경CToolStripMenuItem";
            색변경CToolStripMenuItem.Size = new Size(75, 20);
            색변경CToolStripMenuItem.Text = "색 변경(&C)";
            색변경CToolStripMenuItem.Click += 색변경CToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(599, 524);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 551);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 파일FToolStripMenuItem;
        private ToolStripMenuItem 파일열기OToolStripMenuItem;
        private ToolStripMenuItem 저장SToolStripMenuItem;
        private ToolStripMenuItem 선굵기LToolStripMenuItem;
        private ToolStripMenuItem 보통Width2ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem 굵게ToolStripMenuItem;
        private ToolStripMenuItem 선모양SToolStripMenuItem;
        private ToolStripMenuItem 색변경CToolStripMenuItem;
        private ToolStripMenuItem 실선ToolStripMenuItem;
        private ToolStripMenuItem 점선ToolStripMenuItem;
        private ToolStripMenuItem 실점선ToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem 저장SToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem 종료XToolStripMenuItem;
    }
}