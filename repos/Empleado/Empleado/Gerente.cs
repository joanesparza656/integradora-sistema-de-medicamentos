using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public  class Gerente : Empleado
    {


        public string Departamento { get; set; }

            
            public Gerente(string nombre, double salario, string departamento) : base(nombre, salario)
            {
                Departamento = departamento;
            }

            
            public override void MostrarInformacion()
            {
                
                Console.WriteLine($"Departamento: {Departamento}");
                
            }
        










    }
}
