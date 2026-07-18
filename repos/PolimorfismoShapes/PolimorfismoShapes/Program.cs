namespace PolimorfismoShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            Rectangle rectangle1 = new Rectangle();
            Triangle triangle1 = new Triangle();
            Rombo rombo1 = new Rombo();


            circle1.Dibujar();
            triangle1.Dibujar();
             rectangle1.Dibujar();
            rombo1.Dibujar();
        }
        
    }
}
