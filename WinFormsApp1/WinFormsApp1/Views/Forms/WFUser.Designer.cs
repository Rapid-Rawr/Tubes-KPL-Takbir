﻿namespace WinFormsApp1.Views.Forms
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
            btnLogout = new Button();
            btnToLeaderboard = new Button();
            btnToSkor = new Button();
            btnToQuiz = new Button();
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
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnToLeaderboard);
            panel1.Controls.Add(btnToSkor);
            panel1.Controls.Add(btnToQuiz);
            panel1.Controls.Add(QuizzyLogo);
            panel1.Controls.Add(QuizzyLabel);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 818);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.MediumVioletRed;
            btnLogout.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(24, 363);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(264, 57);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnToLeaderboard
            // 
            btnToLeaderboard.BackColor = Color.MediumVioletRed;
            btnToLeaderboard.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToLeaderboard.ForeColor = Color.White;
            btnToLeaderboard.Location = new Point(24, 297);
            btnToLeaderboard.Margin = new Padding(4, 5, 4, 5);
            btnToLeaderboard.Name = "btnToLeaderboard";
            btnToLeaderboard.Size = new Size(264, 57);
            btnToLeaderboard.TabIndex = 0;
            btnToLeaderboard.Text = "Leaderboard";
            btnToLeaderboard.UseVisualStyleBackColor = false;
            // 
            // btnToSkor
            // 
            btnToSkor.BackColor = Color.MediumVioletRed;
            btnToSkor.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToSkor.ForeColor = Color.White;
            btnToSkor.Location = new Point(24, 230);
            btnToSkor.Margin = new Padding(4, 5, 4, 5);
            btnToSkor.Name = "btnToSkor";
            btnToSkor.Size = new Size(264, 57);
            btnToSkor.TabIndex = 0;
            btnToSkor.Text = "Lihat Skor";
            btnToSkor.UseVisualStyleBackColor = false;
            // 
            // btnToQuiz
            // 
            btnToQuiz.BackColor = Color.MediumVioletRed;
            btnToQuiz.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToQuiz.ForeColor = Color.White;
            btnToQuiz.Location = new Point(24, 163);
            btnToQuiz.Margin = new Padding(4, 5, 4, 5);
            btnToQuiz.Name = "btnToQuiz";
            btnToQuiz.Size = new Size(264, 57);
            btnToQuiz.TabIndex = 0;
            btnToQuiz.Text = "Kerjakan Quiz";
            btnToQuiz.UseVisualStyleBackColor = false;
            // 
            // QuizzyLogo
            // 
            QuizzyLogo.Image = Properties.Resources.brain;
            QuizzyLogo.Location = new Point(51, 37);
            QuizzyLogo.Name = "QuizzyLogo";
            QuizzyLogo.Size = new Size(59, 72);
            QuizzyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            QuizzyLogo.TabIndex = 3;
            QuizzyLogo.TabStop = false;
            // 
            // QuizzyLabel
            // 
            QuizzyLabel.AutoSize = true;
            QuizzyLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuizzyLabel.ForeColor = Color.MediumVioletRed;
            QuizzyLabel.Location = new Point(127, 48);
            QuizzyLabel.Name = "QuizzyLabel";
            QuizzyLabel.Size = new Size(149, 43);
            QuizzyLabel.TabIndex = 2;
            QuizzyLabel.Text = "QUIZZY";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(311, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(851, 818);
            panel2.TabIndex = 1;
            // 
            // WFUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 818);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "WFUser";
            Text = "User";
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
        private Button btnToQuiz;
        private Button btnToSkor;
        private Button btnLogout;
        private Button btnToLeaderboard;
    }
}