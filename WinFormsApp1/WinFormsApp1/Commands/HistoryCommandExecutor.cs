using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Commands
{
    public class HistoryCommandExecutor
    {
        private IHistoryCommand _command;

        public void SetCommand(IHistoryCommand command)
        {
            _command = command;
        }

        public (List<HasilPengerjaan> history, int totalSkor) Execute()
        {
            return _command.Execute();
        }
    }
}
