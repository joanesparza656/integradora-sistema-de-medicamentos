namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("********CALCULA EL AREA DE UN TRIANGULO¨**********");
                Console.WriteLine("1.-calcular area:");
                Console.WriteLine("2.-salir del programa:");
                Console.WriteLine("Teclea una opcion:");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("dame la base");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("dame la altura");
                        double a = Convert.ToDouble(Console.ReadLine());
                        triangulo triangulo1 = new triangulo(b, a);
                        double area = triangulo1.CalcularArea();
                        Console.WriteLine($"El resultado es:{area}");
                        break;
                    default: Console.WriteLine(""); break;
                }


            } while (opcion == 1);











            }


        }
    }

