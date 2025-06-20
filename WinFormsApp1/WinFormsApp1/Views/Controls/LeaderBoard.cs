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

    public partial class LeaderBoard : UserControl
    {
        private NilaiController nilaiController = new NilaiController();
        public event EventHandler<UserControl> ContentDiganti;

        public LeaderBoard()
        {
            this.Load += LeaderBoard_Load;
            InitializeComponent();
        }

        private void LeaderBoard_Load(object sender, EventArgs e)
        {
            var leaderboardData = nilaiController.GetLeaderBoardFromFile();

            //ambil top 3
            if (leaderboardData.Count > 0)
            {
                lblJuara1Username.Text = leaderboardData[0].Username;
                lblJuara1Skor.Text = $"{leaderboardData[0].TotalBenar} ";
            }

            if (leaderboardData.Count > 1)
            {
                lblJuara2Username.Text = leaderboardData[1].Username;
                lblJuara2Skor.Text = $"{leaderboardData[1].TotalBenar} ";
            }

            if (leaderboardData.Count > 2)
            {
                lblJuara3Username.Text = leaderboardData[2].Username;
                lblJuara3Skor.Text = $"{leaderboardData[2].TotalBenar}";
            }

            // sisanya masuk ke DataGridView
            var peringkatLain = leaderboardData.Skip(3).Select((item, index) => new
            {
                Peringkat = index + 4,
                item.Username,
                Skor = item.TotalBenar,
                item.TotalSoal
            }).ToList();

            dataGridView1.DataSource = peringkatLain;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
