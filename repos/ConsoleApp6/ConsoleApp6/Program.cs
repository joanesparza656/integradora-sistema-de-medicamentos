namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("**************************");
                Console.WriteLine("CALCULADORA DE TEMPERATURA,eligue bien una opcion:");
                Console.WriteLine("1.- convertir °F a °C");
                Console.WriteLine("2.- convertir °C a °F");
                Console.WriteLine("3.- salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("Teclea los grados farenheit a convertir a grados celcius");
                            double farenheit = Convert.ToDouble(Console.ReadLine());
                            double reCsel = conversion.conveCelcius(farenheit);
                            Console.WriteLine($"los grados celcius {farenheit}°F SON {reCsel}°C");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Teclea los grados celcius a convertir a grados farenheit");
                            double celcius = Convert.ToDouble(Console.ReadLine());
                            double reCsel = conversion.conveCelcius(celcius);
                            Console.WriteLine($"los grados celcius {celcius}°C SON {reCsel}°F");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("fin del programa");
                                break;
                        }

                }




            } while (opcion!=3);


        }

}   }
