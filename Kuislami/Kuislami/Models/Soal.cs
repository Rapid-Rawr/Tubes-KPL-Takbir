using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    class soal
    {
        public int Id { get; set; }
        public string Pertanyaan { get; set; }
        public List<string> pilihan { get; set; }
        public int Jawaban { get; set; } 
    }
}
