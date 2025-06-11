using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Soal
    {
        public int id { get; set; }
        public string pertanyaan { get; set; }
        public List<string> opsi { get; set; }
        public string jawaban { get; set; }
    }
}
