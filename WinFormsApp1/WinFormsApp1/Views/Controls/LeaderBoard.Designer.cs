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
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(310, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 243);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(155, 279);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 161);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.YellowGreen;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(465, 334);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 106);
            panel3.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 4);
            label2.Name = "label2";
            label2.Size = new Size(46, 54);
            label2.TabIndex = 4;
            label2.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 4);
            label3.Name = "label3";
            label3.Size = new Size(46, 54);
            label3.TabIndex = 5;
            label3.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 3);
            label4.Name = "label4";
            label4.Size = new Size(46, 54);
            label4.TabIndex = 5;
            label4.Text = "3";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(2, 82);
            label5.Name = "label5";
            label5.Size = new Size(92, 27);
            label5.TabIndex = 5;
            label5.Text = "Username:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(2, 109);
            label6.Name = "label6";
            label6.Size = new Size(83, 27);
            label6.TabIndex = 6;
            label6.Text = "Skor:";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(2, 85);
            label7.Name = "label7";
            label7.Size = new Size(83, 27);
            label7.TabIndex = 8;
            label7.Text = "Skor:";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(2, 58);
            label8.Name = "label8";
            label8.Size = new Size(100, 27);
            label8.TabIndex = 7;
            label8.Text = "Username:";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 79);
            label9.Name = "label9";
            label9.Size = new Size(83, 27);
            label9.TabIndex = 10;
            label9.Text = "Skor:";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 52);
            label10.Name = "label10";
            label10.Size = new Size(100, 27);
            label10.TabIndex = 9;
            label10.Text = "Username:";
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
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridView dataGridView1;
    }
}
