using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
     public class Figura
    {
        public virtual double CalcularArea()
        {
            return 0;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Esta es una figura genérica.");
        }

    }
}
