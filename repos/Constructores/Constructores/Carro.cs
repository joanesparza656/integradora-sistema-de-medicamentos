using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class Carro
    {
        private int ruedas;
        private double ancho;
        private double largo;
        private bool aire;
        private string tapiceria;

        public Carro()
        {
            ruedas = 4;
            ancho = 2000;
            largo = 4000;
            aire = false;
            tapiceria = "tela";

        }
        public Carro(double _ancho, double _largo)
        {
            ruedas = 4;
            ancho = _ancho;
            largo = _largo;
            aire = false;
            tapiceria = "tela";

        }
        public Carro(int _ruedas)
        {
            ruedas = _ruedas;
            ancho = 2000;
            largo = 4000;
            aire = false;
            tapiceria = "tela";


        }
        public void setExrtacoche(bool _climatizador, string _tapiceria)
        {
            aire = _climatizador;
            tapiceria = _tapiceria;

        }
        public string getInfocarro()
        {
            return ($"la informacion del coche es: ruedas{ruedas},ancho{ancho},largo {largo}");
        }
        public string getExtracoche()
        {
            return $"adicionales del coche: climatizador{aire }" +
                $"adicionales delcoche es: ruedas:{ruedas}"
        }






    }
}
