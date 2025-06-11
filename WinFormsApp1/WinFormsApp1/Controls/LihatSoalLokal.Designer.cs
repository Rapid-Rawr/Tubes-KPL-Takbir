namespace WinFormsApp1
{
    partial class LihatSoalLokal
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
            labelSoalLokal = new Label();
            button1 = new Button();
            flowLayoutSoalLokal = new FlowLayoutPanel();
            panel1 = new Panel();
            flowLayoutSoalLokal.SuspendLayout();
            SuspendLayout();
            // 
            // labelSoalLokal
            // 
            labelSoalLokal.AutoSize = true;
            labelSoalLokal.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSoalLokal.Location = new Point(28, 33);
            labelSoalLokal.Name = "labelSoalLokal";
            labelSoalLokal.Size = new Size(75, 16);
            labelSoalLokal.TabIndex = 0;
            labelSoalLokal.Text = "Soal Lokal";
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(450, 25);
            button1.Name = "button1";
            button1.Size = new Size(118, 33);
            button1.TabIndex = 1;
            button1.Text = "Tambah Soal";
            button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutSoalLokal
            // 
            flowLayoutSoalLokal.AutoScroll = true;
            flowLayoutSoalLokal.Controls.Add(panel1);
            flowLayoutSoalLokal.Location = new Point(28, 84);
            flowLayoutSoalLokal.Name = "flowLayoutSoalLokal";
            flowLayoutSoalLokal.Size = new Size(540, 378);
            flowLayoutSoalLokal.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 0;
            // 
            // LihatSoalLokal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutSoalLokal);
            Controls.Add(button1);
            Controls.Add(labelSoalLokal);
            Name = "LihatSoalLokal";
            Size = new Size(596, 491);
            flowLayoutSoalLokal.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSoalLokal;
        private Button button1;
        private FlowLayoutPanel flowLayoutSoalLokal;
        private Panel panel1;
    }
}
