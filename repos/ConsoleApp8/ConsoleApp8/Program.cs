namespace calculadora

{
    internal class Program
    {
        static void Main(string[] args)
        {



            {
                Console.WriteLine("Ingrese el primer número:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Seleccione la operación: + (suma), - (resta), * (multiplicación), / (división)");
                string operacion = Console.ReadLine();

                double resultado;

                switch (operacion)
                {
                    case "+":
                        resultado = num1 + num2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    case "-":
                        resultado = num1 - num2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    case "*":
                        resultado = num1 * num2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("Resultado: " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("Error: no se puede dividir entre cero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Operación no válida.");
                        break;
                }
            }
        }
 }   }
