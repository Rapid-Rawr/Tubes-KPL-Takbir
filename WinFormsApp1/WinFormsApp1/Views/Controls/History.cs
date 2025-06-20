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
using System.CodeDom.Compiler;
using WinFormsApp1.Commands;

namespace WinFormsApp1.Views.Controls
{
    public partial class History : UserControl
    {

        private NilaiController nilaiController = new NilaiController();
        private HistoryCommandExecutor executor = new HistoryCommandExecutor();

        public History(string? username = null, bool isAdmin = false)
        {
            InitializeComponent();

            if (isAdmin)
            {
                executor.SetCommand(new AdminHistoryCommand(nilaiController));
            }
            else if (username != null)
            {
                executor.SetCommand(new UserHistoryCommand(nilaiController, username));
            }

            var (history, totalSkor) = executor.Execute();
            dataGridView1.DataSource = history;
            textBoxTotalSkor.Text = totalSkor.ToString();
            labelTotalSkor.Text = isAdmin ? "Total Skor Keseluruhan:" : "Total Skor Anda:";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void History_Load(object sender, EventArgs e)
        {

        }
    }
}
