/*
 * Fl�che eines Rechtecks
 * Lese Breite und H�he ein, berechne die Fl�che und gib sie aus.
 */


internal static class A004_FlaecheEinesRechtecks
{
    public static void Run()
    {
        Console.Write("L�nge:");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Breite:");
        double width = double.Parse(Console.ReadLine());
        double area = length * width;
        Console.WriteLine($"Fl�che: {area}");
    }
}