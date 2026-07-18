Console.WriteLine("Hello, World!");
//encapsulamiento
public class  CuentaBancaria
{
    private double Saldo;
    public void depositar(double cantidad)
    {
        Saldo += cantidad;

    }
    public void Mostrarsaldo()
    {
        Console.WriteLine("El saldo es: " + Saldo);

    }
    public class program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria();
            cuenta.depositar(100);
            cuenta.depositar(50);
            cuenta.Mostrarsaldo();

        }
    }

}
//herencia
// polimorfismo