namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new EmpleadoVentas("Alice ", 500,1000);
            Empleado empleado2 = new Empleado("bob", 1200);
            Console.WriteLine(empleado1.ToString());
            Console.WriteLine(empleado2.ToString());



        }
    }
}
