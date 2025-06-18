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
            label2 = new Label();
            label3 = new Label();
            lblSkor = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 185);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(315, 20);
            label2.TabIndex = 2;
            label2.Text = "Selamat! Anda telah menyelesaikan quiz ini.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(234, 224);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 3;
            label3.Text = "Skor anda :";
            // 
            // lblSkor
            // 
            lblSkor.BackColor = Color.MediumVioletRed;
            lblSkor.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSkor.ForeColor = SystemColors.Control;
            lblSkor.Location = new Point(251, 253);
            lblSkor.Margin = new Padding(2, 0, 2, 0);
            lblSkor.Name = "lblSkor";
            lblSkor.Size = new Size(54, 33);
            lblSkor.TabIndex = 6;
            lblSkor.Text = "tes";
            lblSkor.TextAlign = ContentAlignment.MiddleCenter;
            lblSkor.Click += label4_Click;
            // 
            // Grading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblSkor);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "Grading";
            Size = new Size(596, 491);
            Load += Grading_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label lblSkor;
    }
}
