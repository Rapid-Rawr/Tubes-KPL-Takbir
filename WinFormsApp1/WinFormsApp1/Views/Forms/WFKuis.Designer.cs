namespace WinFormsApp1.Views.Forms
{
    partial class WFKuis
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
            QuizzyLogo = new PictureBox();
            QuizzyLabel = new Label();
            panelKuis = new Panel();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)QuizzyLogo).BeginInit();
            SuspendLayout();
            // 
            // QuizzyLogo
            // 
            QuizzyLogo.Image = Properties.Resources.brain;
            QuizzyLogo.Location = new Point(54, 48);
            QuizzyLogo.Margin = new Padding(1, 3, 1, 3);
            QuizzyLogo.Name = "QuizzyLogo";
            QuizzyLogo.Size = new Size(69, 87);
            QuizzyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            QuizzyLogo.TabIndex = 5;
            QuizzyLogo.TabStop = false;
            // 
            // QuizzyLabel
            // 
            QuizzyLabel.AutoSize = true;
            QuizzyLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuizzyLabel.ForeColor = Color.MediumVioletRed;
            QuizzyLabel.Location = new Point(146, 70);
            QuizzyLabel.Margin = new Padding(1, 0, 1, 0);
            QuizzyLabel.Name = "QuizzyLabel";
            QuizzyLabel.Size = new Size(149, 43);
            QuizzyLabel.TabIndex = 4;
            QuizzyLabel.Text = "QUIZZY";
            // 
            // panelKuis
            // 
            panelKuis.Location = new Point(39, 185);
            panelKuis.Margin = new Padding(4, 5, 4, 5);
            panelKuis.Name = "panelKuis";
            panelKuis.Size = new Size(1089, 478);
            panelKuis.TabIndex = 6;
            panelKuis.Paint += panelKuis_Paint;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.OliveDrab;
            btnNext.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(980, 700);
            btnNext.Margin = new Padding(4, 5, 4, 5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(147, 63);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // WFKuis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1163, 818);
            Controls.Add(btnNext);
            Controls.Add(panelKuis);
            Controls.Add(QuizzyLogo);
            Controls.Add(QuizzyLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "WFKuis";
            Text = "WFKuis";
            Load += WFKuis_Load;
            ((System.ComponentModel.ISupportInitialize)QuizzyLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox QuizzyLogo;
        private Label QuizzyLabel;
        private Panel panelKuis;
        private Button btnNext;
    }
}