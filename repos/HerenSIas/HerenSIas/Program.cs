namespace HerenSIas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MutanteHumano mutante1=new MutanteHumano();
            Humano humano1 = new Humano();

            mutante1.Alias = "Wolverine";
            Console.WriteLine($"El alias del mutante es: {mutante1.Alias}");
            mutante1.Nombre = "logan";
            Console.WriteLine($"El nombre del mutante :{mutante1.Nombre}");
            humano1.Nombre = "tormenta";
            Console.WriteLine($"El nombre del humano :{humano1.Nombre}");
        }
    }
}
