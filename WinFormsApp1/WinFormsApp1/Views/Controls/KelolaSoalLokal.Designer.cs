namespace WinFormsApp1.Views.Controls
{
    partial class KelolaSoalLokal
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
            btnTambahSoal = new Button();
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
            // btnTambahSoal
            // 
            btnTambahSoal.BackColor = Color.OliveDrab;
            btnTambahSoal.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahSoal.ForeColor = Color.White;
            btnTambahSoal.Location = new Point(450, 25);
            btnTambahSoal.Name = "btnTambahSoal";
            btnTambahSoal.Size = new Size(118, 33);
            btnTambahSoal.TabIndex = 1;
            btnTambahSoal.Text = "Tambah Soal";
            btnTambahSoal.UseVisualStyleBackColor = false;
            btnTambahSoal.Click += button1_Click;
            // 
            // flowLayoutSoalLokal
            // 
            flowLayoutSoalLokal.AutoScroll = true;
            flowLayoutSoalLokal.Controls.Add(panel1);
            flowLayoutSoalLokal.FlowDirection = FlowDirection.TopDown;
            flowLayoutSoalLokal.Location = new Point(21, 76);
            flowLayoutSoalLokal.Margin = new Padding(2, 2, 2, 2);
            flowLayoutSoalLokal.Name = "flowLayoutSoalLokal";
            flowLayoutSoalLokal.Size = new Size(554, 392);
            flowLayoutSoalLokal.TabIndex = 2;
            flowLayoutSoalLokal.WrapContents = false;
            flowLayoutSoalLokal.Paint += flowLayoutSoalLokal_Paint;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 0;
            // 
            // KelolaSoalLokal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutSoalLokal);
            Controls.Add(btnTambahSoal);
            Controls.Add(labelSoalLokal);
            Margin = new Padding(2, 2, 2, 2);
            Name = "KelolaSoalLokal";
            Size = new Size(596, 491);
            flowLayoutSoalLokal.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSoalLokal;
        private Button btnTambahSoal;
        private FlowLayoutPanel flowLayoutSoalLokal;
        private Panel panel1;
    }
}
