namespace Empleado
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Empleado empleado1 = new Empleado("joan Esparza",50000);
            empleado1.MostrarInformacion();
            Gerente gerente1 = new Gerente("maria ", 850000,"VENTAS");
            gerente1.MostrarInformacion();
           







        }
    }
}
