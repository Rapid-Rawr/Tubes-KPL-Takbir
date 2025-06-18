namespace WinFormsApp1.Views.Controls
{
    partial class LeaderBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblJuara1Skor = new Label();
            lblJuara1Username = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lblJuara2Skor = new Label();
            lblJuara2Username = new Label();
            label3 = new Label();
            panel3 = new Panel();
            lblJuara3Skor = new Label();
            lblJuara3Username = new Label();
            label4 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumVioletRed;
            panel1.Controls.Add(lblJuara1Skor);
            panel1.Controls.Add(lblJuara1Username);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(310, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 243);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblJuara1Skor
            // 
            lblJuara1Skor.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJuara1Skor.ForeColor = Color.White;
            lblJuara1Skor.Location = new Point(52, 109);
            lblJuara1Skor.Name = "lblJuara1Skor";
            lblJuara1Skor.Size = new Size(51, 27);
            lblJuara1Skor.TabIndex = 6;
            lblJuara1Skor.Text = "Skor:";
            lblJuara1Skor.TextAlign = ContentAlignment.MiddleCenter;
            lblJuara1Skor.Click += label6_Click;
            // 
            // lblJuara1Username
            // 
            lblJuara1Username.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJuara1Username.ForeColor = Color.White;
            lblJuara1Username.Location = new Point(30, 82);
            lblJuara1Username.Name = "lblJuara1Username";
            lblJuara1Username.Size = new Size(92, 27);
            lblJuara1Username.TabIndex = 5;
            lblJuara1Username.Text = "Username:";
            lblJuara1Username.TextAlign = ContentAlignment.MiddleCenter;
            lblJuara1Username.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 4);
            label2.Name = "label2";
            label2.Size = new Size(46, 54);
            label2.TabIndex = 4;
            label2.Text = "1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Controls.Add(lblJuara2Skor);
            panel2.Controls.Add(lblJuara2Username);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(155, 279);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 161);
            panel2.TabIndex = 1;
            // 
            // lblJuara2Skor
            // 
            lblJuara2Skor.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJuara2Skor.ForeColor = Color.White;
            lblJuara2Skor.Location = new Point(54, 85);
            lblJuara2Skor.Name = "lblJuara2Skor";
            lblJuara2Skor.Size = new Size(48, 27);
            lblJuara2Skor.TabIndex = 8;
            lblJuara2Skor.Text = "Skor:";
            lblJuara2Skor.TextAlign = ContentAlignment.TopCenter;
            lblJuara2Skor.Click += label7_Click;
            // 
            // lblJuara2Username
            // 
            lblJuara2Username.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJuara2Username.ForeColor = Color.White;
            lblJuara2Username.Location = new Point(28, 58);
            lblJuara2Username.Name = "lblJuara2Username";
            lblJuara2Username.Size = new Size(100, 27);
            lblJuara2Username.TabIndex = 7;
            lblJuara2Username.Text = "Username:";
            lblJuara2Username.TextAlign = ContentAlignment.MiddleCenter;
            lblJuara2Username.Click += label8_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(56, 4);
            label3.Name = "label3";
            label3.Size = new Size(46, 54);
            label3.TabIndex = 5;
            label3.Text = "2";
            // 
            // panel3
            // 
            panel3.BackColor = Color.YellowGreen;
            panel3.Controls.Add(lblJuara3Skor);
            panel3.Controls.Add(lblJuara3Username);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(465, 334);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 106);
            panel3.TabIndex = 2;
            // 
            // lblJuara3Skor
            // 
            lblJuara3Skor.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJuara3Skor.ForeColor = Color.White;
            lblJuara3Skor.Location = new Point(46, 79);
            lblJuara3Skor.Name = "lblJuara3Skor";
            lblJuara3Skor.Size = new Size(54, 27);
            lblJuara3Skor.TabIndex = 10;
            lblJuara3Skor.Text = "Skor:";
            lblJuara3Skor.TextAlign = ContentAlignment.MiddleCenter;
            lblJuara3Skor.Click += label9_Click;
            // 
            // lblJuara3Username
            // 
            lblJuara3Username.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJuara3Username.ForeColor = Color.White;
            lblJuara3Username.Location = new Point(22, 52);
            lblJuara3Username.Name = "lblJuara3Username";
            lblJuara3Username.Size = new Size(100, 27);
            lblJuara3Username.TabIndex = 9;
            lblJuara3Username.Text = "Username:";
            lblJuara3Username.TextAlign = ContentAlignment.MiddleCenter;
            lblJuara3Username.Click += label10_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(54, 3);
            label4.Name = "label4";
            label4.Size = new Size(46, 54);
            label4.TabIndex = 5;
            label4.Text = "3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 56);
            label1.Name = "label1";
            label1.Size = new Size(181, 38);
            label1.TabIndex = 3;
            label1.Text = "Leaderboard";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(157, 484);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(463, 221);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // LeaderBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LeaderBoard";
            Size = new Size(851, 818);
            Load += LeaderBoard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label lblJuara1Username;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblJuara1Skor;
        private Label lblJuara2Skor;
        private Label lblJuara2Username;
        private Label lblJuara3Skor;
        private Label lblJuara3Username;
        private DataGridView dataGridView1;
    }
}
