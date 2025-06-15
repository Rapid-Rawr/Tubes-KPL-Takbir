namespace WinFormsApp1.Views.Controls
{
    partial class LihatSoalInternet
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
            labelSoalInternet = new Label();
            cbKategori = new ComboBox();
            flowLayoutSoalInternet = new FlowLayoutPanel();
            panel1 = new Panel();
            labelPilihKategori = new Label();
            label1 = new Label();
            flowLayoutSoalInternet.SuspendLayout();
            SuspendLayout();
            // 
            // labelSoalInternet
            // 
            labelSoalInternet.AutoSize = true;
            labelSoalInternet.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSoalInternet.Location = new Point(32, 44);
            labelSoalInternet.Name = "labelSoalInternet";
            labelSoalInternet.Size = new Size(109, 19);
            labelSoalInternet.TabIndex = 0;
            labelSoalInternet.Text = "Soal Internet";
            // 
            // cbKategori
            // 
            cbKategori.BackColor = Color.OliveDrab;
            cbKategori.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbKategori.ForeColor = Color.White;
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(485, 41);
            cbKategori.Margin = new Padding(3, 4, 3, 4);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(159, 27);
            cbKategori.TabIndex = 1;
            cbKategori.Text = "Kategori";
            cbKategori.SelectedIndexChanged += cbKategori_SelectedIndexChanged;
            // 
            // flowLayoutSoalInternet
            // 
            flowLayoutSoalInternet.AutoScroll = true;
            flowLayoutSoalInternet.Controls.Add(panel1);
            flowLayoutSoalInternet.FlowDirection = FlowDirection.TopDown;
            flowLayoutSoalInternet.Location = new Point(24, 143);
            flowLayoutSoalInternet.Margin = new Padding(3, 4, 3, 4);
            flowLayoutSoalInternet.Name = "flowLayoutSoalInternet";
            flowLayoutSoalInternet.Size = new Size(633, 481);
            flowLayoutSoalInternet.TabIndex = 3;
            flowLayoutSoalInternet.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 0;
            // 
            // labelPilihKategori
            // 
            labelPilihKategori.AutoSize = true;
            labelPilihKategori.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPilihKategori.Location = new Point(365, 45);
            labelPilihKategori.Name = "labelPilihKategori";
            labelPilihKategori.Size = new Size(125, 19);
            labelPilihKategori.TabIndex = 4;
            labelPilihKategori.Text = "Pilih Kategori :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumVioletRed;
            label1.Location = new Point(32, 97);
            label1.Name = "label1";
            label1.Size = new Size(552, 17);
            label1.TabIndex = 5;
            label1.Text = "*Soal yang tampil dapat berubah sesuai dengan soal yang disediakan oleh API";
            // 
            // LihatSoalInternet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(labelPilihKategori);
            Controls.Add(flowLayoutSoalInternet);
            Controls.Add(cbKategori);
            Controls.Add(labelSoalInternet);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LihatSoalInternet";
            Size = new Size(681, 655);
            Load += LihatSoalInternet_Load;
            flowLayoutSoalInternet.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSoalInternet;
        private ComboBox cbKategori;
        private FlowLayoutPanel flowLayoutSoalInternet;
        private Panel panel1;
        private Label labelPilihKategori;
        private Label label1;
    }
}
