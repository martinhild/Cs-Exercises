/*
 * Einfache Rechenaufgabe
 * Lese zwei Zahlen ein, addiere sie und gib das Ergebnis aus.
 */

namespace FQ_Programmieraufgaben.Exercises;

internal static class A003_EinfacheRechenaufgabe
{
    public static void Run()
    {
        Console.Write("Zahl 1: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Uahl 2: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Summe: {num1 + num2}");
    }
}