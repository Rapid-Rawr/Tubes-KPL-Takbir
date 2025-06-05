using SoalAPI.Controller;
using static SoalAPI.Controller.SoalController;

namespace SoalAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var controllerManual = new SoalController(ModeSoal.Manual);
            var controllerAPI = new SoalController(ModeSoal.API);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== MENU UTAMA ===");
                Console.WriteLine("1. Ambil Soal dari API");
                Console.WriteLine("2. Kelola Soal Random (Admin)");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu: ");

                string? pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        Console.WriteLine("=== Pilih Kategori Soal ===");
                        foreach (var kategori in Enum.GetValues(typeof(KategoriSoal)))
                        {
                            Console.WriteLine($"{(int)kategori} - {kategori}");
                        }

                        Console.Write("Masukkan nomor kategori: ");
                        if (int.TryParse(Console.ReadLine(), out int input) &&
                            Enum.IsDefined(typeof(KategoriSoal), input))
                        {
                            KategoriSoal kategoriDipilih = (KategoriSoal)input;
                            await controllerAPI.AmbilSoalBerdasarkanKategori(kategoriDipilih);
                            Console.WriteLine("Soal berhasil diambil!");

                            Console.WriteLine("\n=== Soal untuk Dikerjakan ===");
                            controllerAPI.TampilSoal();
                        }
                        else
                        {
                            Console.WriteLine("Input tidak valid.");
                        }
                        break;

                    case "2":
                        while (true)
                        {
                            Console.WriteLine("\n=== MENU ADMIN SOAL RANDOM ===");
                            Console.WriteLine("1. Tambah Soal");
                            Console.WriteLine("2. Edit Soal");
                            Console.WriteLine("3. Hapus Soal");
                            Console.WriteLine("4. Tampilkan Soal Random");
                            Console.WriteLine("5. Kembali ke Menu Utama");
                            Console.Write("Pilih: ");
                            string? menuAdmin = Console.ReadLine();
                            switch (menuAdmin)
                            {
                                case "1":
                                    controllerManual.TambahSoalManual();
                                    break;
                                case "2":
                                    controllerManual.EditSoalManual();
                                    break;
                                case "3":
                                    controllerManual.HapusSoalManual();
                                    break;
                                case "4":
                                    controllerManual.TampilSoal();
                                    break;
                                case "5":
                                    goto EndAdminMenu;
                                default:
                                    Console.WriteLine("Pilihan tidak valid.");
                                    break;
                            }
                        }
                    EndAdminMenu:
                        break;

                    case "3":
                        return;
                }

                Console.WriteLine("\nTekan Enter untuk melanjutkan...");
                Console.ReadLine();
            }
        }
    }
}
