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
            labelPertanyaan = new Label();
            btnOpsiA = new Button();
            btnOpsiB = new Button();
            btnOpsiC = new Button();
            btnOpsiD = new Button();
            btnNextSoal = new Button();
            labelA = new Label();
            labelB = new Label();
            labelC = new Label();
            labelD = new Label();
            ((System.ComponentModel.ISupportInitialize)quizzylogo).BeginInit();
            SuspendLayout();
            // 
            // quizzylogo
            // 
            quizzylogo.Image = Properties.Resources.brain;
            quizzylogo.Location = new Point(61, 53);
            quizzylogo.Margin = new Padding(2, 4, 2, 4);
            quizzylogo.Name = "quizzylogo";
            quizzylogo.Size = new Size(73, 78);
            quizzylogo.SizeMode = PictureBoxSizeMode.StretchImage;
            quizzylogo.TabIndex = 0;
            quizzylogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumVioletRed;
            label1.Location = new Point(153, 70);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 43);
            label1.TabIndex = 1;
            label1.Text = "QUIZZY";
            // 
            // labelPertanyaan
            // 
            labelPertanyaan.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPertanyaan.Location = new Point(68, 200);
            labelPertanyaan.Margin = new Padding(4, 0, 4, 0);
            labelPertanyaan.Name = "labelPertanyaan";
            labelPertanyaan.Size = new Size(732, 48);
            labelPertanyaan.TabIndex = 2;
            labelPertanyaan.Text = "eejhbdahkbsdhkfbaifbe";
            labelPertanyaan.Click += label2_Click;
            // 
            // btnOpsiA
            // 
            btnOpsiA.BackColor = Color.OliveDrab;
            btnOpsiA.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpsiA.ForeColor = Color.White;
            btnOpsiA.Location = new Point(121, 267);
            btnOpsiA.Margin = new Padding(4);
            btnOpsiA.Name = "btnOpsiA";
            btnOpsiA.Size = new Size(732, 61);
            btnOpsiA.TabIndex = 3;
            btnOpsiA.Text = "A. jwb1";
            btnOpsiA.TextAlign = ContentAlignment.MiddleLeft;
            btnOpsiA.UseVisualStyleBackColor = false;
            btnOpsiA.Click += button1_Click;
            // 
            // btnOpsiB
            // 
            btnOpsiB.BackColor = Color.DarkOrange;
            btnOpsiB.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnOpsiB.ForeColor = Color.White;
            btnOpsiB.Location = new Point(121, 357);
            btnOpsiB.Margin = new Padding(4);
            btnOpsiB.Name = "btnOpsiB";
            btnOpsiB.Size = new Size(732, 61);
            btnOpsiB.TabIndex = 4;
            btnOpsiB.Text = "B. jwb2";
            btnOpsiB.TextAlign = ContentAlignment.MiddleLeft;
            btnOpsiB.UseVisualStyleBackColor = false;
            // 
            // btnOpsiC
            // 
            btnOpsiC.BackColor = Color.DodgerBlue;
            btnOpsiC.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnOpsiC.ForeColor = Color.White;
            btnOpsiC.Location = new Point(121, 448);
            btnOpsiC.Margin = new Padding(4);
            btnOpsiC.Name = "btnOpsiC";
            btnOpsiC.Size = new Size(732, 61);
            btnOpsiC.TabIndex = 5;
            btnOpsiC.Text = "C. jwb 3";
            btnOpsiC.TextAlign = ContentAlignment.MiddleLeft;
            btnOpsiC.UseVisualStyleBackColor = false;
            // 
            // btnOpsiD
            // 
            btnOpsiD.BackColor = Color.MediumVioletRed;
            btnOpsiD.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnOpsiD.ForeColor = Color.White;
            btnOpsiD.Location = new Point(121, 539);
            btnOpsiD.Margin = new Padding(4);
            btnOpsiD.Name = "btnOpsiD";
            btnOpsiD.Size = new Size(732, 61);
            btnOpsiD.TabIndex = 6;
            btnOpsiD.Text = "D. jwb 4";
            btnOpsiD.TextAlign = ContentAlignment.MiddleLeft;
            btnOpsiD.UseVisualStyleBackColor = false;
            // 
            // btnNextSoal
            // 
            btnNextSoal.BackColor = Color.OliveDrab;
            btnNextSoal.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextSoal.ForeColor = Color.White;
            btnNextSoal.Location = new Point(861, 696);
            btnNextSoal.Margin = new Padding(4);
            btnNextSoal.MaximumSize = new Size(700, 0);
            btnNextSoal.Name = "btnNextSoal";
            btnNextSoal.Size = new Size(159, 0);
            btnNextSoal.TabIndex = 7;
            btnNextSoal.Text = "Next";
            btnNextSoal.UseVisualStyleBackColor = false;
            btnNextSoal.Click += button5_Click;
            // 
            // labelA
            // 
            labelA.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelA.Location = new Point(68, 280);
            labelA.Margin = new Padding(4, 0, 4, 0);
            labelA.Name = "labelA";
            labelA.Size = new Size(45, 48);
            labelA.TabIndex = 8;
            labelA.Text = "A.";
            // 
            // labelB
            // 
            labelB.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB.Location = new Point(68, 370);
            labelB.Margin = new Padding(4, 0, 4, 0);
            labelB.Name = "labelB";
            labelB.Size = new Size(45, 48);
            labelB.TabIndex = 9;
            labelB.Text = "B.";
            // 
            // labelC
            // 
            labelC.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelC.Location = new Point(68, 461);
            labelC.Margin = new Padding(4, 0, 4, 0);
            labelC.Name = "labelC";
            labelC.Size = new Size(45, 48);
            labelC.TabIndex = 10;
            labelC.Text = "C.";
            // 
            // labelD
            // 
            labelD.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelD.Location = new Point(68, 552);
            labelD.Margin = new Padding(4, 0, 4, 0);
            labelD.Name = "labelD";
            labelD.Size = new Size(45, 48);
            labelD.TabIndex = 11;
            labelD.Text = "D.";
            // 
            // SoalNext
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelD);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(btnNextSoal);
            Controls.Add(btnOpsiD);
            Controls.Add(btnOpsiC);
            Controls.Add(btnOpsiB);
            Controls.Add(btnOpsiA);
            Controls.Add(labelPertanyaan);
            Controls.Add(label1);
            Controls.Add(quizzylogo);
            Margin = new Padding(4);
            Name = "SoalNext";
            Size = new Size(1185, 874);
            Load += skor_Load;
            ((System.ComponentModel.ISupportInitialize)quizzylogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox quizzylogo;
        private Label label1;
        private Label labelPertanyaan;
        private Button btnOpsiA;
        private Button btnOpsiB;
        private Button btnOpsiC;
        private Button btnOpsiD;
        private Button btnNextSoal;
        private Label labelA;
        private Label labelB;
        private Label labelC;
        private Label labelD;
    }
}
