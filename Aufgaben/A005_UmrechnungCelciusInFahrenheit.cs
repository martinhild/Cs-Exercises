/*
 * Umrechnung Celsius in Fahrenheit
 * Lese eine Temperatur in Celsius ein und rechne sie in Fahrenheit um (Formel: F = C * 1,8 + 32).
 */

internal static class A005_UmrechnungCelciusInFahrenheit
{
    public static void Run()
    {
        Console.Write("Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = celsius * 1.8 + 32;
        Console.WriteLine($"Fahrenheit: {fahrenheit}");
    }
}