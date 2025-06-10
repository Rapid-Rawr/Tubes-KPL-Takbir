namespace WinFormsApp1
{
    partial class WFUser
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
            panel1 = new Panel();
            BtnLogout = new Button();
            BtnToLeaderboard = new Button();
            BtnToSkor = new Button();
            BtnToQuiz = new Button();
            QuizzyLogo = new PictureBox();
            QuizzyLabel = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuizzyLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 227, 242);
            panel1.Controls.Add(BtnLogout);
            panel1.Controls.Add(BtnToLeaderboard);
            panel1.Controls.Add(BtnToSkor);
            panel1.Controls.Add(BtnToQuiz);
            panel1.Controls.Add(QuizzyLogo);
            panel1.Controls.Add(QuizzyLabel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 491);
            panel1.TabIndex = 0;
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
            // BtnToLeaderboard
            // 
            BtnToLeaderboard.BackColor = Color.MediumVioletRed;
            BtnToLeaderboard.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnToLeaderboard.ForeColor = Color.White;
            BtnToLeaderboard.Location = new Point(17, 178);
            BtnToLeaderboard.Name = "BtnToLeaderboard";
            BtnToLeaderboard.Size = new Size(185, 34);
            BtnToLeaderboard.TabIndex = 0;
            BtnToLeaderboard.Text = "Leaderboard";
            BtnToLeaderboard.UseVisualStyleBackColor = false;
            // 
            // BtnToSkor
            // 
            BtnToSkor.BackColor = Color.MediumVioletRed;
            BtnToSkor.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnToSkor.ForeColor = Color.White;
            BtnToSkor.Location = new Point(17, 138);
            BtnToSkor.Name = "BtnToSkor";
            BtnToSkor.Size = new Size(185, 34);
            BtnToSkor.TabIndex = 0;
            BtnToSkor.Text = "Lihat Skor";
            BtnToSkor.UseVisualStyleBackColor = false;
            // 
            // BtnToQuiz
            // 
            BtnToQuiz.BackColor = Color.MediumVioletRed;
            BtnToQuiz.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnToQuiz.ForeColor = Color.White;
            BtnToQuiz.Location = new Point(17, 98);
            BtnToQuiz.Name = "BtnToQuiz";
            BtnToQuiz.Size = new Size(185, 34);
            BtnToQuiz.TabIndex = 0;
            BtnToQuiz.Text = "Kerjakan Quiz";
            BtnToQuiz.UseVisualStyleBackColor = false;
            // 
            // QuizzyLogo
            // 
            QuizzyLogo.Image = Properties.Resources.brain;
            QuizzyLogo.Location = new Point(36, 22);
            QuizzyLogo.Margin = new Padding(2);
            QuizzyLogo.Name = "QuizzyLogo";
            QuizzyLogo.Size = new Size(41, 43);
            QuizzyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            QuizzyLogo.TabIndex = 3;
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
            QuizzyLabel.TabIndex = 2;
            QuizzyLabel.Text = "QUIZZY";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(218, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 491);
            panel2.TabIndex = 1;
            // 
            // WFUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 491);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "WFUser";
            Text = "WFUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuizzyLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox QuizzyLogo;
        private Label QuizzyLabel;
        private Button BtnToQuiz;
        private Button BtnToSkor;
        private Button BtnLogout;
        private Button BtnToLeaderboard;
    }
}