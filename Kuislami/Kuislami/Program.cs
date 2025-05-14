using Quiz.Controllers;
using Quiz.Models;

class Program
{
    static void Main()
    {
        var soalCtrl = new soalController();
        var userCtrl = new userController();

        while (true)
        {
            Console.WriteLine("\n===== Kuislami =====");
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
            Console.WriteLine("\n--- Menu Admin ---");
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
            Console.WriteLine("1. Mulai Kuis");
            Console.WriteLine("2. Lihat Skor");
            Console.WriteLine("3. Logout");
            Console.Write("Pilih: ");
            string? pilih = Console.ReadLine();

            if (pilih == "1")
            {
                int skor = 0;
                foreach (var soal in soalCtrl.Soal)
                {
                    Console.WriteLine($"\n{soal.Pertanyaan}");
                    for (int i = 0; i < soal.pilihan.Count; i++)
                        Console.WriteLine($"{i + 1}. {soal.pilihan[i]}");

                    Console.Write("Jawaban Anda (1-4): ");
                    int jawaban = int.Parse(Console.ReadLine()!) - 1;
                    if (jawaban == soal.Jawaban)
                        skor++;
                }
                user.Skor = skor;
                Console.WriteLine($"Skor Anda: {skor}/{soalCtrl.Soal.Count}");
            }
            else if (pilih == "2")
                Console.WriteLine($"Skor terakhir Anda: {user.Skor}");
            else if (pilih == "3")
                return;
        }
    }
}
