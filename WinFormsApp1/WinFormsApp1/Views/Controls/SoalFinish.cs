using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views.Controls
{
    public partial class SoalFinish : UserControl
    {
        public string username { get; set; }
        public int totalSoal { get; set; }
        public int totalBenar { get; set; }

        public SoalFinish()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var hasilController = new HasilController();
            hasilController.SimpanHasil(username, totalSoal, totalBenar);

            MessageBox.Show("Hasil berhasil disimpan.");
        }
    }
}
