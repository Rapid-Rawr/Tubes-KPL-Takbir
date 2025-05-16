using System;
using System.Collections.Generic;

public class Grader<T>
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
}
