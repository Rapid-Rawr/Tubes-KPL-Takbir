using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApp1.Controllers.SoalController;
using WinFormsApp1.Controllers;
using WinFormsApp1.Utilities;
using WinFormsApp1.Views.Controls;
//using WinFormsApp1.Models;

namespace WinFormsApp1.Views.Forms
{
    public partial class WFUser : Form
    {
        private string userName;


        public WFUser(Models.Users user)
        {
            userName = user.Username;
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
        private void btnToLeaderboard_Click(object sender, EventArgs e)
        {
            var leaderboard = new LeaderBoard();
            leaderboard.ContentDiganti += (s, uc) => ViewsHelper.GantiKontenPanel(panel2, uc);
            ViewsHelper.GantiKontenPanel(panel2, leaderboard);
            //ini harusnya kode untuk mengarah ke user controll LeaderBoard 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //ini konten awal, yang akan digantikan oleh userControl
        }

        private void btnToSkor_Click(object sender, EventArgs e)
        {
            //ini nanti mengarah ke usercontrol lihat panel, tapi belum saya buat nanti saya buat 
        }

        private void btnToQuiz_Click(object sender, EventArgs e)
        {
            ////ini mengarah ke user control menu pemilihan kategori soal
            //var kategori = new PilihKategori();
            ////kategori.ContentDiganti += (s, uc) => ViewsHelper.GantiKontenPanel(panel2, uc);
            ////ViewsHelper.GantiKontenPanel(panel2, kategori);

            //kategori.ContentDiganti += (s, uc) =>
            //{
            //    // jika yang dikirim adalah SoalNext, kita perlu juga subscribe event-nya!
            //    if (uc is SoalNext soalNext)
            //    {
            //        soalNext.ContentDiganti += (s2, uc2) =>
            //        {
            //            ViewsHelper.GantiKontenPanel(panel2, uc2);
            //        };
            //    }

            //    ViewsHelper.GantiKontenPanel(panel2, uc);
            //};

            //ViewsHelper.GantiKontenPanel(panel2, kategori);

            var kerjakanKuis = new PilihKategori();
            kerjakanKuis.ContentDiganti += (s, uc) => ViewsHelper.GantiKontenPanel(panel2, uc);
            ViewsHelper.GantiKontenPanel(panel2, kerjakanKuis);
        }


        public void TampilkanGrading(int totalSoal, int totalBenar)
        {
            var grading = new Grading();
            grading.SetNilai(totalSoal, totalBenar); 
            ViewsHelper.GantiKontenPanel(panel2, grading);
        }


    }
}
