using Newtonsoft.Json;
using SoalAPI.Model;

namespace SoalAPI.Controller
{
    class SoalController
    {
        private string filePath = "soal.json";
        private List<Soal> daftarSoal;

        public SoalController()
        {
            daftarSoal = LoadSoal();
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

        private List<Soal> LoadSoal()
        {
            if (!File.Exists(filePath))
            {
                return new List<Soal>();
            }

            string json = File.ReadAllText(filePath);
            var semuaSoal = JsonConvert.DeserializeObject<List<Soal>>(json) ?? new List<Soal>();

            var unikSoal = semuaSoal.GroupBy(s => s.pertanyaan).Select(g => g.First()).ToList();

            return unikSoal;
        }

        public void TampilSemuaSoal()
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

        public void SimpanKeFile()
        {
            var json = JsonConvert.SerializeObject(daftarSoal, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        //public async Task AmbilSoal(string apiUrl)
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
                            if (File.Exists(filePath)) File.Delete(filePath);
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
                        SimpanKeFile();
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
    }
}
