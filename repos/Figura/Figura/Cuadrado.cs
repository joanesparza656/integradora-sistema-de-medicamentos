using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    public class Cuadrado :Figura
    {
        
        
            public double Lado { get; set; }

            public Cuadrado(double lado)
            {
                Lado = lado;
            }

           
            public override double CalcularArea()
            {
                return Lado * Lado;
            }

          
            public override void MostrarInformacion()
            {
                Console.WriteLine($"es un Cuadrado con lado: {Lado}MI area es:{CalcularArea()}");
                
            }
        






    }
}
