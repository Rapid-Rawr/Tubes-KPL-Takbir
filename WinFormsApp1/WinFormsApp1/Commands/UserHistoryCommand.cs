using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1.Commands
{
    public class UserHistoryCommand : IHistoryCommand
    {
        private readonly NilaiController _controller;
        private readonly string _username;

        public UserHistoryCommand(NilaiController controller, string username)
        {
            _controller = controller;
            _username = username;
        }

        public (List<HasilPengerjaan> history, int totalSkor) Execute()
        {
            return _controller.GetUserHistory(_username);
        }
    }
}
