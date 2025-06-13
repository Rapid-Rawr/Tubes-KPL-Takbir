using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApp1.Views.Controls.FormSoal;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views.Controls
{
    public partial class KelolaSoalLokal : UserControl
    {
        private SoalController controller;
        public event EventHandler<UserControl> ContentDiganti;

        public KelolaSoalLokal(SoalController controller)
        {
            InitializeComponent();
            this.controller = controller;
            viewLoadSoal();
        }

        private void viewLoadSoal()
        {
            flowLayoutSoalLokal.Controls.Clear();

            foreach (var soal in controller.GetDaftarSoal())
            {
                var soalCard = new CardSoal();
                soalCard.SetData(soal);

                soalCard.OnEditClicked += (s, data) =>
                {
                    var formEditSoal = new FormSoal(FormSoal.ModeFormSoal.Edit, controller, data);
                    formEditSoal.ContentDiganti += (s, uc) => ContentDiganti?.Invoke(this, uc);
                    ContentDiganti?.Invoke(this, formEditSoal);
                };

                soalCard.OnHapusClicked += (s, data) =>
                {
                    var confirm = MessageBox.Show("Yakin ingin menghapus soal ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        controller.HapusSoalManual(data.id);
                        viewLoadSoal(); 
                    }
                };

                flowLayoutSoalLokal.Controls.Add(soalCard);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // btnTambahSoal
            var formTambahSoal = new FormSoal(ModeFormSoal.Tambah, controller);
            formTambahSoal.ContentDiganti += (s, uc) => ContentDiganti?.Invoke(this, uc);
            ContentDiganti?.Invoke(this, formTambahSoal);
        }

        private void flowLayoutSoalLokal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
