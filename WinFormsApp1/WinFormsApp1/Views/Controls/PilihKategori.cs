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

        public PilihKategori()
        {
            InitializeComponent();
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
            this.Hide();
            //new WFUser(user).Show();
            // navigasi ke halaman pengerjaan kuis
            var pengerjaanKuis = new SoalNext(controller.GetDaftarSoal());
            pengerjaanKuis.Dock = DockStyle.Fill;
            ContentDiganti?.Invoke(this, pengerjaanKuis);
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

            var pengerjaanKuis = new SoalNext(daftarSoal);
            ContentDiganti?.Invoke(this, pengerjaanKuis);
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
