using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1.Commands
{
    public class AdminHistoryCommand : IHistoryCommand
    {
        private readonly NilaiController _controller;

        public AdminHistoryCommand(NilaiController controller)
        {
            _controller = controller;
        }

        public (List<HasilPengerjaan> history, int totalSkor) Execute()
        {
            return _controller.GetAllHistory();
        }
    }
}
