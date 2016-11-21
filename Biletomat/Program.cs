using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biletomat
{
    enum RodzajBiletu { N, U }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RodzajBiletu.N);
            BiletA bileta1 = new BiletA();
            bileta1.ObliczCene(RodzajBiletu.N);
            bileta1.ObliczCene(RodzajBiletu.U);
            Console.WriteLine("");
            BiletK biletk1 = new BiletK(50);
            biletk1.ObliczCene(RodzajBiletu.N);
            biletk1.ObliczCene(RodzajBiletu.U);
            Console.WriteLine("");
            BiletK biletk2 = new BiletK(120);
            biletk2.ObliczCene(RodzajBiletu.N);
            biletk2.ObliczCene(RodzajBiletu.U);
            
            
            Console.ReadKey();

        }
    }
}
