using System;

public class Calculadora
{
    public int Sumar(int a, int b) => a + b;
    public int Restar(int a, int b) => a - b;
    public int Multiplicar(int a, int b) => a * b;
    public int Dividir(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException("División por cero.");
        return a / b;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var calc = new Calculadora();

        while (true)
        {
            Console.WriteLine("Calculadora - elige una opción:");
            Console.WriteLine("1) Sumar");
            Console.WriteLine("2) Restar");
            Console.WriteLine("3) Multiplicar");
            Console.WriteLine("4) Dividir");
            Console.WriteLine("0) Salir");
            Console.Write("Opción: ");
            var opt = Console.ReadLine();
            if (opt == "0") break;
            if (!int.TryParse(opt, out int opcion) || opcion < 0 || opcion > 4)
            {
                Console.WriteLine("Opción no válida.\n");
                continue;
            }

            Console.Write("Primer número: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Número no válido.\n");
                continue;
            }

            Console.Write("Segundo número: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Número no válido.\n");
                continue;
            }

            try
            {
                int resultado = opcion switch
                {
                    1 => calc.Sumar(a, b),
                    2 => calc.Restar(a, b),
                    3 => calc.Multiplicar(a, b),                
                    4 => calc.Dividir(a, b),
                    _ => 0
                };

                Console.WriteLine($"Resultado: {resultado}\n");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: División por cero.\n");
            }
        }
    }
}

