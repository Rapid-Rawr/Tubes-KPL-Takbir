using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Utilities
{
    public static class ViewsHelper
    {
        public static void GantiKontenPanel(Panel panelTarget, UserControl kontenBaru)
        {
            panelTarget.Controls.Clear();
            kontenBaru.Dock = DockStyle.Fill;
            panelTarget.Controls.Add(kontenBaru);
        }
    }
}
