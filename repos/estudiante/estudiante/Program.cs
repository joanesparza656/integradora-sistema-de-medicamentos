using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace estudiante
{
    internal class Program

    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            string grado;

        }
        public Estudiante(string nombre, int edad, string grado)
        {
            nombre = ("pablo");
            edad = ("edad");
            grado = "sexto";

        }
        public Estudiante(string nombre, int edad, string grado)
        {
            nombre = nombre;
            edad = edad;
            grado = grado;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Grado: " + grado);
        }
    }
}
