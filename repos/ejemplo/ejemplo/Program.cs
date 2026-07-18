namespace ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            empleado emp1 = new empleado("carlos");
            empleado emp2 = new empleado("ana");

            emp1.motrarInfo();
            emp2.motrarInfo();
        }
    }   


}
