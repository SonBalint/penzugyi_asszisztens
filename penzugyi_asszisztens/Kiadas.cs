using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penzugyi_asszisztens
{
    public class Kiadas
    {
        public double Osszeg { get; set; }
        public string Leiras { get; set; }
        public DateTime Datum { get; set; }

        public Kiadas(double osszeg, string leiras, DateTime datum)
        {
            Osszeg = osszeg;
            Leiras = leiras;
            Datum = datum;
        }
    }
}
