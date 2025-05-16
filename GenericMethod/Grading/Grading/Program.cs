using System;

class Program
{
    static void Main()
    {
        try
        {

            int correct = int.Parse("7");

            int total = int.Parse("10");

            var grader = new Grader<int>();
            Console.WriteLine(grader.Calculate(correct, total));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
