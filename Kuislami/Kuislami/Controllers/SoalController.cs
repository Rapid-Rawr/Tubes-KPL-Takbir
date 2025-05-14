using System;
using System.Text.Json;
using Quiz.Models;

namespace Quiz.Controllers
{
    class soalController
    {
        public List<soal> Soal { get; private set; } = new();
        private string FilePath = "soalQuiz.json";


        private Dictionary<string, Action> CommandTable;

        public soalController()
        {
            LoadSoal();

            // inisialisasi table driven
            CommandTable = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase)
            {
                { "view", ViewAllSoal },
                { "delete", DeleteSoalByInput },
                { "save", SaveSoal },
                { "exit", () => Environment.Exit(0) }
            };
        }

        public void LoadSoal()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                var data = JsonSerializer.Deserialize<List<soal>>(json);
                if (data != null)
                    Soal = data;
            }
            Console.WriteLine($"Jumlah soal terbaca: {Soal.Count}");
        }

        public void SaveSoal()
        {
            var json = JsonSerializer.Serialize(Soal, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
            Console.WriteLine("Soal berhasil disimpan.");
        }

        public void AddSoal(soal q)
        {
            q.Id = Soal.Count > 0 ? Soal.Max(s => s.Id) + 1 : 1;
            Soal.Add(q);
            SaveSoal();
        }

        public void DeleteSoal(int id)
        {
            var soal = Soal.FirstOrDefault(s => s.Id == id);
            if (soal != null)
            {
                Soal.Remove(soal);
                Console.WriteLine("Soal berhasil dihapus.");
            }
            else
            {
                Console.WriteLine("Soal tidak ditemukan.");
            }
        }

        public void ViewAllSoal()
        {
            foreach (var s in Soal)
            {
                Console.WriteLine($"[{s.Id}] {s.Pertanyaan}");
                for (int i = 0; i < s.pilihan.Count; i++)
                    Console.WriteLine($"{i + 1}. {s.pilihan[i]}");
                Console.WriteLine();
            }
        }

        // hapus soal berdasarkan input id
        private void DeleteSoalByInput()
        {
            Console.Write("Masukkan ID soal yang ingin dihapus: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                DeleteSoal(id);
            }
            else
            {
                Console.WriteLine("Input tidak valid.");
            }
        }

        // pemroses command menggunakan table driven method
        public void ExecuteCommand(string command)
        {
            if (CommandTable.TryGetValue(command, out Action action))
                action();
            else
                Console.WriteLine("Perintah tidak dikenali.");
        }
    }
}


