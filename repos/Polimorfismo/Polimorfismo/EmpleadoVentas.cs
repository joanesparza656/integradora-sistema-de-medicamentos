using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public  class EmpleadoVentas : Empleado
    {
        private decimal BonoVenta;

        public EmpleadoVentas(string pnombre, decimal psueldo,decimal pBonoVenta )
            :base (pnombre, psueldo)
        {
            BonoVenta = pBonoVenta;
        }
        public override decimal CalculaPago()
        {
            sueldo = sueldo + BonoVenta;
            return base.CalculaPago();
        }
        public override string ToString()
        {
            StringBuilder emp = new StringBuilder();
            emp.AppendFormat($"nombre: {nombre} sueldo: {CalculaPago()}");
            return emp.ToString();
        }



    }
}
