/*
 * Min, Max, Durchschnitt
 * Lese mehrere Zahlen ein (z. B. 5 St�ck) und bestimme den kleinsten, den gr��ten Wert sowie den Durchschnitt.
 */

using System.ComponentModel;

namespace FQ_Programmieraufgaben.Exercises;

internal class A012_MinMaxDurchschnitt
{
    public static void Run()
    {
        List<double> numbers = GetNumbers();
        if (numbers.Count > 0)
        {
            double min = numbers.Min();
            double max = numbers.Max();
            double average = numbers.Average();
            Console.WriteLine($"Minimum: {min}, Maximum: {max}, Durchschnitt: {average}");
        }        
    }

    private static List<double> GetNumbers()
    {
        List<double> numbers = new List<double>();
        int i = 1;
        Console.WriteLine("Lese mehrere Zahlen ein (z. B. 5 St�ck). Leere Eingabe zum Beenden.");
        while (true)
        {
            Console.Write($"Zahl {i}: ");
            i++;
            string? userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
            {
                break;
            }
            if (double.TryParse(userInput, out double number) )
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Enter a number.");
                i--;
            }
        }
        return numbers;
    }
}