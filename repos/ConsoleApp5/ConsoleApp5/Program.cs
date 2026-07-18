using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args) {
            
            
            Agenda amigo1 = new Agenda("luis perez", "+63 900 222 3345",12);
            Agenda amigo2 = new Agenda("JUAN", "+52 6442 036455", 16);
            Console.WriteLine(amigo1.ToString());
            Console.WriteLine(amigo2.ToString());



            Console.ReadLine();
        }

        


    }
}
