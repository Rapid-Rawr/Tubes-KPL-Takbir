using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
//using Newtonsoft.Json;
using System.IO;
using Kuislami.Models;
using System.Xml;

namespace Kuislami.Controllers
{
    class SoalController
    {
        private string filePath = "soal.json";
        private List<Soal> daftarSoal;

        public SoalController()
        {
            daftarSoal = LoadSoal();
        }

        public List<Soal> GetAllSoal()
        {
            return daftarSoal;
        }

        public Soal GetById(int id)
        {
            return daftarSoal.Find(s => s.id == id);
        }

        public void TambahSoal(Soal soal)
        {
            soal.id = daftarSoal.Count > 0 ? daftarSoal[^1].id + 1 : 1;
            daftarSoal.Add(soal);
            SimpanKeFile();
        }

        public bool HapusSoal(int id)
        {
            var target = daftarSoal.Find(s => s.id == id);
            if (target != null)
            {
                daftarSoal.Remove(target);
                SimpanKeFile();
                return true;
            }
            return false;
        }

        public void SimpanKeFile()
        {
            //var json = JsonConvert.SerializeObject(daftarSoal, Formatting.Indented);
            var json = JsonSerializer.Serialize(daftarSoal, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        private List<Soal> LoadSoal()
        {
            if (!File.Exists(filePath))
            {
                return new List<Soal>();
            }

            string json = File.ReadAllText(filePath);
            //return JsonConvert.DeserializeObject<List<Soal>>(json) ?? new List<Soal>();
            return JsonSerializer.Deserialize<List<Soal>>(json) ?? new List<Soal>();
        }
    }
}
