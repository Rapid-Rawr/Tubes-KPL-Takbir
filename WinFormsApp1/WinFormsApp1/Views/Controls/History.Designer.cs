namespace WinFormsApp1.Views.Controls
{
    partial class History
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
            labelTotalSkor = new Label();
            textBoxTotalSkor = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelTotalSkor
            // 
            labelTotalSkor.AutoSize = true;
            labelTotalSkor.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalSkor.Location = new Point(297, 82);
            labelTotalSkor.Name = "labelTotalSkor";
            labelTotalSkor.Size = new Size(234, 38);
            labelTotalSkor.TabIndex = 4;
            labelTotalSkor.Text = "Total Skor Anda:";
            labelTotalSkor.Click += label1_Click;
            // 
            // textBoxTotalSkor
            // 
            textBoxTotalSkor.BackColor = Color.MediumVioletRed;
            textBoxTotalSkor.Location = new Point(352, 156);
            textBoxTotalSkor.Multiline = true;
            textBoxTotalSkor.Name = "textBoxTotalSkor";
            textBoxTotalSkor.ReadOnly = true;
            textBoxTotalSkor.Size = new Size(112, 46);
            textBoxTotalSkor.TabIndex = 5;
            textBoxTotalSkor.TextAlign = HorizontalAlignment.Center;
            textBoxTotalSkor.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(115, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(595, 409);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridView1);
            Controls.Add(textBoxTotalSkor);
            Controls.Add(labelTotalSkor);
            Name = "History";
            Size = new Size(851, 818);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTotalSkor;
        private TextBox textBoxTotalSkor;
        private DataGridView dataGridView1;
    }
}
