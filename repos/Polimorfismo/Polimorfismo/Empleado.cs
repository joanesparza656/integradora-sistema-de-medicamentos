using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public  class Empleado
    {
        protected string nombre;
        protected decimal sueldo;
        public Empleado (string pnombre, decimal psueldo)
        {
            nombre = pnombre;
            sueldo = psueldo;
        }
        public string Nombre { get; set; }
        public decimal Sueldo { get; set; }

        public virtual decimal CalculaPago()
        {
            return sueldo;
        }
        public override string ToString()
        {
                StringBuilder emp = new StringBuilder();
            emp.AppendFormat($"Nombre:{nombre}, sueldo:{sueldo}");
            return emp.ToString();
        }




    }
}
