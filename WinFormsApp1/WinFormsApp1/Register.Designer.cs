namespace WinFormsApp1
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
            tbUsername = new TextBox();
            UsernameLabel = new Label();
            NameLabel = new Label();
            tbName = new TextBox();
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
            linkToLogin.Location = new Point(431, 398);
            linkToLogin.Name = "linkToLogin";
            linkToLogin.Size = new Size(72, 16);
            linkToLogin.TabIndex = 19;
            linkToLogin.TabStop = true;
            linkToLogin.Text = "Login disini";
            linkToLogin.VisitedLinkColor = Color.Orange;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 398);
            label1.Name = "label1";
            label1.Size = new Size(122, 16);
            label1.TabIndex = 18;
            label1.Text = "Sudah punya akun?";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.MediumVioletRed;
            btnRegister.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(307, 339);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 40);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(307, 292);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(200, 23);
            tbUsername.TabIndex = 16;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameLabel.Location = new Point(307, 270);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(71, 16);
            UsernameLabel.TabIndex = 15;
            UsernameLabel.Text = "Username";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(307, 210);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(44, 16);
            NameLabel.TabIndex = 14;
            NameLabel.Text = "Name";
            // 
            // tbName
            // 
            tbName.ForeColor = SystemColors.WindowText;
            tbName.Location = new Point(307, 232);
            tbName.Name = "tbName";
            tbName.Size = new Size(200, 23);
            tbName.TabIndex = 13;
            // 
            // QuizzyLogo
            // 
            QuizzyLogo.Image = Properties.Resources.brain;
            QuizzyLogo.Location = new Point(379, 76);
            QuizzyLogo.Margin = new Padding(2);
            QuizzyLogo.Name = "QuizzyLogo";
            QuizzyLogo.Size = new Size(48, 52);
            QuizzyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            QuizzyLogo.TabIndex = 12;
            QuizzyLogo.TabStop = false;
            // 
            // QuizzyLabel
            // 
            QuizzyLabel.AutoSize = true;
            QuizzyLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuizzyLabel.ForeColor = Color.MediumVioletRed;
            QuizzyLabel.Location = new Point(356, 141);
            QuizzyLabel.Margin = new Padding(2, 0, 2, 0);
            QuizzyLabel.Name = "QuizzyLabel";
            QuizzyLabel.Size = new Size(98, 29);
            QuizzyLabel.TabIndex = 11;
            QuizzyLabel.Text = "QUIZZY";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(814, 491);
            Controls.Add(linkToLogin);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(tbUsername);
            Controls.Add(UsernameLabel);
            Controls.Add(NameLabel);
            Controls.Add(tbName);
            Controls.Add(QuizzyLogo);
            Controls.Add(QuizzyLabel);
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
        private TextBox tbUsername;
        private Label UsernameLabel;
        private Label NameLabel;
        private TextBox tbName;
        private PictureBox QuizzyLogo;
        private Label QuizzyLabel;
    }
}