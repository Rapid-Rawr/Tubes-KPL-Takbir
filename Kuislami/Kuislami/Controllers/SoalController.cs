using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Kuislami.Models;
using Quiz.Models;

namespace Kuislami.Controllers
{
    public class SoalController
    {
        private static string soalFile = "soalQuiz.json";
        private static string hasilFile = "hasil.json";

        public static void MulaiKuis(user currentUser)
        {
            List<Soal> soalList = JsonConvert.DeserializeObject<List<Soal>>(File.ReadAllText(soalFile));
            if (soalList == null || soalList.Count == 0)
            {
                Console.WriteLine("Tidak ada soal yang tersedia.");
                return;
            }

            string kategori = soalList[0].kategori;
            int totalSoal = soalList.Count;
            int totalBenar = 0;

            for (int i = 0; i < soalList.Count; i++)
            {
                Console.Clear();
                var soal = soalList[i];

                Console.WriteLine($"Soal {i + 1}: {soal.pertanyaan}");
                for (int j = 0; j < soal.opsi.Count; j++)
                {
                    Console.WriteLine($"{j + 1}. {soal.opsi[j]}");
                }

                Console.Write("\nJawaban Anda: ");
                string input = Console.ReadLine();

                try
                {
                    int pilihan = int.Parse(input);
                    if (pilihan >= 1 && pilihan <= soal.opsi.Count)
                    {
                        if (soal.opsi[pilihan - 1] == soal.jawaban)
                        {
                            Console.WriteLine("✅ Benar!");
                            totalBenar++;
                        }
                        else
                        {
                            Console.WriteLine($"❌ Salah. Jawaban yang benar: {soal.jawaban}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pilihan tidak valid.");
                    }
                }
                catch
                {
                    Console.WriteLine("Input tidak valid.");
                }

                Console.WriteLine("Tekan Enter untuk lanjut...");
                Console.ReadLine();
            }

            // Simpan hasil
            Hasil hasil = new Hasil
            {
                Username = currentUser.Username,
                Kategori = kategori,
                TotalSoal = totalSoal,
                TotalBenar = totalBenar
            };

            List<Hasil> hasilList = new();
            if (File.Exists(hasilFile))
            {
                hasilList = JsonConvert.DeserializeObject<List<Hasil>>(File.ReadAllText(hasilFile)) ?? new List<Hasil>();
            }

            hasilList.Add(hasil);
            File.WriteAllText(hasilFile, JsonConvert.SerializeObject(hasilList, Formatting.Indented));

            Console.WriteLine($"\n📄 Hasil kuis disimpan ke {hasilFile}");
        }
    }
}
