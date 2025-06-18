using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controllers;
using static WinFormsApp1.Controllers.SoalController;
using Microsoft.VisualBasic.ApplicationServices;
using WinFormsApp1.Views.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views.Controls
{
    public partial class PilihKategori : UserControl
    {
        private SoalController controller;
        public event EventHandler<UserControl> ContentDiganti;
        private string currentUsername;


        public PilihKategori(string currentUsername)
        {
            InitializeComponent();
            this.currentUsername = currentUsername;
        }

        private async Task LoadSoalDanBukaKuisAPI(SoalController.KategoriSoal kategori)
        {
            controller = new SoalController(SoalController.ModeSoal.API);
            bool sukses = await controller.AmbilSoalBerdasarkanKategori(kategori);

            if (!sukses)
            {
                MessageBox.Show("Gagal mengambil soal dari API, kerjakan Soal Lokal.");
                return;
            }

            // Sembunyikan WFUser
            Form parentForm = this.FindForm();
            parentForm.Hide();

            // Tampilkan WFKuis
            WFKuis formKuis = new WFKuis(controller, currentUsername, kategori.ToString());

            formKuis.FormClosed += (s, e) => parentForm.Show(); // kembali ke WFUser setelah kuis selesai
            formKuis.Show();
        }


        private void PilihKategori_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // btnSoalLokal
            controller = new SoalController(ModeSoal.Manual);
            var daftarSoal = controller.GetDaftarSoal();

            if (daftarSoal == null || daftarSoal.Count == 0)
            {
                MessageBox.Show("Soal lokal kosong atau gagal dimuat.");
                return;
            }

            // Sembunyikan form lama
            Form parentForm = this.FindForm();
            parentForm.Hide();

            // Buka form kuis
            WFKuis formKuis = new WFKuis(controller, currentUsername, KategoriSoal.Lokal.ToString());
            formKuis.FormClosed += (s, e) => parentForm.Show();
            formKuis.Show();
        }

        private async void btnKomputer_Click(object sender, EventArgs e)
        {
            await LoadSoalDanBukaKuisAPI(SoalController.KategoriSoal.Komputer);
        }

        private async void btnMatematika_Click(object sender, EventArgs e)
        {
            await LoadSoalDanBukaKuisAPI(SoalController.KategoriSoal.Matematika);
        }

        private async void btnIPA_Click(object sender, EventArgs e)
        {
            await LoadSoalDanBukaKuisAPI(SoalController.KategoriSoal.IPA);
        }

        private async void btnGeografi_Click(object sender, EventArgs e)
        {
            await LoadSoalDanBukaKuisAPI(SoalController.KategoriSoal.Geografi);
        }

        private async void btnSejarah_Click(object sender, EventArgs e)
        {
            await LoadSoalDanBukaKuisAPI(SoalController.KategoriSoal.Sejarah);
        }
    }
}
