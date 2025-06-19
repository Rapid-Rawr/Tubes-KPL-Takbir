using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Commands
{
    public interface IHistoryCommand
    {
        (List<HasilPengerjaan> history, int totalSkor) Execute();
    }
}
