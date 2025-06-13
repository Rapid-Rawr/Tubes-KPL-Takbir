namespace WinFormsApp1.Views.Controls
{
    partial class FormSoal
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
            labelTambahEdit = new Label();
            labelSoal = new Label();
            tbSoal = new TextBox();
            labelOpsi = new Label();
            tbA = new TextBox();
            tbB = new TextBox();
            tbC = new TextBox();
            tbD = new TextBox();
            labelJawaban = new Label();
            tbJawaban = new TextBox();
            btnSimpan = new Button();
            labelA = new Label();
            labelB = new Label();
            labelC = new Label();
            labelD = new Label();
            SuspendLayout();
            // 
            // labelTambahEdit
            // 
            labelTambahEdit.AutoSize = true;
            labelTambahEdit.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTambahEdit.Location = new Point(28, 33);
            labelTambahEdit.Name = "labelTambahEdit";
            labelTambahEdit.Size = new Size(158, 16);
            labelTambahEdit.TabIndex = 1;
            labelTambahEdit.Text = "Tambah/Edit Soal Lokal";
            labelTambahEdit.Click += labelTambahEdit_Click;
            // 
            // labelSoal
            // 
            labelSoal.AutoSize = true;
            labelSoal.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSoal.Location = new Point(28, 86);
            labelSoal.Name = "labelSoal";
            labelSoal.Size = new Size(38, 15);
            labelSoal.TabIndex = 2;
            labelSoal.Text = "Soal :";
            // 
            // tbSoal
            // 
            tbSoal.Font = new Font("Arial", 9F);
            tbSoal.Location = new Point(28, 114);
            tbSoal.Name = "tbSoal";
            tbSoal.Size = new Size(540, 21);
            tbSoal.TabIndex = 3;
            tbSoal.TextChanged += tbSoal_TextChanged;
            // 
            // labelOpsi
            // 
            labelOpsi.AutoSize = true;
            labelOpsi.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOpsi.Location = new Point(28, 157);
            labelOpsi.Name = "labelOpsi";
            labelOpsi.Size = new Size(39, 15);
            labelOpsi.TabIndex = 4;
            labelOpsi.Text = "Opsi :";
            // 
            // tbA
            // 
            tbA.Font = new Font("Arial", 9F);
            tbA.Location = new Point(55, 188);
            tbA.Name = "tbA";
            tbA.Size = new Size(513, 21);
            tbA.TabIndex = 5;
            // 
            // tbB
            // 
            tbB.Font = new Font("Arial", 9F);
            tbB.Location = new Point(55, 228);
            tbB.Name = "tbB";
            tbB.Size = new Size(513, 21);
            tbB.TabIndex = 6;
            // 
            // tbC
            // 
            tbC.Font = new Font("Arial", 9F);
            tbC.Location = new Point(55, 268);
            tbC.Name = "tbC";
            tbC.Size = new Size(513, 21);
            tbC.TabIndex = 7;
            // 
            // tbD
            // 
            tbD.Font = new Font("Arial", 9F);
            tbD.Location = new Point(55, 308);
            tbD.Name = "tbD";
            tbD.Size = new Size(513, 21);
            tbD.TabIndex = 8;
            // 
            // labelJawaban
            // 
            labelJawaban.AutoSize = true;
            labelJawaban.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJawaban.Location = new Point(28, 352);
            labelJawaban.Name = "labelJawaban";
            labelJawaban.Size = new Size(65, 15);
            labelJawaban.TabIndex = 9;
            labelJawaban.Text = "Jawaban :";
            // 
            // tbJawaban
            // 
            tbJawaban.Font = new Font("Arial", 9F);
            tbJawaban.Location = new Point(28, 380);
            tbJawaban.Name = "tbJawaban";
            tbJawaban.Size = new Size(540, 21);
            tbJawaban.TabIndex = 10;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.OliveDrab;
            btnSimpan.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(483, 420);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(85, 36);
            btnSimpan.TabIndex = 11;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += button1_Click;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelA.Location = new Point(28, 191);
            labelA.Name = "labelA";
            labelA.Size = new Size(18, 15);
            labelA.TabIndex = 12;
            labelA.Text = "A.";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB.Location = new Point(28, 231);
            labelB.Name = "labelB";
            labelB.Size = new Size(18, 15);
            labelB.TabIndex = 13;
            labelB.Text = "B.";
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelC.Location = new Point(28, 271);
            labelC.Name = "labelC";
            labelC.Size = new Size(18, 15);
            labelC.TabIndex = 14;
            labelC.Text = "C.";
            // 
            // labelD
            // 
            labelD.AutoSize = true;
            labelD.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelD.Location = new Point(28, 311);
            labelD.Name = "labelD";
            labelD.Size = new Size(18, 15);
            labelD.TabIndex = 15;
            labelD.Text = "D.";
            // 
            // FormSoal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelD);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(btnSimpan);
            Controls.Add(tbJawaban);
            Controls.Add(labelJawaban);
            Controls.Add(tbD);
            Controls.Add(tbC);
            Controls.Add(tbB);
            Controls.Add(tbA);
            Controls.Add(labelOpsi);
            Controls.Add(tbSoal);
            Controls.Add(labelSoal);
            Controls.Add(labelTambahEdit);
            Font = new Font("Arial", 9F, FontStyle.Bold);
            Name = "FormSoal";
            Size = new Size(596, 491);
            Load += FormSoal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTambahEdit;
        private Label labelSoal;
        private TextBox tbSoal;
        private Label labelOpsi;
        private TextBox tbA;
        private TextBox tbB;
        private TextBox tbC;
        private TextBox tbD;
        private Label labelJawaban;
        private TextBox tbJawaban;
        private Button btnSimpan;
        private Label labelA;
        private Label labelB;
        private Label labelC;
        private Label labelD;
    }
}
