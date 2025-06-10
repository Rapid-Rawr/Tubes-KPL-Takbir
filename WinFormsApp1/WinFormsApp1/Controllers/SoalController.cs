using System;
using System.Text.Json;
using Quiz.Models;
using System.Net.Http;
using System.Text.Json.Nodes;


namespace Quiz.Controllers
{
    
    public class soalController
    {
        private List<soal> daftarSoal = new();

        public soalController()
        {
            LoadSoalFromJson();
        }

        private void LoadSoalFromJson()
        {
            string filePath = "soalQuiz.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                daftarSoal = JsonSerializer.Deserialize<List<soal>>(json) ?? new List<soal>();
            }
        }

        public List<string> GetAllKategori()
        {
            return new List<string> { "Umum" };
        }

        public List<soal> GetSoalByKategori(string kategori)
        {
            return daftarSoal;
        }

        public void ViewAllSoal()
        {
            foreach (var s in daftarSoal)
            {
                Console.WriteLine($"ID: {s.Id}, Pertanyaan: {s.Pertanyaan}");
            }
        }

        public void AddSoal(soal newSoal)
        {
            newSoal.Id = daftarSoal.Count > 0 ? daftarSoal.Max(s => s.Id) + 1 : 1;
            daftarSoal.Add(newSoal);
            SaveToJson();
        }

        public void DeleteSoal(int id)
        {
            var soalToRemove = daftarSoal.FirstOrDefault(s => s.Id == id);
            if (soalToRemove != null)
            {
                daftarSoal.Remove(soalToRemove);
                SaveToJson();
            }
        }

        private void SaveToJson()
        {
            string json = JsonSerializer.Serialize(daftarSoal, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("soalQuiz.json", json);
        }
    }

}


