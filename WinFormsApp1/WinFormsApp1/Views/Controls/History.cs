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
    public partial class History : UserControl
    {

        private NilaiController nilaiController = new NilaiController();

        public History(string? username = null, bool isAdmin = false)
        {
            InitializeComponent();

            if (isAdmin)
            {
                TampilkanUntukAdmin();
            }
            else if (username != null)
            {
                TampilkanUntukSiswa(username);
            }
        }

        private void TampilkanUntukAdmin()
        {
            var allHistory = nilaiController.GetAllHistory();
            dataGridView1.DataSource = allHistory;

            // Sembunyikan komponen siswa
            labelTotalSkor.Visible = false;
            textBoxTotalSkor.Visible = false;
        }

        private void TampilkanUntukSiswa(string username)
        {
            var (history, totalSkor) = nilaiController.GetUserHistory(username);
            dataGridView1.DataSource = history;

            labelTotalSkor.Text = "Total Skor Anda:";
            textBoxTotalSkor.Text = totalSkor.ToString();

            // Tampilkan komponen siswa
            labelTotalSkor.Visible = true;
            textBoxTotalSkor.Visible = true;
        }

        //public History()
        //{
        //    InitializeComponent();
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
