namespace WinFormsApp1.Views.Forms
{
    partial class WFAdmin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SideBarPanel = new Panel();
            btnLogout = new Button();
            btnToHistoriPengerjaan = new Button();
            btnToSoalInternet = new Button();
            btnToKelolaSoal = new Button();
            QuizzyLogo = new PictureBox();
            QuizzyLabel = new Label();
            ContentPanel = new Panel();
            SideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuizzyLogo).BeginInit();
            SuspendLayout();
            // 
            // SideBarPanel
            // 
            SideBarPanel.BackColor = Color.FromArgb(255, 227, 242);
            SideBarPanel.Controls.Add(btnLogout);
            SideBarPanel.Controls.Add(btnToHistoriPengerjaan);
            SideBarPanel.Controls.Add(btnToSoalInternet);
            SideBarPanel.Controls.Add(btnToKelolaSoal);
            SideBarPanel.Controls.Add(QuizzyLogo);
            SideBarPanel.Controls.Add(QuizzyLabel);
            SideBarPanel.ForeColor = Color.Plum;
            SideBarPanel.Location = new Point(0, 0);
<<<<<<< HEAD
            SideBarPanel.Name = "SideBarPanel";
            SideBarPanel.Size = new Size(313, 818);
=======
            SideBarPanel.Margin = new Padding(2, 3, 2, 3);
            SideBarPanel.Name = "SideBarPanel";
            SideBarPanel.Size = new Size(250, 655);
>>>>>>> 01decc9 (fitur login dan register)
            SideBarPanel.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.MediumVioletRed;
            btnLogout.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
<<<<<<< HEAD
            btnLogout.Location = new Point(24, 363);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(264, 57);
=======
            btnLogout.Location = new Point(19, 291);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(211, 45);
>>>>>>> 01decc9 (fitur login dan register)
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnToHistoriPengerjaan
            // 
            btnToHistoriPengerjaan.BackColor = Color.MediumVioletRed;
            btnToHistoriPengerjaan.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToHistoriPengerjaan.ForeColor = Color.White;
<<<<<<< HEAD
            btnToHistoriPengerjaan.Location = new Point(24, 297);
            btnToHistoriPengerjaan.Margin = new Padding(4, 5, 4, 5);
            btnToHistoriPengerjaan.Name = "btnToHistoriPengerjaan";
            btnToHistoriPengerjaan.Size = new Size(264, 57);
=======
            btnToHistoriPengerjaan.Location = new Point(19, 237);
            btnToHistoriPengerjaan.Margin = new Padding(3, 4, 3, 4);
            btnToHistoriPengerjaan.Name = "btnToHistoriPengerjaan";
            btnToHistoriPengerjaan.Size = new Size(211, 45);
>>>>>>> 01decc9 (fitur login dan register)
            btnToHistoriPengerjaan.TabIndex = 0;
            btnToHistoriPengerjaan.Text = "Lihat Histori Pengerjaan";
            btnToHistoriPengerjaan.UseVisualStyleBackColor = false;
            // 
            // btnToSoalInternet
            // 
            btnToSoalInternet.BackColor = Color.MediumVioletRed;
            btnToSoalInternet.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToSoalInternet.ForeColor = Color.White;
<<<<<<< HEAD
            btnToSoalInternet.Location = new Point(24, 230);
            btnToSoalInternet.Margin = new Padding(4, 5, 4, 5);
            btnToSoalInternet.Name = "btnToSoalInternet";
            btnToSoalInternet.Size = new Size(264, 57);
=======
            btnToSoalInternet.Location = new Point(19, 184);
            btnToSoalInternet.Margin = new Padding(3, 4, 3, 4);
            btnToSoalInternet.Name = "btnToSoalInternet";
            btnToSoalInternet.Size = new Size(211, 45);
>>>>>>> 01decc9 (fitur login dan register)
            btnToSoalInternet.TabIndex = 0;
            btnToSoalInternet.Text = "Lihat Soal Internet";
            btnToSoalInternet.UseVisualStyleBackColor = false;
            // 
            // btnToKelolaSoal
            // 
            btnToKelolaSoal.BackColor = Color.MediumVioletRed;
            btnToKelolaSoal.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToKelolaSoal.ForeColor = Color.White;
