using SoalAPI.Controller;
using static SoalAPI.Controller.SoalController;

namespace SoalAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var controller = new SoalController();

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
                await controller.AmbilSoalBerdasarkanKategori(kategoriDipilih);
                Console.WriteLine("Soal berhasil diambil!");

                Console.WriteLine("\n=== Soal untuk Dikerjakan ===");
                controller.TampilSemuaSoal();
            }
            else
            {
                Console.WriteLine("Input tidak valid.");
            }

            Console.WriteLine("Selesai. Tekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}
