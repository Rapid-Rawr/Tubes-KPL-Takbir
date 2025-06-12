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
            SideBarPanel.Margin = new Padding(2);
            SideBarPanel.Name = "SideBarPanel";
            SideBarPanel.Size = new Size(219, 491);
            SideBarPanel.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.MediumVioletRed;
            btnLogout.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(17, 218);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(185, 34);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnToHistoriPengerjaan
            // 
            btnToHistoriPengerjaan.BackColor = Color.MediumVioletRed;
            btnToHistoriPengerjaan.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToHistoriPengerjaan.ForeColor = Color.White;
            btnToHistoriPengerjaan.Location = new Point(17, 178);
            btnToHistoriPengerjaan.Name = "btnToHistoriPengerjaan";
            btnToHistoriPengerjaan.Size = new Size(185, 34);
            btnToHistoriPengerjaan.TabIndex = 0;
            btnToHistoriPengerjaan.Text = "Lihat Histori Pengerjaan";
            btnToHistoriPengerjaan.UseVisualStyleBackColor = false;
            // 
            // btnToSoalInternet
            // 
            btnToSoalInternet.BackColor = Color.MediumVioletRed;
            btnToSoalInternet.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToSoalInternet.ForeColor = Color.White;
            btnToSoalInternet.Location = new Point(17, 138);
            btnToSoalInternet.Name = "btnToSoalInternet";
            btnToSoalInternet.Size = new Size(185, 34);
            btnToSoalInternet.TabIndex = 0;
            btnToSoalInternet.Text = "Lihat Soal Internet";
            btnToSoalInternet.UseVisualStyleBackColor = false;
            // 
            // btnToKelolaSoal
            // 
            btnToKelolaSoal.BackColor = Color.MediumVioletRed;
            btnToKelolaSoal.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToKelolaSoal.ForeColor = Color.White;
            btnToKelolaSoal.Location = new Point(17, 98);
            btnToKelolaSoal.Name = "btnToKelolaSoal";
            btnToKelolaSoal.Size = new Size(185, 34);
            btnToKelolaSoal.TabIndex = 0;
            btnToKelolaSoal.Text = "Kelola Soal Lokal";
            btnToKelolaSoal.UseVisualStyleBackColor = false;
            btnToKelolaSoal.Click += button1_Click;
            // 
            // QuizzyLogo
            // 
            QuizzyLogo.Image = Properties.Resources.brain;
            QuizzyLogo.Location = new Point(36, 22);
            QuizzyLogo.Margin = new Padding(2);
            QuizzyLogo.Name = "QuizzyLogo";
            QuizzyLogo.Size = new Size(41, 43);
            QuizzyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            QuizzyLogo.TabIndex = 1;
            QuizzyLogo.TabStop = false;
            // 
            // QuizzyLabel
            // 
            QuizzyLabel.AutoSize = true;
            QuizzyLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuizzyLabel.ForeColor = Color.MediumVioletRed;
            QuizzyLabel.Location = new Point(89, 29);
            QuizzyLabel.Margin = new Padding(2, 0, 2, 0);
            QuizzyLabel.Name = "QuizzyLabel";
            QuizzyLabel.Size = new Size(98, 29);
            QuizzyLabel.TabIndex = 0;
            QuizzyLabel.Text = "QUIZZY";
            QuizzyLabel.Click += label1_Click;
            // 
            // ContentPanel
            // 
            ContentPanel.BackColor = Color.White;
            ContentPanel.Location = new Point(218, 0);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(596, 491);
            ContentPanel.TabIndex = 1;
            // 
            // WFAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 491);
            Controls.Add(ContentPanel);
            Controls.Add(SideBarPanel);
            Margin = new Padding(2);
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