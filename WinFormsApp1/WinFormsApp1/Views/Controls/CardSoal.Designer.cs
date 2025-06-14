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
            btnHapus = new Button();
            btnEdit = new Button();
            labelNomor = new Label();
            SuspendLayout();
            // 
            // labelSoal
            // 
            labelSoal.AutoSize = true;
            labelSoal.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSoal.Location = new Point(23, 6);
            labelSoal.MaximumSize = new Size(700, 0);
            labelSoal.Name = "labelSoal";
            labelSoal.Size = new Size(40, 15);
            labelSoal.TabIndex = 0;
            labelSoal.Text = "soal...";
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Arial", 9F);
            labelA.Location = new Point(23, 31);
            labelA.Name = "labelA";
            labelA.Size = new Size(17, 15);
            labelA.TabIndex = 1;
            labelA.Text = "A.";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Font = new Font("Arial", 9F);
            labelB.Location = new Point(23, 51);
            labelB.Name = "labelB";
            labelB.Size = new Size(18, 15);
            labelB.TabIndex = 2;
            labelB.Text = "B.";
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Font = new Font("Arial", 9F);
            labelC.Location = new Point(23, 71);
            labelC.Name = "labelC";
            labelC.Size = new Size(19, 15);
            labelC.TabIndex = 3;
            labelC.Text = "C.";
            // 
            // labelD
            // 
            labelD.AutoSize = true;
            labelD.Font = new Font("Arial", 9F);
            labelD.Location = new Point(23, 91);
            labelD.Name = "labelD";
            labelD.Size = new Size(19, 15);
            labelD.TabIndex = 4;
            labelD.Text = "D.";
            // 
            // labelJawaban
            // 
            labelJawaban.AutoSize = true;
            labelJawaban.Font = new Font("Arial", 9F);
            labelJawaban.Location = new Point(23, 114);
            labelJawaban.Name = "labelJawaban";
            labelJawaban.Size = new Size(63, 15);
            labelJawaban.TabIndex = 5;
            labelJawaban.Text = "Jawaban :";
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.MediumVioletRed;
            btnHapus.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(461, 132);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(66, 27);
            btnHapus.TabIndex = 6;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkOrange;
            btnEdit.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(406, 132);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(51, 27);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += button2_Click;
            // 
            // labelNomor
            // 
            labelNomor.AutoSize = true;
            labelNomor.Location = new Point(6, 6);
            labelNomor.Name = "labelNomor";
            labelNomor.Size = new Size(13, 15);
            labelNomor.TabIndex = 8;
            labelNomor.Text = "1";
            // 
            // CardSoal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(labelNomor);
            Controls.Add(btnEdit);
            Controls.Add(btnHapus);
            Controls.Add(labelJawaban);
            Controls.Add(labelD);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(labelSoal);
            Name = "CardSoal";
            Size = new Size(534, 166);
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
        private Button btnHapus;
        private Button btnEdit;
        private Label labelNomor;
    }
}