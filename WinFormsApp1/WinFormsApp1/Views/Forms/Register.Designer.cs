namespace WinFormsApp1.Views.Forms
{
    partial class Register
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
            linkToLogin = new LinkLabel();
            label1 = new Label();
            btnRegister = new Button();
            txtPassword = new TextBox();
            UsernameLabel = new Label();
            NameLabel = new Label();
            txtUsername = new TextBox();
            QuizzyLogo = new PictureBox();
            QuizzyLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)QuizzyLogo).BeginInit();
            SuspendLayout();
            // 
            // linkToLogin
            // 
            linkToLogin.AutoSize = true;
            linkToLogin.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkToLogin.LinkColor = Color.MediumVioletRed;
            linkToLogin.Location = new Point(493, 531);
            linkToLogin.Name = "linkToLogin";
            linkToLogin.Size = new Size(92, 19);
            linkToLogin.TabIndex = 19;
            linkToLogin.TabStop = true;
            linkToLogin.Text = "Login disini";
            linkToLogin.VisitedLinkColor = Color.Orange;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(355, 531);
            label1.Name = "label1";
            label1.Size = new Size(155, 19);
            label1.TabIndex = 18;
            label1.Text = "Sudah punya akun?";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.MediumVioletRed;
            btnRegister.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(351, 452);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(229, 53);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(351, 389);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(228, 27);
            txtPassword.TabIndex = 16;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameLabel.Location = new Point(351, 360);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(87, 19);
            UsernameLabel.TabIndex = 15;
            UsernameLabel.Text = "Password";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(351, 280);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(88, 19);
            NameLabel.TabIndex = 14;
            NameLabel.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.ForeColor = SystemColors.WindowText;
            txtUsername.Location = new Point(351, 309);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(228, 27);
            txtUsername.TabIndex = 13;
            // 
            // QuizzyLogo
            // 
            QuizzyLogo.Image = Properties.Resources.brain;
            QuizzyLogo.Location = new Point(433, 101);
            QuizzyLogo.Margin = new Padding(2, 3, 2, 3);
            QuizzyLogo.Name = "QuizzyLogo";
            QuizzyLogo.Size = new Size(55, 69);
            QuizzyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            QuizzyLogo.TabIndex = 12;
            QuizzyLogo.TabStop = false;
            // 
            // QuizzyLabel
            // 
            QuizzyLabel.AutoSize = true;
            QuizzyLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuizzyLabel.ForeColor = Color.MediumVioletRed;
            QuizzyLabel.Location = new Point(407, 188);
            QuizzyLabel.Margin = new Padding(2, 0, 2, 0);
            QuizzyLabel.Name = "QuizzyLabel";
            QuizzyLabel.Size = new Size(124, 35);
            QuizzyLabel.TabIndex = 11;
            QuizzyLabel.Text = "QUIZZY";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(930, 655);
            Controls.Add(linkToLogin);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(UsernameLabel);
            Controls.Add(NameLabel);
            Controls.Add(txtUsername);
            Controls.Add(QuizzyLogo);
            Controls.Add(QuizzyLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)QuizzyLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkToLogin;
        private Label label1;
        private Button btnRegister;
        private TextBox txtPassword;
        private Label UsernameLabel;
        private Label NameLabel;
        private TextBox txtUsername;
        private PictureBox QuizzyLogo;
        private Label QuizzyLabel;
    }
}