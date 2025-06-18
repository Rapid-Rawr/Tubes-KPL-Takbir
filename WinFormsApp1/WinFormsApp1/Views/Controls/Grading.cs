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
    public partial class Grading : UserControl
    {
        public Grading()
        {
            InitializeComponent();
        }

        private void Grading_Load(object sender, EventArgs e)
        {

        }

        public void SetNilai(int totalSoal, int totalBenar)
        {
            NilaiController controller = new NilaiController();
            int skor = controller.menilai(totalSoal, totalBenar);

            lblSkor.Text = $"{skor}";
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
