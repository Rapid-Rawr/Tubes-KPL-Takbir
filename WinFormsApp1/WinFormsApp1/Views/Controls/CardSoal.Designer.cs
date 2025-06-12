namespace WinFormsApp1.Views.Controls
{
    partial class CardSoal
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
            labelSoal = new Label();
            labelA = new Label();
            labelB = new Label();
            labelC = new Label();
            labelD = new Label();
            labelJawaban = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // labelSoal
            // 
            labelSoal.AutoSize = true;
            labelSoal.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSoal.Location = new Point(6, 6);
            labelSoal.Name = "labelSoal";
            labelSoal.Size = new Size(40, 15);
            labelSoal.TabIndex = 0;
            labelSoal.Text = "soal...";
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Arial", 9F);
            labelA.Location = new Point(6, 30);
            labelA.Name = "labelA";
            labelA.Size = new Size(17, 15);
            labelA.TabIndex = 1;
            labelA.Text = "A.";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Font = new Font("Arial", 9F);
            labelB.Location = new Point(6, 50);
            labelB.Name = "labelB";
            labelB.Size = new Size(18, 15);
            labelB.TabIndex = 2;
            labelB.Text = "B.";
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Font = new Font("Arial", 9F);
            labelC.Location = new Point(6, 70);
            labelC.Name = "labelC";
            labelC.Size = new Size(19, 15);
            labelC.TabIndex = 3;
            labelC.Text = "C.";
            // 
            // labelD
            // 
            labelD.AutoSize = true;
            labelD.Font = new Font("Arial", 9F);
            labelD.Location = new Point(6, 90);
            labelD.Name = "labelD";
            labelD.Size = new Size(19, 15);
            labelD.TabIndex = 4;
            labelD.Text = "D.";
            // 
            // labelJawaban
            // 
            labelJawaban.AutoSize = true;
            labelJawaban.Font = new Font("Arial", 9F);
            labelJawaban.Location = new Point(6, 114);
            labelJawaban.Name = "labelJawaban";
            labelJawaban.Size = new Size(63, 15);
            labelJawaban.TabIndex = 5;
            labelJawaban.Text = "Jawaban :";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumVioletRed;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(461, 106);
            button1.Name = "button1";
            button1.Size = new Size(66, 27);
            button1.TabIndex = 6;
            button1.Text = "Hapus";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(406, 106);
            button2.Name = "button2";
            button2.Size = new Size(51, 27);
            button2.TabIndex = 7;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CardSoal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelJawaban);
            Controls.Add(labelD);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(labelSoal);
            Name = "CardSoal";
            Size = new Size(534, 139);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSoal;
        private Label labelA;
        private Label labelB;
        private Label labelC;
        private Label labelD;
        private Label labelJawaban;
        private Button button1;
        private Button button2;
    }
}