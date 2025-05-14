using System;

public enum FlowState { Start, SebelumMulai, Mulai, Finish }

public class Alur
{
    private FlowState current = FlowState.Start;

    public static void Main()
    {
        var alur = new Alur();

        Console.WriteLine("pres to enter");
        Console.ReadLine();
        alur.current = FlowState.SebelumMulai;

        //Console.WriteLine($"State : {alur.current}");

        while (alur.current != FlowState.Finish)
        {

            Console.WriteLine("ketik start untuk mulai atau finish untuk mengakhiri");
            string command = Console.ReadLine().ToLower();


            switch (command)
            {
                case "start":
                    if (alur.current == FlowState.SebelumMulai)
                    {
                        Console.WriteLine("ini sudah mulai pengerjaan");
                        alur.current = FlowState.Mulai;
                        //todo, memanggil kode pengerjaan
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" pastikan urutan benar.");
                    }
                    break;

                case "finish":
                    if (alur.current == FlowState.Mulai)
                    {
                        alur.current = FlowState.Finish;
                        Console.WriteLine($"Terima kasih, State : {alur.current}");
                    }
                    //else
                    //{
                    //    Console.WriteLine("Tidak bisa selesai, pastikan urutan benar.");
                    //}
                    break;

                default:
                    Console.WriteLine("Hanya gunakan start/finish");
                    break;
            }
        }

        Console.WriteLine("Program selesai.");
    }
}
