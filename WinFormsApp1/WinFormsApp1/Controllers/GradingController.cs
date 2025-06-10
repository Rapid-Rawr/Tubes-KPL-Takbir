using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Kuislami.Models; // Pastikan namespace-nya sesuai

public class GradingController<T>
{
    private Dictionary<double, string> gradeTable = new()
    {
        { 85, "A" },
        { 65, "C" },
        { 60, "D" },
        { 0, "E" }
    };

    public string Calculate(T correctAnswers, T totalQuestions)
    {
        double correct = Convert.ToDouble(correctAnswers);
        double total = Convert.ToDouble(totalQuestions);

        if (total == 0)
            throw new InvalidOperationException("Total soal tidak boleh 0.");

        double percentage = (correct / total) * 100;

        if (percentage < 0 || percentage > 100)
            throw new InvalidOperationException("Nilai persentase tidak valid.");

        foreach (var grade in gradeTable)
        {
            if (percentage >= grade.Key)
                return $"Nilai: {percentage}%, Grade: {grade.Value}";
        }

        return "Nilai tidak valid.";
    }
    public string CalculateFromHistoryByUsername(string username, string path = "history.json")
    {
        if (!File.Exists(path))
            return "Belum ada file history.";

        string json = File.ReadAllText(path);
        var histories = JsonSerializer.Deserialize<List<QuizHistory>>(json);

        if (histories == null || histories.Count == 0)
            return "Belum ada data skor.";

        var userHistory = histories
            .Where(h => h.Username.Equals(username, StringComparison.OrdinalIgnoreCase))
            .LastOrDefault();

        if (userHistory == null)
            return $"Tidak ditemukan history untuk user '{username}'.";

        T totalBenar = (T)Convert.ChangeType(userHistory.TotalBenar, typeof(T))!;
        T totalSoal = (T)Convert.ChangeType(userHistory.TotalSoal, typeof(T))!;

        return Calculate(totalBenar, totalSoal);
    }

}
