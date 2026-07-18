using System;


class Persona
{
    public string Nombre;
    public void Saludar()
    {
        Console.WriteLine($"Hola, soy {Nombre}");
    }
}

class Estudiante : Persona
{
    public string Carrera;
    public void MostrarInformacion()
    {
        Console.WriteLine($"Hola, soy {Nombre} y estudio {Carrera}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nombre: ");
        var nombre = Console.ReadLine();

        Console.Write("Carrera: ");
        var carrera = Console.ReadLine();

        var alumno = new Estudiante { Nombre = nombre, Carrera = carrera };

        Console.WriteLine();
        alumno.MostrarInformacion();

        Console.WriteLine("\nPresiona ENTER para salir...");
        Console.ReadLine();
    }
}