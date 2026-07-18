using System;
using System.Collections.Generic;
using a;

namespace ProyectoClientes
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteControlador controlador = new ClienteControlador();
            List<Cliente> clientes = controlador.ListarClientes();

            Console.WriteLine("Listado de Clientes:");
            foreach (var c in clientes)
            {
                Console.WriteLine($"ID: {c.Id}, Nombre: {c.Nombre}, Teléfono: {c.Telefono}");
            }

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
