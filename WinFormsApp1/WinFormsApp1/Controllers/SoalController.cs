using Newtonsoft.Json;
using WinFormsApp1.Models;
using WinFormsApp1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Controllers
{
    public class SoalController
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

            var semuaSoal = JsonHelper.LoadFromFile<List<Soal>>(pathSoal) ?? new List<Soal>();
            var unikSoal = semuaSoal.GroupBy(s => s.pertanyaan).Select(g => g.First()).ToList();

            return unikSoal;
        }

        public List<Soal> GetDaftarSoal()
        {
            return daftarSoal;
        }

        public void SimpanSoal()
        {
            JsonHelper.SaveToFile(pathSoalAktif, daftarSoal);
        }

        public async Task AmbilSoalBerdasarkanKategori(KategoriSoal kategori)
        {
            string apiUrl = ApiKategoriTable.GetUrl(kategori);
            await AmbilSoal(apiUrl, true);
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
                        SimpanSoal();
                        daftarSoal = LoadSoal(pathSoalAktif);
                    }
                }
                catch (Exception ex)
                {
                   
                }
            }
        }

        public void TambahSoalManual(string pertanyaanSoal, List<string> opsiSoal, string jawabanSoal)
        {
            string pertanyaan = pertanyaanSoal;
            List<string> opsi = opsiSoal;
            string jawaban = jawabanSoal;

            int id = daftarSoal.Count > 0 ? daftarSoal[^1].id + 1 : 1;

            daftarSoal.Add(new Soal
            {
                id = id,
                pertanyaan = pertanyaan,
                opsi = opsi,
                jawaban = jawaban
            });

            SimpanSoal();
        }

        public void EditSoalManual(int id, string pertanyaanBaru, List<string> opsiBaru, string jawabanBaru)
        {
            var soal = daftarSoal.FirstOrDefault(s => s.id == id);
            if (soal != null)
            {
                soal.pertanyaan = pertanyaanBaru;
                soal.opsi = opsiBaru;
                soal.jawaban = jawabanBaru;

                SimpanSoal();
            }
        }

        public void HapusSoalManual(int id)
        {
            var soal = daftarSoal.FirstOrDefault(s => s.id == id);
            if (soal != null)
            {
                daftarSoal.Remove(soal);
                SimpanSoal();
            }
        }
    }
}