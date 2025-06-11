namespace WinFormsApp1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
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
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 9F);
            textBox1.Location = new Point(55, 188);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(513, 21);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 9F);
            textBox2.Location = new Point(55, 228);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(513, 21);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 9F);
            textBox3.Location = new Point(55, 268);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(513, 21);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 9F);
            textBox4.Location = new Point(55, 308);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(513, 21);
            textBox4.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 352);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 9;
            label1.Text = "Jawaban :";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial", 9F);
            textBox5.Location = new Point(28, 380);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(540, 21);
            textBox5.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(483, 420);
            button1.Name = "button1";
            button1.Size = new Size(85, 36);
            button1.TabIndex = 11;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = false;
            // 
            // FormSoal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelOpsi);
            Controls.Add(tbSoal);
            Controls.Add(labelSoal);
            Controls.Add(labelTambahEdit);
            Font = new Font("Arial", 9F, FontStyle.Bold);
            Name = "FormSoal";
            Size = new Size(596, 491);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTambahEdit;
        private Label labelSoal;
        private TextBox tbSoal;
        private Label labelOpsi;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private TextBox textBox5;
        private Button button1;
    }
}
