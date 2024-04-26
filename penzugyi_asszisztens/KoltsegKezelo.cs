using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace penzugyi_asszisztens
{
    public class KoltsegKezelo
    {
        private static Dictionary<string, Szamla> szamlak = new Dictionary<string, Szamla>();
        private const string adatFajl = "penzugyek.txt";

        public KoltsegKezelo()
        {
            AdatokBetoltese();
        }

        public void SzamlaHozzaadas(string szamlaNev, double kezdoEgyenleg)
        {
            if (!szamlak.ContainsKey(szamlaNev))
            {
                szamlak[szamlaNev] = new Szamla(szamlaNev, kezdoEgyenleg);
                AdatokMentese();
            }
        }

        public Szamla GetSzamla(string szamlaNev)
        {
            szamlak.TryGetValue(szamlaNev, out Szamla szamla);
            return szamla;
        }

        public void SzamlaEltavolitas(string szamlaNev)
        {
            if (szamlak.ContainsKey(szamlaNev))
            {
                szamlak.Remove(szamlaNev);
                AdatokMentese();
            }
        }

        public static void AdatokMentese()
        {
            StreamWriter writer = new StreamWriter(adatFajl);
            foreach (var szamla in szamlak.Values)
            {
                writer.WriteLine($"Szamla,{szamla.SzamlaNev},{szamla.KezdoEgyenleg}");
                foreach (var kiadas in szamla.Kiadasok)
                {
                    writer.WriteLine($"Kiadás,{kiadas.Osszeg},{kiadas.Leiras},{kiadas.Datum.ToString("o", CultureInfo.InvariantCulture)}");
                }
                foreach (var bevetel in szamla.Bevetelek)
                {
                    writer.WriteLine($"Bevétel,{bevetel.Osszeg},{bevetel.Leiras},{bevetel.Datum.ToString("o", CultureInfo.InvariantCulture)}");
                }
            }
            writer.Close();
        }

        private void AdatokBetoltese()
        {
            if (File.Exists(adatFajl))
            {
                StreamReader reader = new StreamReader(adatFajl);
                Szamla aktSzamla = null;
                string sor;
                while ((sor = reader.ReadLine()) != null)
                {
                    var adatok = sor.Split(',');
                    if (adatok[0] == "Szamla")
                    {
                        aktSzamla = new Szamla(adatok[1], Convert.ToDouble(adatok[2]));
                        szamlak.Add(adatok[1], aktSzamla);
                    }
                    else if (adatok[0] == "Kiadás" && aktSzamla != null)
                    {
                        aktSzamla.AddKiadas(Convert.ToDouble(adatok[1]), adatok[2], DateTime.Parse(adatok[3], CultureInfo.InvariantCulture));
                    }
                    else if (adatok[0] == "Bevétel" && aktSzamla != null)
                    {
                        aktSzamla.AddBevetel(Convert.ToDouble(adatok[1]), adatok[2], DateTime.Parse(adatok[3], CultureInfo.InvariantCulture));
                    }
                }
                reader.Close();
            }
        }
    }
}
