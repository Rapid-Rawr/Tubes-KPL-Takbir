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
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnToSkor_Click(object sender, EventArgs e)
        {
            //ini nanti mengarah ke usercontrol lihat panel, tapi belum saya buat nanti saya buat 
            var historyUC = new History(userName, false);
            ViewsHelper.GantiKontenPanel(panel2, historyUC);
        }

        private void btnToQuiz_Click(object sender, EventArgs e)
        {
            var kerjakanKuis = new PilihKategori(userName);
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
