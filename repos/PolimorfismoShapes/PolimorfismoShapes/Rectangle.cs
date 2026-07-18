using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoShapes
{
    internal class Rectangle : Shapes
    {
        public override void Dibujar()
        {
            Console.WriteLine("dibujando a rectangle");
            base.Dibujar();
        }


    }
}
