using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class triangulo
    {


        public double b;
        public double a;
        // constructor de la clase triangulo

        public triangulo(double basee, double altura)
        {
            b = basee;
            a = altura;
        }
        //metodo de calcular area 
        public double CalcularArea()
        {
            double resArea = (b * a) / 2;
            return resArea;
        }
    }   
}
