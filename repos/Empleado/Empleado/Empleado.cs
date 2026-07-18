using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class Empleado
    {



        protected string Nombre { get; set; }
        protected double Salario { get; set; }


        public Empleado(String nombre, double salario)
        {
            Nombre = nombre;
            Salario = salario;
        }


        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Información del Empleado ");
            Console.WriteLine($"Nombre: {Nombre} salario {Salario}:");

        }
    }





    
}
