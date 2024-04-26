using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penzugyi_asszisztens
{
    public class Bevetel
    {
        public double Osszeg { get; set; }
        public string Leiras { get; set; }
        public DateTime Datum { get; set; }

        public Bevetel(double osszeg, string leiras, DateTime datum)
        {
            Osszeg = osszeg;
            Leiras = leiras;
            Datum = datum;
        }
    }
}
