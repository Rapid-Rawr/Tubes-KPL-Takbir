using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
using WinFormsApp1.Utilities;

namespace WinFormsApp1.Controllers
{
    public class NilaiController
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hasil.json");

        public int menilai(int totalSoal, int soalBenar)
        {
            //ini nanti nerima paramaeter total soal sama jawaban benar

            int nilaiSatuan = 100 / totalSoal;

            return nilaiSatuan * soalBenar;
        }



       
        public List<HasilPengerjaan> GetLeaderBoardFromFile()
        { 
            if (!File.Exists(filePath))
                return new List<HasilPengerjaan>();

            var json = File.ReadAllText(filePath);
            var allResults = JsonConvert.DeserializeObject<List<HasilPengerjaan>>(json);

            // Akumulasi skor totalBenar dan totalSoal untuk setiap user
            var highestPerUser = allResults
                .GroupBy(h => h.Username)
                .Select(g => new HasilPengerjaan
                {
                    Username = g.Key,
                    TotalBenar = g.Sum(x => x.TotalBenar)*20,
                    TotalSoal = g.Sum(x => x.TotalSoal)
                })
                .OrderByDescending(h => h.TotalBenar)
                .ToList();

            return highestPerUser;
        }

        public void SimpanHasil(HasilPengerjaan hasil)
        {
            string filePath = "hasil.json"; 

            List<HasilPengerjaan> semuaHasil = JsonHelper.LoadFromFile<List<HasilPengerjaan>>(filePath) ?? new List<HasilPengerjaan>();

            hasil.Id = semuaHasil.Count > 0 ? semuaHasil.Max(h => h.Id) + 1 : 1;

            semuaHasil.Add(hasil);

            JsonHelper.SaveToFile(filePath, semuaHasil);
        }

        public (List<HasilPengerjaan> allData, int totalNilai) GetAllHistory()
        {
            var allData = JsonHelper.LoadFromFile<List<HasilPengerjaan>>(filePath) ?? new List<HasilPengerjaan>();

            int totalNilai = allData.Sum(x => x.TotalBenar) * 20;

            return (allData, totalNilai);
        }

        public (List<HasilPengerjaan> history, int totalNilai) GetUserHistory(string username)
        {
            var allData = JsonHelper.LoadFromFile<List<HasilPengerjaan>>(filePath) ?? new List<HasilPengerjaan>();

            var userData = allData.Where(x => x.Username == username).ToList();
            int totalNilai = userData.Sum(x => x.TotalBenar) * 20;

            return (userData, totalNilai);
        }

    }
}
