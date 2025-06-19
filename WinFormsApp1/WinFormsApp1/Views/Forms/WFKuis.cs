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
using WinFormsApp1.Utilities;

namespace WinFormsApp1.Views.Forms
{
    public partial class WFKuis : Form
    {
        private WFUser formUser;
        private SoalController controller;
        private List<Soal> daftarSoal;
        private int indeksSoal = 0;
        private int skor = 0;

        private string currentUsername;

        private SoalNext currentSoalControl;
        private string currentKategori;
        private NilaiController nilaiController = new();

        public WFKuis(SoalController controller, string username, string kategori, WFUser formUser)
        {
            InitializeComponent();
            this.controller = controller;
            this.currentUsername = username;
            this.currentKategori = kategori;
            this.formUser = formUser;

            daftarSoal = controller.GetDaftarSoal();
            TampilkanSoalBerikutnya();
        }

        private void TampilkanSoalBerikutnya()
        {
            if (indeksSoal >= daftarSoal.Count)
            {
                int nilaiAkhir = nilaiController.menilai(daftarSoal.Count, skor);

                var hasil = new HasilPengerjaan
                {
                    Username = currentUsername,
                    Kategori = currentKategori,
                    TotalSoal = daftarSoal.Count,
                    TotalBenar = skor
                };
                nilaiController.SimpanHasil(hasil);

                var grading = new Grading();
                grading.Dock = DockStyle.Fill;

                
                var panel2 = formUser.Controls["panel2"] as Panel;
                if (panel2 != null)
                {
                    ViewsHelper.GantiKontenPanel(panel2, grading);
                }

                formUser.TampilkanGrading(daftarSoal.Count, skor);
                this.Close();
                return;
            }

            var soal = daftarSoal[indeksSoal];
            currentSoalControl = new SoalNext(soal);
            currentSoalControl.Dock = DockStyle.Fill;

            panelKuis.Controls.Clear();
            panelKuis.Controls.Add(currentSoalControl);

            if (indeksSoal == daftarSoal.Count - 1)
            {
                btnNext.Text = "Finish";
            }
            else
            {
                btnNext.Text = "Next";
            }

            indeksSoal++;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentSoalControl == null)
            {
                return;
            }

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

        private void panelKuis_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WFKuis_Load(object sender, EventArgs e)
        {

        }
    }
}
