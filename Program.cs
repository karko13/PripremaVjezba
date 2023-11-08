using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrpremaVjezba
{
    internal class Program
    {
        static void Main(string[] args)
        {
        double a = 2; 
        double b = 3; 
        double c = 4; 
        double d = 5;
        double rez = 0;
            rez = ((Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) + Math.Pow(d, 2)) % (Math.Pow(a + b, 2) + Math.Pow(c + d, 2)));
         Console.WriteLine("Rezultat je " + rez);
            Console.ReadKey();
        }
    }
}
