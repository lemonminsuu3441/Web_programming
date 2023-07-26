namespace 기말족보1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(44, 58);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "숫자 넣기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(44, 223);
            button2.Name = "button2";
            button2.Size = new Size(124, 29);
            button2.TabIndex = 1;
            button2.Text = "배열의 최대값";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(44, 269);
            button3.Name = "button3";
            button3.Size = new Size(124, 29);
            button3.TabIndex = 2;
            button3.Text = "배열의 최소값";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(44, 316);
            button4.Name = "button4";
            button4.Size = new Size(124, 29);
            button4.TabIndex = 3;
            button4.Text = "배열의 평균";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 111);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 4;
            label1.Text = "초기화 된 배열";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 223);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 5;
            label2.Text = "배열의 최대값";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 273);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 6;
            label3.Text = "배열의 최솟값";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 316);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 7;
            label4.Text = "배열의 평균";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}