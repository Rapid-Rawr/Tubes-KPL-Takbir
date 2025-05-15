using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


public class Soal
{
    public string pertanyaan { get; set; }
    public List<string> opsi { get; set; }
    public string jawaban { get; set; }
}

class Program
{
    static void Main()
    {
        string jsonFile = "soal.json";

        if (!File.Exists(jsonFile))
        {
            Console.WriteLine("File soal.json tidak ditemukan.");
            return;
        }

        var soalList = JsonConvert.DeserializeObject<List<Soal>>(File.ReadAllText(jsonFile));

        if (soalList == null || soalList.Count == 0)
        {
            Console.WriteLine("Tidak ada soal yang tersedia.");
            return;
        }

        int index = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Soal {index + 1}: {soalList[index].pertanyaan}");
            for (int i = 0; i < soalList[index].opsi.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {soalList[index].opsi[i]}");
            }

            Console.WriteLine("\nKetik 'next' untuk soal berikutnya atau 'exit' untuk keluar.");
            string command = Console.ReadLine()?.ToLower();

            if (command == "exit")
                break;

            index = (index + 1) % soalList.Count; 
        }

        Console.WriteLine("Program selesai.");
    }
}