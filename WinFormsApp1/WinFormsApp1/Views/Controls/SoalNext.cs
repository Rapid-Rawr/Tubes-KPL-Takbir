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
using WinFormsApp1.Utilities;

namespace WinFormsApp1.Views.Controls
{
    public partial class SoalNext : UserControl
    {
        private List<Soal> soalList;
        private int indexSoal = 0;
        private int skor = 0;
        private string? jawabanDipilih = null;
        private Soal? soalSekarang = null;

        public event EventHandler<UserControl> ContentDiganti;

        public SoalNext(List<Soal> soal)
        {
            InitializeComponent();
            soalList = soal;
            TampilkanSoal();
            this.btnOpsiA.Click += new System.EventHandler(this.JawabanDipilih);
            this.btnOpsiB.Click += new System.EventHandler(this.JawabanDipilih);
            this.btnOpsiC.Click += new System.EventHandler(this.JawabanDipilih);
            this.btnOpsiD.Click += new System.EventHandler(this.JawabanDipilih);
        }

        private void TampilkanSoal()
        {
            if (indexSoal >= soalList.Count)
            {
                MessageBox.Show($"Kuis selesai! Skor Anda: {skor}/{soalList.Count}");

                var pilihKategori = new PilihKategori();
                ContentDiganti?.Invoke(this, pilihKategori);

                return;
            }

            soalSekarang = soalList[indexSoal];
            labelPertanyaan.Text = soalSekarang.pertanyaan;

            Button[] tombolOpsi = { btnOpsiA, btnOpsiB, btnOpsiC, btnOpsiD };

            for (int i = 0; i < 4; i++)
            {
                tombolOpsi[i].Text = soalSekarang.opsi[i];
                tombolOpsi[i].Tag = soalSekarang.opsi[i];
                tombolOpsi[i].BackColor = SystemColors.Control;
            }

            jawabanDipilih = null;
            btnNextSoal.Enabled = false;
        }

        private void JawabanDipilih(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                jawabanDipilih = btn.Tag?.ToString();
                btnNextSoal.Enabled = true;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            //label2.Text = ;
        }

        private void skor_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // btnNextSoal
            if (jawabanDipilih == null)
            {
                MessageBox.Show("Pilih jawaban dulu!");
                return;
            }

            if (jawabanDipilih != null && soalSekarang != null && jawabanDipilih == soalSekarang.jawaban)
            {
                skor++;
            }

            indexSoal++;
            TampilkanSoal();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
