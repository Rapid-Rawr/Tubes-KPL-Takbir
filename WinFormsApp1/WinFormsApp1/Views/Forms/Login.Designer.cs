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
            tbName = new TextBox();
            NameLabel = new Label();
            UsernameLabel = new Label();
            tbUsername = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            linkToRegister = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)QuizzyLogo).BeginInit();
            SuspendLayout();
            // 
            // QuizzyLogo
            // 
            QuizzyLogo.Image = Properties.Resources.brain;
            QuizzyLogo.Location = new Point(379, 76);
            QuizzyLogo.Margin = new Padding(2);
            QuizzyLogo.Name = "QuizzyLogo";
            QuizzyLogo.Size = new Size(48, 52);
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
            QuizzyLabel.Location = new Point(356, 141);
            QuizzyLabel.Margin = new Padding(2, 0, 2, 0);
            QuizzyLabel.Name = "QuizzyLabel";
            QuizzyLabel.Size = new Size(98, 29);
            QuizzyLabel.TabIndex = 2;
            QuizzyLabel.Text = "QUIZZY";
            // 
            // tbName
            // 
            tbName.ForeColor = SystemColors.WindowText;
            tbName.Location = new Point(307, 232);
            tbName.Name = "tbName";
            tbName.Size = new Size(200, 23);
            tbName.TabIndex = 4;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(307, 210);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(44, 16);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Name";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameLabel.Location = new Point(307, 270);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(71, 16);
            UsernameLabel.TabIndex = 6;
            UsernameLabel.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(307, 292);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(200, 23);
            tbUsername.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumVioletRed;
            btnLogin.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(307, 339);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 40);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, 398);
            label1.Name = "label1";
            label1.Size = new Size(116, 16);
            label1.TabIndex = 9;
            label1.Text = "Tidak punya akun?";
            label1.Click += label3_Click;
            // 
            // linkToRegister
            // 
            linkToRegister.AutoSize = true;
            linkToRegister.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkToRegister.LinkColor = Color.MediumVioletRed;
            linkToRegister.Location = new Point(419, 398);
            linkToRegister.Name = "linkToRegister";
            linkToRegister.Size = new Size(89, 16);
            linkToRegister.TabIndex = 10;
            linkToRegister.TabStop = true;
            linkToRegister.Text = "Register disini";
            linkToRegister.VisitedLinkColor = Color.Orange;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(814, 491);
            Controls.Add(linkToRegister);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(tbUsername);
            Controls.Add(UsernameLabel);
            Controls.Add(NameLabel);
            Controls.Add(tbName);
            Controls.Add(QuizzyLogo);
            Controls.Add(QuizzyLabel);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)QuizzyLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox QuizzyLogo;
        private Label QuizzyLabel;
        private TextBox tbName;
        private Label NameLabel;
        private Label UsernameLabel;
        private TextBox tbUsername;
        private Button btnLogin;
        private Label label1;
        private LinkLabel linkToRegister;
    }
}