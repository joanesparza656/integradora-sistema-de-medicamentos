namespace ModificadoresAcceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cual es tu nombre?");
            string nom = Console.ReadLine();
            Console.WriteLine("cual es tu apellido?");
            string ape = Console.ReadLine();    

            Persona persona1 = new Persona (nom,ape);
            Console.WriteLine($"El nombre de la persona es:{persona1.Nombre},el apellido es:{persona1.Apellido}");



        }
    }
}
