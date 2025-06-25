/*
 * Benutzereingabe und Ausgabe
 * Lese einen Text von der Konsole ein und gebe ihn anschlieﬂend wieder aus
 */

namespace FQ_Programmieraufgaben.Exercises
{
    internal static class A002_BenutzereingabeUndAusgabe
    {
        public static void Run()
        {
            Console.Write("Eingabe: ");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);
        }
    }
}
