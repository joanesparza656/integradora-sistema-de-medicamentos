using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Agenda
    {
        public string nombre;
        public string telefono;
        public int edad;

        public Agenda(string pnombre, string ptelefono, int pedad)
        {
            nombre = pnombre;
            telefono = ptelefono;
            edad = pedad;
        }

        public override string ToString()
        {
          StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre:{nombre},telefono: {telefono},Edad: {edad}");
            return sb.ToString();

        }










        




    }

        






        
}
