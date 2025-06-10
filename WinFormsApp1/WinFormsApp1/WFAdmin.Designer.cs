namespace WinFormsApp1
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
            BtnLogout = new Button();
            BtnToHistoriPengerjaan = new Button();
            BtnToSoalInternet = new Button();
            BtnToKelolaSoal = new Button();
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
            SideBarPanel.Controls.Add(BtnLogout);
            SideBarPanel.Controls.Add(BtnToHistoriPengerjaan);
            SideBarPanel.Controls.Add(BtnToSoalInternet);
            SideBarPanel.Controls.Add(BtnToKelolaSoal);
            SideBarPanel.Controls.Add(QuizzyLogo);
            SideBarPanel.Controls.Add(QuizzyLabel);
            SideBarPanel.ForeColor = Color.Plum;
            SideBarPanel.Location = new Point(0, 0);
            SideBarPanel.Margin = new Padding(2);
            SideBarPanel.Name = "SideBarPanel";
            SideBarPanel.Size = new Size(219, 491);
            SideBarPanel.TabIndex = 0;
            // 
            // BtnLogout
            // 
            BtnLogout.BackColor = Color.MediumVioletRed;
            BtnLogout.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogout.ForeColor = Color.White;
            BtnLogout.Location = new Point(17, 218);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(185, 34);
            BtnLogout.TabIndex = 0;
            BtnLogout.Text = "Logout";
            BtnLogout.UseVisualStyleBackColor = false;
            // 
            // BtnToHistoriPengerjaan
            // 
            BtnToHistoriPengerjaan.BackColor = Color.MediumVioletRed;
            BtnToHistoriPengerjaan.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnToHistoriPengerjaan.ForeColor = Color.White;
            BtnToHistoriPengerjaan.Location = new Point(17, 178);
            BtnToHistoriPengerjaan.Name = "BtnToHistoriPengerjaan";
            BtnToHistoriPengerjaan.Size = new Size(185, 34);
            BtnToHistoriPengerjaan.TabIndex = 0;
            BtnToHistoriPengerjaan.Text = "Lihat Histori Pengerjaan";
            BtnToHistoriPengerjaan.UseVisualStyleBackColor = false;
            // 
            // BtnToSoalInternet
            // 
            BtnToSoalInternet.BackColor = Color.MediumVioletRed;
            BtnToSoalInternet.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnToSoalInternet.ForeColor = Color.White;
            BtnToSoalInternet.Location = new Point(17, 138);
            BtnToSoalInternet.Name = "BtnToSoalInternet";
            BtnToSoalInternet.Size = new Size(185, 34);
            BtnToSoalInternet.TabIndex = 0;
            BtnToSoalInternet.Text = "Lihat Soal Internet";
            BtnToSoalInternet.UseVisualStyleBackColor = false;
            // 
            // BtnToKelolaSoal
            // 
            BtnToKelolaSoal.BackColor = Color.MediumVioletRed;
            BtnToKelolaSoal.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnToKelolaSoal.ForeColor = Color.White;
            BtnToKelolaSoal.Location = new Point(17, 98);
            BtnToKelolaSoal.Name = "BtnToKelolaSoal";
            BtnToKelolaSoal.Size = new Size(185, 34);
            BtnToKelolaSoal.TabIndex = 0;
            BtnToKelolaSoal.Text = "Kelola Soal Lokal";
            BtnToKelolaSoal.UseVisualStyleBackColor = false;
            BtnToKelolaSoal.Click += button1_Click;
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
        private Button BtnToKelolaSoal;
        private Button BtnToHistoriPengerjaan;
        private Button BtnToSoalInternet;
        private Button BtnLogout;
    }
}