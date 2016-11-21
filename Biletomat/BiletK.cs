using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biletomat
{
    class BiletK : Bilet//na bilety kolejowe
    {
        private double dlugoscTrasy;
        public override void ObliczCene(RodzajBiletu rodzaj)
        {
            double cenaN;
            if (dlugoscTrasy <= 100)
                cenaN = dlugoscTrasy * 1.04;
            else
                cenaN = dlugoscTrasy * 0.73;
            //Console.WriteLine("{0}", cena);
            if (rodzaj == RodzajBiletu.N)
                base.cena = cenaN;
            else
                base.cena = cenaN/2;
            Console.WriteLine(String.Format("{0:N2}", cena)); //0:N2 to dwa miejsca po przecinku
            
        }
        public BiletK(int dlugoscTrasy)
        {
            this.dlugoscTrasy = dlugoscTrasy;
        }
    }
}
