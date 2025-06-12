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
            button1 = new Button();
            label4 = new Label();
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
            label2.Location = new Point(348, 296);
            label2.Name = "label2";
            label2.Size = new Size(466, 30);
            label2.TabIndex = 2;
            label2.Text = "Selamat! Anda telah menyelesaikan quiz ini.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(511, 361);
            label3.Name = "label3";
            label3.Size = new Size(128, 30);
            label3.TabIndex = 3;
            label3.Text = "Skor anda :";
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(502, 555);
            button1.Name = "button1";
            button1.Size = new Size(151, 57);
            button1.TabIndex = 5;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.BackColor = Color.MediumVioletRed;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(535, 405);
            label4.Name = "label4";
            label4.Size = new Size(77, 45);
            label4.TabIndex = 6;
            label4.Text = "tes";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Grading
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Grading";
            Size = new Size(1185, 874);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
    }
}
