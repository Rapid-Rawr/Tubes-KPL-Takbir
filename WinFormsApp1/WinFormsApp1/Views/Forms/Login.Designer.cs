namespace WinFormsApp1.Views.Forms
{
    partial class Login
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
            txtUsername = new TextBox();
            NameLabel = new Label();
            UsernameLabel = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            linkToRegister = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)QuizzyLogo).BeginInit();
            SuspendLayout();
            // 
            // QuizzyLogo
            // 
            QuizzyLogo.Image = Properties.Resources.brain;
<<<<<<< HEAD
            QuizzyLogo.Location = new Point(541, 127);
            QuizzyLogo.Name = "QuizzyLogo";
            QuizzyLogo.Size = new Size(69, 87);
=======
            QuizzyLogo.Location = new Point(433, 101);
            QuizzyLogo.Margin = new Padding(2, 3, 2, 3);
            QuizzyLogo.Name = "QuizzyLogo";
            QuizzyLogo.Size = new Size(55, 69);
>>>>>>> 5a8ec56 (fungsional fitur login dan register)
            QuizzyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            QuizzyLogo.TabIndex = 3;
            QuizzyLogo.TabStop = false;
            QuizzyLogo.Click += QuizzyLogo_Click;
            // 
            // QuizzyLabel
            // 
            QuizzyLabel.AutoSize = true;
            QuizzyLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuizzyLabel.ForeColor = Color.MediumVioletRed;
<<<<<<< HEAD
            QuizzyLabel.Location = new Point(509, 235);
            QuizzyLabel.Name = "QuizzyLabel";
            QuizzyLabel.Size = new Size(149, 43);
=======
            QuizzyLabel.Location = new Point(407, 188);
            QuizzyLabel.Margin = new Padding(2, 0, 2, 0);
            QuizzyLabel.Name = "QuizzyLabel";
            QuizzyLabel.Size = new Size(124, 35);
>>>>>>> 5a8ec56 (fungsional fitur login dan register)
            QuizzyLabel.TabIndex = 2;
            QuizzyLabel.Text = "QUIZZY";
            // 
            // txtUsername
            // 
<<<<<<< HEAD
            tbName.ForeColor = SystemColors.WindowText;
            tbName.Location = new Point(439, 387);
            tbName.Margin = new Padding(4, 5, 4, 5);
            tbName.Name = "tbName";
            tbName.Size = new Size(284, 31);
            tbName.TabIndex = 4;
            tbName.TextChanged += tbName_TextChanged;
=======
            txtUsername.ForeColor = SystemColors.WindowText;
            txtUsername.Location = new Point(351, 309);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(228, 27);
            txtUsername.TabIndex = 4;
>>>>>>> 5a8ec56 (fungsional fitur login dan register)
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            NameLabel.Location = new Point(439, 350);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(63, 24);
=======
            NameLabel.Location = new Point(351, 280);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(88, 19);
>>>>>>> 5a8ec56 (fungsional fitur login dan register)
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Username";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            UsernameLabel.Location = new Point(439, 450);
            UsernameLabel.Margin = new Padding(4, 0, 4, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(105, 24);
=======
            UsernameLabel.Location = new Point(351, 360);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(87, 19);
>>>>>>> 5a8ec56 (fungsional fitur login dan register)
            UsernameLabel.TabIndex = 6;
            UsernameLabel.Text = "Password";
            // 
            // txtPassword
            // 
<<<<<<< HEAD
            tbUsername.Location = new Point(439, 487);
            tbUsername.Margin = new Padding(4, 5, 4, 5);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(284, 31);
            tbUsername.TabIndex = 7;
=======
            txtPassword.Location = new Point(351, 389);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(228, 27);
            txtPassword.TabIndex = 7;
>>>>>>> 5a8ec56 (fungsional fitur login dan register)
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumVioletRed;
            btnLogin.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
<<<<<<< HEAD
            btnLogin.Location = new Point(439, 565);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(286, 67);
=======
            btnLogin.Location = new Point(351, 452);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(229, 53);
>>>>>>> 5a8ec56 (fungsional fitur login dan register)
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            label1.Location = new Point(437, 663);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 23);
=======
            label1.Location = new Point(350, 531);
            label1.Name = "label1";
            label1.Size = new Size(146, 19);
>>>>>>> 5a8ec56 (fungsional fitur login dan register)
            label1.TabIndex = 9;
            label1.Text = "Tidak punya akun?";
            label1.Click += label3_Click;
            // 
            // linkToRegister
            // 
            linkToRegister.AutoSize = true;
            linkToRegister.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkToRegister.LinkColor = Color.MediumVioletRed;
<<<<<<< HEAD
            linkToRegister.Location = new Point(599, 663);
            linkToRegister.Margin = new Padding(4, 0, 4, 0);
            linkToRegister.Name = "linkToRegister";
            linkToRegister.Size = new Size(133, 23);
=======
            linkToRegister.Location = new Point(479, 531);
            linkToRegister.Name = "linkToRegister";
            linkToRegister.Size = new Size(112, 19);
>>>>>>> 5a8ec56 (fungsional fitur login dan register)
            linkToRegister.TabIndex = 10;
            linkToRegister.TabStop = true;
            linkToRegister.Text = "Register disini";
            linkToRegister.VisitedLinkColor = Color.Orange;
            linkToRegister.LinkClicked += linkToRegister_LinkClicked;
            // 
            // Login
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1163, 818);
=======
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(930, 655);
>>>>>>> 5a8ec56 (fungsional fitur login dan register)
            Controls.Add(linkToRegister);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(UsernameLabel);
            Controls.Add(NameLabel);
            Controls.Add(txtUsername);
            Controls.Add(QuizzyLogo);
            Controls.Add(QuizzyLabel);
<<<<<<< HEAD
            Margin = new Padding(4, 5, 4, 5);
=======
            Margin = new Padding(3, 4, 3, 4);
>>>>>>> 5a8ec56 (fungsional fitur login dan register)
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)QuizzyLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox QuizzyLogo;
        private Label QuizzyLabel;
        private TextBox txtUsername;
        private Label NameLabel;
        private Label UsernameLabel;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label1;
        private LinkLabel linkToRegister;
    }
}