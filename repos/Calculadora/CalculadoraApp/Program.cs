using System;

namespace CalculadoraApp
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Calculadora simple (suma, resta, multiplicación, división)");
            while (true)
            {
                try
                {
                    Console.Write("Operación (+ - * /) o 'salir': ");
                    var op = Console.ReadLine()?.Trim();
                    if (string.IsNullOrEmpty(op)) continue;
                    if (op.Equals("salir", StringComparison.OrdinalIgnoreCase)) break;

                    if (op is not "+" and not "-" and not "*" and not "/")
                    {
                        Console.WriteLine("Operación no válida.");
                        continue;
                    }

                    Console.Write("Primer número: ");
                    var aText = Console.ReadLine();
                    if (!double.TryParse(aText, out var a))
                    {
                        Console.WriteLine("Número no válido.");
                        continue;
                    }

                    Console.Write("Segundo número: ");
                    var bText = Console.ReadLine();
                    if (!double.TryParse(bText, out var b))
                    {
                        Console.WriteLine("Número no válido.");
                        continue;
                    }

                    double result = op switch
                    {
                        "+" => a + b,
                        "-" => a - b,
                        "*" => a * b,
                        "/" => b == 0 ? double.NaN : a / b,
                        _ => double.NaN
                    };

                    if (double.IsNaN(result))
                        Console.WriteLine("Resultado indefinido (por ejemplo, división por cero)." );
                    else
                        Console.WriteLine($"Resultado: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
