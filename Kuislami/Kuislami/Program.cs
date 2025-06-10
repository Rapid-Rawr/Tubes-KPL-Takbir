using Kuislami.Models;
using Quiz.Controllers;
using Quiz.Models;
using System.Text.Json;


class Program
{
    static void Main()
    {
        var grader = new GradingController<int>();
        Console.WriteLine(grader.Calculate(3, 5));
        var soalCtrl = new soalController();
        var userCtrl = new userController();

        while (true)
        {
            Console.WriteLine("\n===== Quiz =====");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Keluar");
            Console.Write("Pilih: ");
            string? menu = Console.ReadLine();

            if (menu == "1")
                userCtrl.Register();
            else if (menu == "2")
            {
                if (userCtrl.Login())
                {
                    var user = userCtrl.GetCurrentUser();
                    if (user != null && user.IsAdmin)
                        MenuAdmin(soalCtrl, userCtrl);
                    else
                        MenuSiswa(soalCtrl, userCtrl, user!);
                }
            }
            else if (menu == "3")
                break;
        }
    }

    static void MenuAdmin(soalController soalCtrl, userController userCtrl)
    {
        while (true)
        {
            Console.WriteLine("\n==== Menu Admin ====");
            Console.WriteLine("1. Lihat Semua Soal");
            Console.WriteLine("2. Tambah Soal");
            Console.WriteLine("3. Hapus Soal");
            Console.WriteLine("4. Logout");
            Console.Write("Pilih: ");
            string? pilih = Console.ReadLine();

            if (pilih == "1")
                soalCtrl.ViewAllSoal();
            else if (pilih == "2")
            {
                Console.Write("Pertanyaan: ");
                string pertanyaan = Console.ReadLine()!;
                List<string> pilihan = new();
                for (int i = 0; i < 4; i++)
                {
                    Console.Write($"Pilihan {i + 1}: ");
                    pilihan.Add(Console.ReadLine()!);
                }
                Console.Write("Nomor jawaban benar (1-4): ");
                int benar = int.Parse(Console.ReadLine()!) - 1;
                soalCtrl.AddSoal(new soal { Pertanyaan = pertanyaan, pilihan = pilihan, Jawaban = benar });
            }
            else if (pilih == "3")
            {
                Console.Write("Masukkan ID soal yang ingin dihapus: ");
                int id = int.Parse(Console.ReadLine()!);
                soalCtrl.DeleteSoal(id);
            }
            else if (pilih == "4")
                return;
        }
    }

    static void MenuSiswa(soalController soalCtrl, userController userCtrl, user user)
    {
        while (true)
        {
            Console.WriteLine("\n--- Menu Siswa ---");
            Console.WriteLine("1. Pilih Kategori dan Mulai Quiz");
            Console.WriteLine("2. Lihat Skor");
            Console.WriteLine("3. Lihat Rank 1-3");
            Console.WriteLine("4. Logout");
            Console.Write("Pilih: ");
            string? pilih = Console.ReadLine();

            if (pilih == "1")
            {
                var kategoriList = soalCtrl.GetAllKategori();
                if (kategoriList.Count == 0)
                {
                    Console.WriteLine("Belum ada soal tersedia.");
                    continue;
                }

                Console.WriteLine("\nKategori tersedia:");
                for (int i = 0; i < kategoriList.Count; i++)
                    Console.WriteLine($"{i + 1}. {kategoriList[i]}");

                Console.Write("Pilih kategori (angka): ");
                if (!int.TryParse(Console.ReadLine(), out int indexKategori) || indexKategori < 1 || indexKategori > kategoriList.Count)
                {
                    Console.WriteLine("Pilihan kategori tidak valid.");
                    continue;
                }

                string kategoriDipilih = kategoriList[indexKategori - 1];
                var soalKategori = soalCtrl.GetSoalByKategori(kategoriDipilih);

                if (soalKategori.Count == 0)
                {
                    Console.WriteLine("Belum ada soal dalam kategori ini.");
                    continue;
                }

                Console.WriteLine($"\n--- Mulai Quiz: Kategori {kategoriDipilih} ---");
                int skor = 0;
                foreach (var soal in soalKategori)
                {
                    Console.WriteLine($"\n{soal.Pertanyaan}");
                    for (int i = 0; i < soal.pilihan.Count; i++)
                        Console.WriteLine($"{i + 1}. {soal.pilihan[i]}");

                    Console.Write("Jawaban Anda (1-4): ");
                    if (int.TryParse(Console.ReadLine(), out int jawaban) && jawaban - 1 == soal.Jawaban)
                        skor++;
                }

                user.Skor = skor;
                Console.WriteLine($"\nSkor Anda: {skor}/{soalKategori.Count}");
            }
            else if (pilih == "2")
            {
                Console.WriteLine($"Skor terakhir Anda: {user.Skor}");
            }
            else if (pilih == "3")
            {
                var topUsers = userCtrl.GetTopUsers(3);
                Console.WriteLine("\n--- Ranking Top 3 ---");
                for (int i = 0; i < topUsers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {topUsers[i].Username} - Skor: {topUsers[i].Skor}");
                }
            }
            else if (pilih == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid.");
            }
        }
    }




    static void SaveHistory(int totalSoal, int totalBenar)
        {
            string path = "history.json";
            List<QuizHistory> historyList = new();

            if (File.Exists(path))
            {
                string existingJson = File.ReadAllText(path);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    var existingData = JsonSerializer.Deserialize<List<QuizHistory>>(existingJson);
                    if (existingData != null)
                        historyList = existingData;
                }
            }

            historyList.Add(new QuizHistory
            {
                TotalSoal = totalSoal,
                TotalBenar = totalBenar
            });

            string newJson = JsonSerializer.Serialize(historyList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, newJson);
        }



}
