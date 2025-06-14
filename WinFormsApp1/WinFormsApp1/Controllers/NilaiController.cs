using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
using WinFormsApp1.Utilities;

namespace WinFormsApp1.Controllers
{
    class NilaiController
    {
        public int menilai(int totalSoal, int soalBenar)
        {
            //ini nanti nerima paramaeter total soal sama jawaban benar

            int nilaiSatuan = 100 / totalSoal;

            return nilaiSatuan*soalBenar;
            return nilaiSatuan * soalBenar;
        }

        // Method untuk dapatkan data leaderboard dari file JSON
        public List<LeaderBoard> GetLeaderBoardFromFile(string filePath)
        {
            // Baca data JSON dan deserialisasi ke list QuizResult
            List<QuizResult>? quizResults = JsonHelper.LoadFromFile<List<QuizResult>>(filePath);

            // Jika data null atau tidak ada, buat list kosong supaya tidak error
            if (quizResults == null)
            {
                quizResults = new List<QuizResult>();
            }

            // Proses data menjadi leaderboard yang sudah dijumlahkan dan diurutkan
            return GetLeaderBoard(quizResults);
        }

        // Method pengolahan leaderboard (versi sederhana)
        private List<LeaderBoard> GetLeaderBoard(List<QuizResult> quizResults)
        {
            Dictionary<string, LeaderBoard> leaderboardDict = new Dictionary<string, LeaderBoard>();

            foreach (var result in quizResults)
            {
                if (leaderboardDict.ContainsKey(result.Username))
                {
                    leaderboardDict[result.Username].TotalSoalBenar += result.SoalBenar;
                    leaderboardDict[result.Username].TotalSoal += result.TotalSoal;
                }
                else
                {
                    leaderboardDict[result.Username] = new LeaderBoard
                    {
                        Username = result.Username,
                        TotalSoalBenar = result.SoalBenar,
                        TotalSoal = result.TotalSoal
                    };
                }
            }

            var leaderboardList = new List<LeaderBoard>(leaderboardDict.Values);
            leaderboardList.Sort((a, b) => b.TotalSoalBenar.CompareTo(a.TotalSoalBenar));

            return leaderboardList;
        }
    }
}
