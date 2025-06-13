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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // btnTambahSoal
            //var formTambahSoal = new FormSoal(ModeFormSoal.Tambah, controller);
            //ContentDiganti?.Invoke(this, formTambahSoal);
            var formTambahSoal = new FormSoal(ModeFormSoal.Tambah, controller);
            formTambahSoal.ContentDiganti += (s, uc) => ContentDiganti?.Invoke(this, uc); // relay event
            ContentDiganti?.Invoke(this, formTambahSoal);
        }

        private void flowLayoutSoalLokal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KelolaSoalLokal_Load(object sender, EventArgs e)
        {

        }
    }
}
