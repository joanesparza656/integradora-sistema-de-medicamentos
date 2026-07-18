using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
    internal class empleado
    {
        private static int contadorIds = 0;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public empleado(string nombre)
        {
            Id = GenerarId();
            Nombre = nombre;
        }
        private static int GenerarId()
        {
            contadorIds++;
            return contadorIds;
        }
        public void motrarInfo()
        {
            Console.WriteLine($"empleado: {Nombre}, ID: {Id}");
        }

    }
}
