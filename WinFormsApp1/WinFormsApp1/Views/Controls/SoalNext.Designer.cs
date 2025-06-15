namespace WinFormsApp1.Views.Controls
{
    partial class SoalNext
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            quizzylogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)quizzylogo).BeginInit();
            SuspendLayout();
            // 
            // quizzylogo
            // 
            quizzylogo.Image = Properties.Resources.brain;
            quizzylogo.Location = new Point(41, 29);
            quizzylogo.Margin = new Padding(2, 3, 2, 3);
            quizzylogo.Name = "quizzylogo";
            quizzylogo.Size = new Size(47, 57);
            quizzylogo.SizeMode = PictureBoxSizeMode.StretchImage;
            quizzylogo.TabIndex = 0;
            quizzylogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumVioletRed;
            label1.Location = new Point(102, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 35);
            label1.TabIndex = 1;
            label1.Text = "QUIZZY";
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 156);
            label2.Name = "label2";
            label2.Size = new Size(586, 38);
            label2.TabIndex = 2;
            label2.Text = "eejhbdahkbsdhkfbaifbe";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(102, 212);
            button1.Name = "button1";
            button1.Size = new Size(586, 49);
            button1.TabIndex = 3;
            button1.Text = "A. jwb1";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(102, 280);
            button2.Name = "button2";
            button2.Size = new Size(586, 49);
            button2.TabIndex = 4;
            button2.Text = "B. jwb2";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(102, 349);
            button3.Name = "button3";
            button3.Size = new Size(586, 49);
            button3.TabIndex = 5;
            button3.Text = "C. jwb 3";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumVioletRed;
            button4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(102, 422);
            button4.Name = "button4";
            button4.Size = new Size(586, 49);
            button4.TabIndex = 6;
            button4.Text = "D. jwb 4";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.OliveDrab;
            button5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(737, 553);
            button5.Name = "button5";
            button5.Size = new Size(127, 48);
            button5.TabIndex = 7;
            button5.Text = "Next";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // SoalNext
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(quizzylogo);
            Name = "SoalNext";
            Size = new Size(948, 702);
            Load += skor_Load;
            ((System.ComponentModel.ISupportInitialize)quizzylogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox quizzylogo;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
