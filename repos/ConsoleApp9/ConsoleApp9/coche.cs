using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class coche
    {

        public int ruedas;
        public double ancho;
        public double largo;
        public bool aire;
        public string tapiceria;
       public coche(int _ruedas,double _ancho,double _largo, bool _aire, string _tapiceria )

        {

            ruedas = _ruedas;
            ancho = _ancho; 
            largo = _largo;
            aire = _aire;
            tapiceria = _tapiceria;




        }
        public string getInfocoche()
        {
            return $"la informacion de coche Ruedas:{ruedas}ancho:{ancho},largo{largo}aire:{aire}tapiceria{tapiceria}";


        }
        


    }
}
