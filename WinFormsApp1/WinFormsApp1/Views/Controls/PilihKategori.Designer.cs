namespace WinFormsApp1.Views.Controls
{
    partial class PilihKategori
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
            label1 = new Label();
            btnKomputer = new Button();
            btnMatematika = new Button();
            btnIPA = new Button();
            btnGeografi = new Button();
            btnSoalLokal = new Button();
            btnSejarah = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 148);
            label1.Name = "label1";
            label1.Size = new Size(195, 38);
            label1.TabIndex = 0;
            label1.Text = "Pilih Kategori";
            // 
            // btnKomputer
            // 
            btnKomputer.BackColor = Color.OliveDrab;
            btnKomputer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKomputer.ForeColor = Color.White;
            btnKomputer.Location = new Point(171, 249);
            btnKomputer.Name = "btnKomputer";
            btnKomputer.Size = new Size(173, 53);
            btnKomputer.TabIndex = 1;
            btnKomputer.Text = "Komputer";
            btnKomputer.UseVisualStyleBackColor = false;
            btnKomputer.Click += btnKomputer_Click;
            // 
            // btnMatematika
            // 
            btnMatematika.BackColor = Color.MediumVioletRed;
            btnMatematika.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMatematika.ForeColor = Color.White;
            btnMatematika.Location = new Point(350, 249);
            btnMatematika.Name = "btnMatematika";
            btnMatematika.Size = new Size(244, 53);
            btnMatematika.TabIndex = 2;
            btnMatematika.Text = "Matematika";
            btnMatematika.UseVisualStyleBackColor = false;
            btnMatematika.Click += btnMatematika_Click;
            // 
            // btnIPA
            // 
            btnIPA.BackColor = Color.DarkOrange;
            btnIPA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIPA.ForeColor = Color.White;
            btnIPA.Location = new Point(171, 318);
            btnIPA.Name = "btnIPA";
            btnIPA.Size = new Size(231, 53);
            btnIPA.TabIndex = 3;
            btnIPA.Text = "IPA";
            btnIPA.UseVisualStyleBackColor = false;
            btnIPA.Click += btnIPA_Click;
            // 
            // btnGeografi
            // 
            btnGeografi.BackColor = Color.DodgerBlue;
            btnGeografi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGeografi.ForeColor = Color.White;
            btnGeografi.Location = new Point(408, 318);
            btnGeografi.Name = "btnGeografi";
            btnGeografi.Size = new Size(186, 53);
            btnGeografi.TabIndex = 4;
            btnGeografi.Text = "Geografi";
            btnGeografi.UseVisualStyleBackColor = false;
            btnGeografi.Click += btnGeografi_Click;
            // 
            // btnSoalLokal
            // 
            btnSoalLokal.BackColor = Color.OliveDrab;
            btnSoalLokal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSoalLokal.ForeColor = Color.White;
            btnSoalLokal.Location = new Point(383, 386);
            btnSoalLokal.Name = "btnSoalLokal";
            btnSoalLokal.Size = new Size(211, 53);
            btnSoalLokal.TabIndex = 5;
            btnSoalLokal.Text = "Soal Lokal";
            btnSoalLokal.UseVisualStyleBackColor = false;
            btnSoalLokal.Click += button5_Click;
            // 
            // btnSejarah
            // 
            btnSejarah.BackColor = Color.MediumVioletRed;
            btnSejarah.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSejarah.ForeColor = Color.White;
            btnSejarah.Location = new Point(171, 386);
            btnSejarah.Name = "btnSejarah";
            btnSejarah.Size = new Size(211, 53);
            btnSejarah.TabIndex = 6;
            btnSejarah.Text = "Sejarah";
            btnSejarah.UseVisualStyleBackColor = false;
            btnSejarah.Click += btnSejarah_Click;
            // 
            // PilihKategori
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSejarah);
            Controls.Add(btnSoalLokal);
            Controls.Add(btnGeografi);
            Controls.Add(btnIPA);
            Controls.Add(btnMatematika);
            Controls.Add(btnKomputer);
            Controls.Add(label1);
            Name = "PilihKategori";
            Size = new Size(851, 818);
            Load += PilihKategori_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnKomputer;
        private Button btnMatematika;
        private Button btnIPA;
        private Button btnGeografi;
        private Button btnSoalLokal;
        private Button btnSejarah;
    }
}
