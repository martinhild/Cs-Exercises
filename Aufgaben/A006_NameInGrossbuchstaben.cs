/*
 * Name in Groﬂbuchstaben
 * Lese einen Namen ein und gib ihn vollst‰ndig in Groﬂbuchstaben zur¸ck.
 */

namespace FQ_Programmieraufgaben.Aufgaben;
using System;

internal static class A006_NameInGrossbuchstaben
{
    public static void Run()
    {                
        string name;
        while (true)
        {
            Console.Write("Name: ");
            name = Console.ReadLine();

            if (name != null)
            {                
                name = name.Trim();
                if (name.Length == 0)
                {
                    Console.WriteLine("leere Eingabe...");
                }
                else
                {
                    name = name.ToUpper();
                    break;
                }
            }     
        }        
        Console.WriteLine($"Groﬂgeschrieben: {name}");
    }
}

