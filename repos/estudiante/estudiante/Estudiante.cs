using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudiante
{
    internal class Estudiante
    {
        // Usando el constructor sin parámetros
        Estudiante estudiante1 = new Estudiante();
        Console.WriteLine("Estudiante 1:");
        estudiante1.MostrarInformacion();

        Console.WriteLine();

        // Usando el constructor con parámetros
        Estudiante estudiante2 = new Estudiante("Ana López", 17, "11°");
        Console.WriteLine("Estudiante 2:");
        estudiante2.MostrarInformacion();

    }
}
