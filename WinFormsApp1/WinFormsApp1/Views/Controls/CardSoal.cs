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
using WinFormsApp1.Models;

namespace WinFormsApp1.Views.Controls
{
    public partial class CardSoal : UserControl
    {
        private SoalController controller;
        private Soal dataSoal;

        public event EventHandler<Soal> OnEditClicked;
        public event EventHandler<Soal> OnHapusClicked;

        public CardSoal()
        {
            InitializeComponent();
        }

        public void SetData(Soal soal)
        {
            dataSoal = soal;
            labelSoal.Text = soal.pertanyaan;
            labelA.Text = "A. " + soal.opsi[0];
            labelB.Text = "B. " + soal.opsi[1];
            labelC.Text = "C. " + soal.opsi[2];
            labelD.Text = "D. " + soal.opsi[3];
            labelJawaban.Text = "Jawaban: " + soal.jawaban;
        }

        public bool ReadOnlyMode
        {
            get => !btnEdit.Visible && !btnHapus.Visible;
            set
            {
                btnEdit.Visible = !value;
                btnHapus.Visible = !value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // btnEdit
            OnEditClicked?.Invoke(this, dataSoal);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            OnHapusClicked?.Invoke(this, dataSoal);
        }
    }
}
