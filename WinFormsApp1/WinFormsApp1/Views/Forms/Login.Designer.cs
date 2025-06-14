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
            QuizzyLogo.Location = new Point(541, 127);
            QuizzyLogo.Name = "QuizzyLogo";
            QuizzyLogo.Size = new Size(69, 87);
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
            QuizzyLabel.Location = new Point(509, 235);
            QuizzyLabel.Name = "QuizzyLabel";
            QuizzyLabel.Size = new Size(149, 43);
            QuizzyLabel.TabIndex = 2;
            QuizzyLabel.Text = "QUIZZY";
            // 
            // tbName
            // 
            tbName.ForeColor = SystemColors.WindowText;
            tbName.Location = new Point(439, 387);
            tbName.Margin = new Padding(4, 5, 4, 5);
            tbName.Name = "tbName";
            tbName.Size = new Size(284, 31);
            tbName.TabIndex = 4;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(439, 350);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(63, 24);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Name";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameLabel.Location = new Point(439, 450);
            UsernameLabel.Margin = new Padding(4, 0, 4, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(105, 24);
            UsernameLabel.TabIndex = 6;
            UsernameLabel.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(439, 487);
            tbUsername.Margin = new Padding(4, 5, 4, 5);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(284, 31);
            tbUsername.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumVioletRed;
            btnLogin.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(439, 565);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(286, 67);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(437, 663);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 23);
            label1.TabIndex = 9;
            label1.Text = "Tidak punya akun?";
            label1.Click += label3_Click;
            // 
            // linkToRegister
            // 
            linkToRegister.AutoSize = true;
            linkToRegister.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkToRegister.LinkColor = Color.MediumVioletRed;
            linkToRegister.Location = new Point(599, 663);
            linkToRegister.Margin = new Padding(4, 0, 4, 0);
            linkToRegister.Name = "linkToRegister";
            linkToRegister.Size = new Size(133, 23);
            linkToRegister.TabIndex = 10;
            linkToRegister.TabStop = true;
            linkToRegister.Text = "Register disini";
            linkToRegister.VisitedLinkColor = Color.Orange;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1163, 818);
            Controls.Add(linkToRegister);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(tbUsername);
            Controls.Add(UsernameLabel);
            Controls.Add(NameLabel);
            Controls.Add(tbName);
            Controls.Add(QuizzyLogo);
            Controls.Add(QuizzyLabel);
            Margin = new Padding(4, 5, 4, 5);
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