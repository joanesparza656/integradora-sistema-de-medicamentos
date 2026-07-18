using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class producto
    {

        public int codigos;
        public int cCodigos;
        public string Nombre;
        public double Precio;
        public producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
            codigos = GenerarCodigo();


        }
        public int GenerarCodigo()
        {
            codigos++;
            return codigos;


        }
        public void Detalles_producto()
        {
            Console.WriteLine($"producto: {Nombre},codigo:{codigos},precio${Precio}");
        }






    }
}
