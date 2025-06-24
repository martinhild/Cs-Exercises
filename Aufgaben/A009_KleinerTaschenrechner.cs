/*
 * Kleiner Taschenrechner
 * Lese zwei Zahlen und ein Rechenzeichen (+, -, *, /) ein und führe die entsprechende Operation aus.
 */

using System;
namespace FQ_Programmieraufgaben.Aufgaben;

internal class A009_KleinerTaschenrechner
{
    public static void Run()
    {
        (double n1, double n2) = GetTwoNumbers();        
        char arithmeticOperator = GetArithmeticOperator();
        double result = 0;

        switch (arithmeticOperator)
        {
            case '+':
                result = n1 + n2;
                break;
            case '-':
                result = n1 - n2;
                break;
            case '*':
                result = n1 * n2;
                break;
            case '/':
                if (n2 == 0)
                {
                    Console.WriteLine("Can't divide by 0.");
                    return;                
                }
                result = n1 / n2;
                break;
        }
        Console.WriteLine($"{n1} {arithmeticOperator} {n2} = {result}");
      
    }

 

    private static (double, double) GetTwoNumbers()
    {
        double n1 = 0;
        double n2 = 0;
        while (true)
        {            
            try
            {
                Console.Write("Enter two numbers: ");
                string? input = Console.ReadLine();
                string[] numbers = input.Split();
                if (numbers.Length == 2)
                {
                    n1 = double.Parse(numbers[0]);
                    n2 = double.Parse(numbers[1]);
                    return (n1, n2);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Need two number.");
            }
        }
        
    }

    private static char GetArithmeticOperator()
    {
        string userInput = "";
        while (true)
        {
            Console.Write("Operator (+,-,*,/): ");            
            userInput = Console.ReadLine();
            
            if (userInput.Length == 1 && "+-*/".Contains(userInput))
            {
                return userInput[0];
            }
        }
    }

}