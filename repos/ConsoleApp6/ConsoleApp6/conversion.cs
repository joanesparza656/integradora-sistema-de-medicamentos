using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class conversion
    {
        public static double conveCelcius(double pfarenheit)
        {
            double celsius = (pfarenheit - 32) / 1.8;
            return celsius;
        }
        public static double conveFarenheit(double pCelcius)
        {
            double farenheit = (pCelcius * 32) / 1.8;
            return farenheit;
        }
    }
}
