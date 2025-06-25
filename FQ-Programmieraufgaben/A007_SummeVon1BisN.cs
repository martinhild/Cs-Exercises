using System;
namespace FQ_Programmieraufgaben.Exercises;

internal class A007_SummeVon1BisN
{
    public static void Run()
    {
        int n = GetPositiveInt();

        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Summe von 1 bis {n} = {sum}");
                 
    }


    /// <summary>
    /// Fordert den Benutzer zur Eingabe einer ganzen positiven Zahl auf.
    /// Wiederholt die Eingabeaufforderung, bis eine gültige Zahl eingegeben wird.
    /// </summary>
    /// <returns>
    /// Eine gültige ganze Zahl größer als 0.
    /// </returns>
    private static int GetPositiveInt()
    {
        int n = 0;
        while (true)
        {
            try
            {
                Console.Write("n: ");
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    continue;
                }

                if (n <= 0)
                {
                    Console.WriteLine("Must be > 0.");
                }
                else
                {
                    return n;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Must be integer.");
            }
        }
    }
}