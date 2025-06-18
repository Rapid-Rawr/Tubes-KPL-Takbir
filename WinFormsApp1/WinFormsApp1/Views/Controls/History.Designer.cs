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
            labelTotalSkor.Location = new Point(208, 49);
            labelTotalSkor.Margin = new Padding(2, 0, 2, 0);
            labelTotalSkor.Name = "labelTotalSkor";
            labelTotalSkor.Size = new Size(159, 25);
            labelTotalSkor.TabIndex = 4;
            labelTotalSkor.Text = "Total Skor Anda:";
            labelTotalSkor.Click += label1_Click;
            // 
            // textBoxTotalSkor
            // 
            textBoxTotalSkor.BackColor = Color.MediumVioletRed;
            textBoxTotalSkor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxTotalSkor.ForeColor = Color.White;
            textBoxTotalSkor.Location = new Point(247, 90);
            textBoxTotalSkor.Margin = new Padding(2);
            textBoxTotalSkor.Multiline = true;
            textBoxTotalSkor.Name = "textBoxTotalSkor";
            textBoxTotalSkor.ReadOnly = true;
            textBoxTotalSkor.Size = new Size(80, 29);
            textBoxTotalSkor.TabIndex = 5;
            textBoxTotalSkor.TextAlign = HorizontalAlignment.Center;
            textBoxTotalSkor.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 176);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(542, 279);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridView1);
            Controls.Add(textBoxTotalSkor);
            Controls.Add(labelTotalSkor);
            Margin = new Padding(2);
            Name = "History";
            Size = new Size(596, 491);
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
