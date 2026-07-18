using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoShapes
{
    public class Shapes
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        protected int Height { get; set; }
        protected int Width { get; set; }




    
       public virtual void Dibujar()
        {

            Console.WriteLine("realizando dibujo de clase base");


        }


    }   
}
