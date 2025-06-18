namespace WinFormsApp1.Views.Controls
{
    partial class Grading
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblSkor = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.brain;
            pictureBox1.Location = new Point(49, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumVioletRed;
            label1.Location = new Point(130, 64);
            label1.Name = "label1";
            label1.Size = new Size(149, 43);
            label1.TabIndex = 1;
            label1.Text = "QUIZZY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(171, 308);
            label2.Name = "label2";
            label2.Size = new Size(466, 30);
            label2.TabIndex = 2;
            label2.Text = "Selamat! Anda telah menyelesaikan quiz ini.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(334, 373);
            label3.Name = "label3";
            label3.Size = new Size(128, 30);
            label3.TabIndex = 3;
            label3.Text = "Skor anda :";
            // 
            // lblSkor
            // 
            lblSkor.BackColor = Color.MediumVioletRed;
            lblSkor.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSkor.ForeColor = SystemColors.Control;
            lblSkor.Location = new Point(358, 417);
            lblSkor.Name = "lblSkor";
            lblSkor.Size = new Size(77, 45);
            lblSkor.TabIndex = 6;
            lblSkor.Text = "tes";
            lblSkor.TextAlign = ContentAlignment.MiddleCenter;
            lblSkor.Click += label4_Click;
            // 
            // Grading
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblSkor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Grading";
            Size = new Size(851, 818);
            Load += Grading_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSkor;
    }
}
