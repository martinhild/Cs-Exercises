/*
 * Fläche eines Rechtecks
 * Lese Breite und Höhe ein, berechne die Fläche und gib sie aus.
 */


internal static class A004_FlaecheEinesRechtecks
{
    public static void Run()
    {
        Console.Write("Länge:");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Breite:");
        double width = double.Parse(Console.ReadLine());
        double area = length * width;
        Console.WriteLine($"Fläche: {area}");
    }
}