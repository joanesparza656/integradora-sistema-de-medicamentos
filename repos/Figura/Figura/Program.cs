namespace Figura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo1 = new Circulo(7.3);
            circulo1.MostrarInformacion();
            Figura figura1 = new Figura();
            figura1.MostrarInformacion();
            Cuadrado cuadrado1=new Cuadrado(8.9);
            cuadrado1.MostrarInformacion();



        }
    }
}
