using Newtonsoft.Json;
using SoalAPI.Model;

namespace SoalAPI.Controller
{
    class SoalController
    {
        private ModeSoal mode;
        private string pathSoalAktif;
        private string filePathAPI = "soalAPI.json";
        private string filePathManual = "soalManual.json";
        private List<Soal> daftarSoal;

        public SoalController(ModeSoal modeOperasi)
        {
            mode = modeOperasi;
            pathSoalAktif = mode == ModeSoal.API ? filePathAPI : filePathManual;
            daftarSoal = LoadSoal(pathSoalAktif);
        }

        public enum ModeSoal
        {
            Manual,
            API
        }
        public enum KategoriSoal
        {
            Komputer,
            Matematika,
            IPA,
            Geografi,
            Sejarah
        }

        public static class ApiKategoriTable
        {
            private static readonly Dictionary<KategoriSoal, string> urlMap = new()
            {
                { KategoriSoal.Komputer, "https://opentdb.com/api.php?amount=5&category=18&type=multiple&difficulty=easy" },
                { KategoriSoal.Matematika, "https://opentdb.com/api.php?amount=5&category=19&type=multiple&difficulty=easy" },
                { KategoriSoal.IPA, "https://opentdb.com/api.php?amount=5&type=multiple&category=17&difficulty=easy" },
                { KategoriSoal.Geografi, "https://opentdb.com/api.php?amount=5&category=22&type=multiple&difficulty=easy" },
                { KategoriSoal.Sejarah, "https://opentdb.com/api.php?amount=5&category=23&type=multiple&difficulty=easy" }
            };

            public static string GetUrl(KategoriSoal kategori)
            {
                return urlMap[kategori];
            }
        }

        private List<Soal> LoadSoal(string pathSoal)
        {
            if (!File.Exists(pathSoal))
            {
                return new List<Soal>();
            }

            string json = File.ReadAllText(pathSoal);
            var semuaSoal = JsonConvert.DeserializeObject<List<Soal>>(json) ?? new List<Soal>();

            var unikSoal = semuaSoal.GroupBy(s => s.pertanyaan).Select(g => g.First()).ToList();

            return unikSoal;
        }

        public void TampilSoal()
        {
            if (daftarSoal.Count == 0)
            {
                Console.WriteLine("Belum ada soal");
                return;
            }
            foreach (var soal in daftarSoal)
            {
                Console.WriteLine($"ID: {soal.id}");
                Console.WriteLine($"Pertanyaan: {soal.pertanyaan}");
                for (int i = 0; i < soal.opsi.Count; i++)
                {
                    Console.WriteLine($"{(char)(65 + i)}. {soal.opsi[i]}");
                }
                Console.WriteLine($"Jawaban: {soal.jawaban}");
                Console.WriteLine(new string('-', 40));
            } 
        }

        public async Task AmbilSoalBerdasarkanKategori(KategoriSoal kategori)
        {
            string apiUrl = ApiKategoriTable.GetUrl(kategori);
            await AmbilSoal(apiUrl, true);
        }

        public void SimpanSoal(string pathSoal)
        {
            var json = JsonConvert.SerializeObject(daftarSoal, Formatting.Indented);
            File.WriteAllText(pathSoal, json);
        }

        public async Task AmbilSoal(string apiUrl, bool overwrite)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    var apiResponse = JsonConvert.DeserializeObject<TriviaApiResponse>(jsonResponse);

                    if (apiResponse != null && apiResponse.results != null)
                    {
                        if (overwrite)
                        {
                            daftarSoal.Clear();
                            if (File.Exists(filePathAPI)) File.Delete(filePathAPI);
                        }

                        int id = daftarSoal.Count > 0 ? daftarSoal[^1].id + 1 : 1;

                        foreach (var soal in apiResponse.results)
                        {
                            string pertanyaan = System.Net.WebUtility.HtmlDecode(soal.question);
                            bool sudahAda = daftarSoal.Any(s => s.pertanyaan == pertanyaan);

                            if (!sudahAda)
                            {
                                var pilihan = new List<string>(soal.incorrect_answers);
                                pilihan.Add(soal.correct_answer);
                                var rndm = new Random();
                                pilihan = pilihan.OrderBy(x => rndm.Next()).ToList();

                                daftarSoal.Add(new Soal
                                {
                                    id = id++,
                                    pertanyaan = pertanyaan,
                                    jawaban = soal.correct_answer,
                                    opsi = pilihan,
                                });
                            }
                        }
                        SimpanSoal(filePathAPI);
                        Console.WriteLine("Soal berhasil diambil dan disimpan");
                    }
                    else
                    {
                        Console.WriteLine("Tidak ada soal yang ditemukan dalam API");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Gagal mengambil soal dari API: {ex.Message}");
                }
            }
        }

        public void TambahSoalManual()
        {
            Console.Write("Masukkan pertanyaan: ");
            string pertanyaan = Console.ReadLine() ?? "";

            Console.WriteLine("Masukkan 4 opsi jawaban:");
            List<string> opsi = new();
            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Opsi {i}: ");
                opsi.Add(Console.ReadLine() ?? "");
            }

            Console.Write("Masukkan jawaban benar: ");
            string jawaban = Console.ReadLine() ?? "";

            int id = daftarSoal.Count > 0 ? daftarSoal[^1].id + 1 : 1;

            daftarSoal.Add(new Soal
            {
                id = id,
                pertanyaan = pertanyaan,
                opsi = opsi,
                jawaban = jawaban
            });

            SimpanSoal(filePathManual);
            Console.WriteLine("Soal berhasil ditambahkan.");
        }

        public void EditSoalManual()
        {
            TampilSoal();
            Console.Write("Masukkan ID soal yang ingin diedit: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var soal = daftarSoal.FirstOrDefault(s => s.id == id);
                if (soal != null)
                {
                    Console.Write("Pertanyaan baru (kosongkan jika tidak ingin mengubah): ");
                    string pertanyaanBaru = Console.ReadLine() ?? "";
                    if (!string.IsNullOrWhiteSpace(pertanyaanBaru)) soal.pertanyaan = pertanyaanBaru;

                    for (int i = 0; i < soal.opsi.Count; i++)
                    {
                        Console.Write($"Opsi {i + 1} (kosongkan jika tidak ingin mengubah): ");
                        string opsiBaru = Console.ReadLine() ?? "";
                        if (!string.IsNullOrWhiteSpace(opsiBaru)) soal.opsi[i] = opsiBaru;
                    }

                    Console.Write("Jawaban baru (kosongkan jika tidak ingin mengubah): ");
                    string jawabanBaru = Console.ReadLine() ?? "";
                    if (!string.IsNullOrWhiteSpace(jawabanBaru)) soal.jawaban = jawabanBaru;

                    SimpanSoal(filePathManual);
                    Console.WriteLine("Soal berhasil diedit.");
                }
                else Console.WriteLine("Soal tidak ditemukan.");
            }
            else Console.WriteLine("ID tidak valid.");
        }

        public void HapusSoalManual()
        {
            TampilSoal();
            Console.Write("Masukkan ID soal yang ingin dihapus: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var soal = daftarSoal.FirstOrDefault(s => s.id == id);
                if (soal != null)
                {
                    daftarSoal.Remove(soal);
                    SimpanSoal(filePathManual);
                    Console.WriteLine("Soal berhasil dihapus.");
                }
                else Console.WriteLine("Soal tidak ditemukan.");
            }
            else Console.WriteLine("ID tidak valid.");
        }
    }
}
