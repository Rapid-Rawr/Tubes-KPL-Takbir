using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views.Controls
{
    public partial class SoalNext : UserControl
    {
        private Soal soal;


        public SoalNext(Soal soal)
        {
            InitializeComponent();
            this.soal = soal;
            TampilkanSoal();
        }

        private void TampilkanSoal()
        {
            labelSoal.Text = soal.pertanyaan;
            btnOpsiA.Text = soal.opsi[0];
            btnOpsiB.Text = soal.opsi[1];
            btnOpsiC.Text = soal.opsi[2];
            btnOpsiD.Text = soal.opsi[3];
        }

        public string JawabanDipilih { get; private set; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void skor_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            JawabanDipilih = btnOpsiA.Text;
        }

        private void btnOpsiB_Click(object sender, EventArgs e)
        {
            JawabanDipilih = btnOpsiB.Text;
        }

        private void btnOpsiC_Click(object sender, EventArgs e)
        {
            JawabanDipilih = btnOpsiC.Text;
        }

        private void btnOpsiD_Click(object sender, EventArgs e)
        {
            JawabanDipilih = btnOpsiD.Text;
        }

        private void labelSoal_Click(object sender, EventArgs e)
        {
            
        }
    }
}