<<<<<<< HEAD
            btnToKelolaSoal.Location = new Point(24, 163);
            btnToKelolaSoal.Margin = new Padding(4, 5, 4, 5);
            btnToKelolaSoal.Name = "btnToKelolaSoal";
            btnToKelolaSoal.Size = new Size(264, 57);
=======
            btnToKelolaSoal.Location = new Point(19, 131);
            btnToKelolaSoal.Margin = new Padding(3, 4, 3, 4);
            btnToKelolaSoal.Name = "btnToKelolaSoal";
            btnToKelolaSoal.Size = new Size(211, 45);
>>>>>>> 01decc9 (fitur login dan register)
            btnToKelolaSoal.TabIndex = 0;
            btnToKelolaSoal.Text = "Kelola Soal Lokal";
            btnToKelolaSoal.UseVisualStyleBackColor = false;
            btnToKelolaSoal.Click += button1_Click;
            // 
            // QuizzyLogo
            // 
            QuizzyLogo.Image = Properties.Resources.brain;
<<<<<<< HEAD
            QuizzyLogo.Location = new Point(51, 37);
            QuizzyLogo.Name = "QuizzyLogo";
            QuizzyLogo.Size = new Size(59, 72);
=======
            QuizzyLogo.Location = new Point(41, 29);
            QuizzyLogo.Margin = new Padding(2, 3, 2, 3);
            QuizzyLogo.Name = "QuizzyLogo";
            QuizzyLogo.Size = new Size(47, 57);
>>>>>>> 01decc9 (fitur login dan register)
            QuizzyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            QuizzyLogo.TabIndex = 1;
            QuizzyLogo.TabStop = false;
            // 
            // QuizzyLabel
            // 
            QuizzyLabel.AutoSize = true;
            QuizzyLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuizzyLabel.ForeColor = Color.MediumVioletRed;
<<<<<<< HEAD
            QuizzyLabel.Location = new Point(127, 48);
            QuizzyLabel.Name = "QuizzyLabel";
            QuizzyLabel.Size = new Size(149, 43);
=======
            QuizzyLabel.Location = new Point(102, 39);
            QuizzyLabel.Margin = new Padding(2, 0, 2, 0);
            QuizzyLabel.Name = "QuizzyLabel";
            QuizzyLabel.Size = new Size(124, 35);
>>>>>>> 01decc9 (fitur login dan register)
            QuizzyLabel.TabIndex = 0;
            QuizzyLabel.Text = "QUIZZY";
            QuizzyLabel.Click += label1_Click;
            // 
            // ContentPanel
            // 
            ContentPanel.BackColor = Color.White;
<<<<<<< HEAD
            ContentPanel.Location = new Point(311, 0);
            ContentPanel.Margin = new Padding(4, 5, 4, 5);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(851, 818);
=======
            ContentPanel.Location = new Point(249, 0);
            ContentPanel.Margin = new Padding(3, 4, 3, 4);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(681, 655);
>>>>>>> 01decc9 (fitur login dan register)
            ContentPanel.TabIndex = 1;
            ContentPanel.Paint += ContentPanel_Paint;
            // 
            // WFAdmin
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 818);
            Controls.Add(ContentPanel);
            Controls.Add(SideBarPanel);
=======
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 655);
            Controls.Add(ContentPanel);
            Controls.Add(SideBarPanel);
            Margin = new Padding(2, 3, 2, 3);
>>>>>>> 01decc9 (fitur login dan register)
            Name = "WFAdmin";
            Text = "Form2";
            SideBarPanel.ResumeLayout(false);
            SideBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuizzyLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SideBarPanel;
        private Label QuizzyLabel;
        private PictureBox QuizzyLogo;
        private Panel ContentPanel;
        private Button btnToKelolaSoal;
        private Button btnToHistoriPengerjaan;
        private Button btnToSoalInternet;
        private Button btnLogout;
    }
}