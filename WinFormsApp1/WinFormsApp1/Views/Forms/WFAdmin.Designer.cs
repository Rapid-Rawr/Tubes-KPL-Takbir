namespace WinFormsApp1.Views.Forms
{
    partial class WFAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            SideBarPanel.Name = "SideBarPanel";
            SideBarPanel.Size = new Size(313, 818);
            SideBarPanel.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.MediumVioletRed;
            btnLogout.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(24, 363);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(264, 57);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnToHistoriPengerjaan
            // 
            btnToHistoriPengerjaan.BackColor = Color.MediumVioletRed;
            btnToHistoriPengerjaan.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnToHistoriPengerjaan.ForeColor = Color.White;
            btnToHistoriPengerjaan.Location = new Point(24, 297);
            btnToHistoriPengerjaan.Name = "btnToHistoriPengerjaan";
            btnToHistoriPengerjaan.Size = new Size(264, 57);
            btnToHistoriPengerjaan.TabIndex = 0;
            btnToHistoriPengerjaan.Text = "Lihat Histori Pengerjaan";
            btnToHistoriPengerjaan.UseVisualStyleBackColor = false;
            btnToHistoriPengerjaan.Click += btnToHistoriPengerjaan_Click;
            // 
            // btnToSoalInternet
            // 
            btnToSoalInternet.BackColor = Color.MediumVioletRed;
            btnToSoalInternet.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnToSoalInternet.ForeColor = Color.White;
            btnToSoalInternet.Location = new Point(24, 230);
            btnToSoalInternet.Name = "btnToSoalInternet";
            btnToSoalInternet.Size = new Size(264, 57);
            btnToSoalInternet.TabIndex = 0;
            btnToSoalInternet.Text = "Lihat Soal Internet";
            btnToSoalInternet.UseVisualStyleBackColor = false;
            btnToSoalInternet.Click += btnToSoalInternet_Click;
            // 
            // btnToKelolaSoal
            // 
            btnToKelolaSoal.BackColor = Color.MediumVioletRed;
            btnToKelolaSoal.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnToKelolaSoal.ForeColor = Color.White;
            btnToKelolaSoal.Location = new Point(24, 163);
            btnToKelolaSoal.Name = "btnToKelolaSoal";
            btnToKelolaSoal.Size = new Size(264, 57);
            btnToKelolaSoal.TabIndex = 0;
            btnToKelolaSoal.Text = "Kelola Soal Lokal";
            btnToKelolaSoal.UseVisualStyleBackColor = false;
            btnToKelolaSoal.Click += button1_Click;
            // 
            // QuizzyLogo
            // 
            QuizzyLogo.Image = Properties.Resources.brain;
            QuizzyLogo.Location = new Point(51, 37);
            QuizzyLogo.Name = "QuizzyLogo";
            QuizzyLogo.Size = new Size(59, 72);
            QuizzyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            QuizzyLogo.TabIndex = 1;
            QuizzyLogo.TabStop = false;
            // 
            // QuizzyLabel
            // 
            QuizzyLabel.AutoSize = true;
            QuizzyLabel.Font = new Font("Arial", 18F, FontStyle.Bold);
            QuizzyLabel.ForeColor = Color.MediumVioletRed;
            QuizzyLabel.Location = new Point(127, 48);
            QuizzyLabel.Name = "QuizzyLabel";
            QuizzyLabel.Size = new Size(149, 43);
            QuizzyLabel.TabIndex = 0;
            QuizzyLabel.Text = "QUIZZY";
            QuizzyLabel.Click += label1_Click;
            // 
            // ContentPanel
            // 
            ContentPanel.BackColor = Color.White;
            ContentPanel.Location = new Point(311, 0);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(851, 818);
            ContentPanel.TabIndex = 1;
            ContentPanel.Paint += ContentPanel_Paint;
            // 
            // WFAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 818);
            Controls.Add(ContentPanel);
            Controls.Add(SideBarPanel);
            Name = "WFAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
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
