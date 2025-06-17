using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Controllers;
using WinFormsApp1.Views.Controls;

namespace WinFormsApp1.Views.Forms
{
    public partial class WFKuis : Form
    {
        private SoalController controller;
        private List<Soal> daftarSoal;
        private int indeksSoal = 0;
        private int skor = 0;

        private SoalNext currentSoalControl;

        public WFKuis(SoalController controller)
        {
            InitializeComponent();
            this.controller = controller;
            daftarSoal = controller.GetDaftarSoal();
            TampilkanSoalBerikutnya();
        }

        private void TampilkanSoalBerikutnya()
        {
            if (indeksSoal >= daftarSoal.Count)
            {
                MessageBox.Show($"Kuis selesai!\nSkor Anda: {skor}/{daftarSoal.Count}");
                this.Close();
                return;
            }

            var soal = daftarSoal[indeksSoal];
            currentSoalControl = new SoalNext(soal);
            currentSoalControl.Dock = DockStyle.Fill;

            panelKuis.Controls.Clear();
            panelKuis.Controls.Add(currentSoalControl);

            indeksSoal++;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentSoalControl == null)
                return;

            string jawabanUser = currentSoalControl.JawabanDipilih;

            if (string.IsNullOrEmpty(jawabanUser))
            {
                MessageBox.Show("Pilih salah satu jawaban terlebih dahulu.");
                return;
            }

            if (jawabanUser == daftarSoal[indeksSoal - 1].jawaban)
            {
                skor++;
            }

            TampilkanSoalBerikutnya();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda yakin ingin keluar dari kuis?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
