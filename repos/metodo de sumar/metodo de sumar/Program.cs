using System.Diagnostics;

namespace metodo_de_sumar
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("la suma es:");
            Console.WriteLine(calculadora.sumar(2, 4));
            Console.WriteLine("la resta es:");
            Console.WriteLine(calculadora.restar(2, 4));
            Console.ReadKey();
        }

       


    }
}
