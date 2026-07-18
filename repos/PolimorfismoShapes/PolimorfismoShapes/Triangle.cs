using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoShapes
{
    public  class Triangle : Shapes
    {
        public override void Dibujar()
        {
            Console.WriteLine("dibujando a trinagle ");
            base.Dibujar();
        } 



    }
}
