using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biletomat
{
    class BiletA:Bilet //na bilety autobusowe miejskie
    {

       // public BiletA(RodzajBiletu rodzajBiletu)
       // {
            // TODO: Complete member initialization
          //  this.rodzajBiletu = rodzajBiletu;
       // }
        
        public override void ObliczCene(RodzajBiletu rodzaj) //przypisuje cene w BiletA
        {
            if (rodzaj==RodzajBiletu.N)
                base.cena=2.90;
            else 
                base.cena=1.45;
            Console.WriteLine(String.Format("{0:N2}", cena)); //0:N2 to dwa miejsca po przecinku
        }
    }
}
