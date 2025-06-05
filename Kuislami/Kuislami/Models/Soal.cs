using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quiz.Models
{
    public class Soal
    {
        public string pertanyaan { get; set; }
        public List<string> opsi { get; set; }
        public string jawaban { get; set; }
        public string kategori { get; set; }
    }
}
