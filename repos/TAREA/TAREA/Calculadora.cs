using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA
{
    public class Calculadora
    {
        
        
            public double Numero1 { get; set; }
            public double Numero2 { get; set; }

            public Calculadora(double numero1, double numero2)
            {
                Numero1 = numero1;
                Numero2 = numero2;
            }

            public double Sumar() => Numero1 + Numero2;
            public double Restar() => Numero1 - Numero2;
            public double Multiplicar() => Numero1 * Numero2;

            public double Dividir()
            {
                if (Numero2 == 0)
                    throw new DivideByZeroException("No se puede dividir entre cero.");
                return Numero1 / Numero2;
            }
        }
}
