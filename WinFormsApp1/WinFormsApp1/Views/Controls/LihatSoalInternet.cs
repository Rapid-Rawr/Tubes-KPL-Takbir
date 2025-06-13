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
            cbKategori.DataSource = Enum.GetValues(typeof(SoalController.KategoriSoal));
            cbKategori.SelectedIndex = -1;
            viewLoadSoal();
        }

        private void viewLoadSoal()
        {
            flowLayoutSoalInternet.Controls.Clear();

            var daftarSoalApi = controller.GetDaftarSoal();
            if (daftarSoalApi.Count == 0)
            {
                var labelInfo = new Label
                {
                    Text = "Tidak ada soal",
                    AutoSize = true,
                    ForeColor = Color.Black,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                };
                flowLayoutSoalInternet.Controls.Add(labelInfo);
                return;
            }

            foreach (var soal in daftarSoalApi)
            {
                var soalCard = new CardSoal();
                soalCard.SetData(soal);
                soalCard.ReadOnlyMode = true;

                flowLayoutSoalInternet.Controls.Add(soalCard);
            }
        }

        private async void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            // pilih kategori soal
            if (cbKategori.SelectedItem is SoalController.KategoriSoal kategori)
            {
                await controller.AmbilSoalBerdasarkanKategori(kategori);
                viewLoadSoal();
            }
        }
    }
}
