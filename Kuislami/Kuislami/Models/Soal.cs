using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuislami.Models
{
    class Soal
    {
        public int id { get; set; }
        //public string tipe { get; set; } // pilgan / true false
        public string pertanyaan { get; set; }
        public List<string> opsi { get; set; } 
        public string jawaban { get; set; }
    }
}
