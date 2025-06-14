﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views.Controls
{
    public partial class FormSoal : UserControl
    {
        private ModeFormSoal mode;
        private SoalController controller;
        private Soal? soalYangDiedit;
        public event EventHandler<UserControl>? ContentDiganti;

        public enum ModeFormSoal
        {
            Tambah,
            Edit
        }

        public FormSoal(ModeFormSoal modeOperasi, SoalController controller, Soal? soal = null)
        {
            InitializeComponent();
            this.mode = modeOperasi;
            this.controller = controller;
            soalYangDiedit = soal;
            labelTambahEdit.Text = modeOperasi == ModeFormSoal.Tambah ? "Form Tambah Soal" : "Form Edit Soal";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // btnSimpan
            string pertanyaan = tbSoal.Text.Trim();
            List<string> opsi = new List<string>
            {
                tbA.Text.Trim(),
                tbB.Text.Trim(),
                tbC.Text.Trim(),
                tbD.Text.Trim()
            };
            string jawaban = tbJawaban.Text.Trim();

            if (mode == ModeFormSoal.Tambah)
            {
                bool sukses = controller.TambahSoalManual(pertanyaan, opsi, jawaban);
                if (!sukses)
                {
                    MessageBox.Show("Jawaban harus ada dalam salah satu opsi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Soal berhasil ditambahkan");
            }
            else if (mode == ModeFormSoal.Edit && soalYangDiedit != null)
            {
                bool sukses = controller.EditSoalManual(soalYangDiedit.id, pertanyaan, opsi, jawaban);
                if (!sukses)
                {
                    MessageBox.Show("Jawaban harus ada dalam salah satu opsi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Soal berhasil diedit");
            }

            var kembali = new KelolaSoalLokal(controller);
            kembali.ContentDiganti += (s, uc) => ContentDiganti?.Invoke(this, uc);
            ContentDiganti?.Invoke(this, kembali);
        }

        private void FormSoal_Load(object sender, EventArgs e)
        {
            if (mode == ModeFormSoal.Edit && soalYangDiedit != null)
            {
                tbSoal.Text = soalYangDiedit.pertanyaan;
                tbA.Text = soalYangDiedit.opsi[0];
                tbB.Text = soalYangDiedit.opsi[1];
                tbC.Text = soalYangDiedit.opsi[2];
                tbD.Text = soalYangDiedit.opsi[3];
                tbJawaban.Text = soalYangDiedit.jawaban;
            }
        }

        private void labelTambahEdit_Click(object sender, EventArgs e)
        {

        }

        private void tbSoal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
