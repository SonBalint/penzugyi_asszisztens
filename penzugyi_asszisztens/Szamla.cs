using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penzugyi_asszisztens
{
    public class Szamla
    {
        public string SzamlaNev { get; private set; }
        private List<Kiadas> kiadasok = new List<Kiadas>();
        private List<Bevetel> bevetelek = new List<Bevetel>();
        public double KezdoEgyenleg { get; private set; }

        public IEnumerable<Kiadas> Kiadasok => kiadasok;
        public IEnumerable<Bevetel> Bevetelek => bevetelek;

        public Szamla(string nev, double kezdoEgyenleg = 0)
        {
            SzamlaNev = nev;
            KezdoEgyenleg = kezdoEgyenleg;
        }

        public void AddKiadas(double osszeg, string leiras, DateTime datum)
        {
            kiadasok.Add(new Kiadas(osszeg, leiras, datum));
            KoltsegKezelo.AdatokMentese();
        }

        public void AddKiadasMentesNelkul(double osszeg, string leiras, DateTime datum)
        {
            kiadasok.Add(new Kiadas(osszeg, leiras, datum));
        }

        public void AddBevetel(double osszeg, string leiras, DateTime datum)
        {
            bevetelek.Add(new Bevetel(osszeg, leiras, datum));
            KoltsegKezelo.AdatokMentese();
        }

        public void AddBevetelMentesNelkul(double osszeg, string leiras, DateTime datum)
        {
            bevetelek.Add(new Bevetel(osszeg, leiras, datum));
        }

        public double CalculateBalance()
        {
            double kiadasokOsszege = kiadasok.Sum(k => k.Osszeg);
            double bevetelekOsszege = bevetelek.Sum(b => b.Osszeg);
            return KezdoEgyenleg + bevetelekOsszege - kiadasokOsszege;
        }

        public bool RemoveKiadas(int index)
        {
            if (index >= 0 && index < kiadasok.Count)
            {
                kiadasok.RemoveAt(index);
                KoltsegKezelo.AdatokMentese();
                return true;
            }
            return false;
        }

        public bool RemoveBevetel(int index)
        {
            if (index >= 0 && index < bevetelek.Count)
            {
                bevetelek.RemoveAt(index);
                KoltsegKezelo.AdatokMentese();
                return true;
            }
            return false;
        }

        public void ListazTranzakciok()
        {
            Console.WriteLine($"Tranzakciók a(z) '{SzamlaNev}' számlán:");
            int kiadasSorszam = 0;
            int bevetelSorszam = 0;
            foreach (var kiadas in kiadasok)
            {
                Console.WriteLine($"Kiadás [{kiadasSorszam}] - Összeg: {kiadas.Osszeg}, Leírás: {kiadas.Leiras}, Dátum: {kiadas.Datum.ToShortDateString()}");
                kiadasSorszam++;
            }
            foreach (var bevetel in bevetelek)
            {
                Console.WriteLine($"Bevétel [{bevetelSorszam}] - Összeg: {bevetel.Osszeg}, Leírás: {bevetel.Leiras}, Dátum: {bevetel.Datum.ToShortDateString()}");
                bevetelSorszam++;
            }
        }
    }
}
