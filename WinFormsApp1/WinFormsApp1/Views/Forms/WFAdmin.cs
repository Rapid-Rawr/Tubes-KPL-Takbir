using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Views.Controls;
using WinFormsApp1.Utilities;
using WinFormsApp1.Controllers;
using static WinFormsApp1.Controllers.SoalController;

namespace WinFormsApp1.Views.Forms
{
    public partial class WFAdmin : Form
    {
        private SoalController controllerManual;
        private SoalController controllerAPI;

        public WFAdmin()
        {
            InitializeComponent();
            //controllerManual = new SoalController(ModeSoal.Manual);
            //controllerAPI = new SoalController(ModeSoal.API, false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // btnToKelolaSoal
            ShowKelolaSoal();
        }

        private void btnToSoalInternet_Click(object sender, EventArgs e)
        {
            ShowSoalInternet();
        }

        private void ShowKelolaSoal()
        {
            controllerManual = new SoalController(ModeSoal.Manual);

            var kelolaSoal = new KelolaSoalLokal(controllerManual);
            kelolaSoal.ContentDiganti += (s, uc) => ViewsHelper.GantiKontenPanel(ContentPanel, uc);
            ViewsHelper.GantiKontenPanel(ContentPanel, kelolaSoal);
        }

        private void ShowSoalInternet()
        {
            if (File.Exists("soalAPI.json")) File.Delete("soalAPI.json");
            controllerAPI = new SoalController(ModeSoal.API, false);
            
            var soalInternet = new LihatSoalInternet(controllerAPI);
            soalInternet.ContentDiganti += (s, uc) => ViewsHelper.GantiKontenPanel(ContentPanel, uc);
            ViewsHelper.GantiKontenPanel(ContentPanel, soalInternet);
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

    }
}
