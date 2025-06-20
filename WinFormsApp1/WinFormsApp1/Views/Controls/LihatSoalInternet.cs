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

namespace WinFormsApp1.Views.Controls
{
    public partial class LihatSoalInternet : UserControl
    {
        private SoalController controller;
        public event EventHandler<UserControl> ContentDiganti;

        public LihatSoalInternet(SoalController controller)
        {
            InitializeComponent();
            this.controller = controller;
            cbKategori.SelectedIndexChanged -= cbKategori_SelectedIndexChanged;
            cbKategori.DataSource = Enum
                .GetValues(typeof(SoalController.KategoriSoal))
                .Cast<SoalController.KategoriSoal>()
                .Where(k => SoalController.ApiKategoriTable.GetUrl(k) != null)
                .ToList();
            cbKategori.SelectedIndex = -1;
            cbKategori.SelectedIndexChanged += cbKategori_SelectedIndexChanged;
            viewLoadSoal();
        }

        private void viewLoadSoal()
        {

            flowLayoutSoalInternet.Controls.Clear();
            int nomor = 1;

            var daftarSoalApi = controller.GetDaftarSoal();
            if (daftarSoalApi == null || daftarSoalApi.Count == 0)
            {
                var labelInfo = new Label
                {
                    Text = "Tidak dapat menampilkan soal dari API, pilih kategori terlebih dahulu",
                    AutoSize = true,
                    ForeColor = Color.Black,
                    Font = new Font("Arial", 9, FontStyle.Bold),
                };
                flowLayoutSoalInternet.Controls.Add(labelInfo);
            }
            else
            {
                foreach (var soal in daftarSoalApi)
                {
                    var soalCard = new CardSoal();
                    soalCard.SetData(soal, nomor);
                    soalCard.ReadOnlyMode = true;

                    flowLayoutSoalInternet.Controls.Add(soalCard);
                    nomor++;
                }
            }

        }

        private async void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKategori.SelectedIndex == -1) return;

            if (cbKategori.SelectedItem is SoalController.KategoriSoal kategori)
            {
                bool sukses = await controller.AmbilSoalBerdasarkanKategori(kategori);
                if (!sukses)
                {
                    MessageBox.Show(
                        "Gagal mengambil soal dari API. Pastikan koneksi internet aktif.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                viewLoadSoal();
            }
        }

        private void LihatSoalInternet_Load(object sender, EventArgs e)
        {

        }
    }
}
