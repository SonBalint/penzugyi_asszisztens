using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penzugyi_asszisztens
{
    class Program
    {
        static void Main(string[] args)
        {
            KoltsegKezelo kezelo = new KoltsegKezelo();
            bool fut = true;
            while (fut)
            {
                Console.WriteLine("1. Számla hozzáadása");
                Console.WriteLine("2. Kiadás hozzáadása");
                Console.WriteLine("3. Bevétel hozzáadása");
                Console.WriteLine("4. Számla egyenlegének megjelenítése");
                Console.WriteLine("5. Kiadás eltávolítása");
                Console.WriteLine("6. Bevétel eltávolítása");
                Console.WriteLine("7. Számla eltávolítása");
                Console.WriteLine("8. Tranzakciók listázása");
                Console.WriteLine("9. Kilépés");
                Console.Write("Válassz egy opciót: ");
                int valasztas = Convert.ToInt32(Console.ReadLine());

                switch (valasztas)
                {
                    case 1:
                        Console.Write("Add meg a számla nevét: ");
                        string szamlaNev = Console.ReadLine();
                        Console.Write("Add meg a kezdő egyenleget: ");
                        double kezdoEgyenleg = Convert.ToDouble(Console.ReadLine());
                        kezelo.SzamlaHozzaadas(szamlaNev, kezdoEgyenleg);
                        break;
                    case 2:
                        Console.Write("Add meg a számla nevét: ");
                        szamlaNev = Console.ReadLine();
                        Szamla szamla = kezelo.GetSzamla(szamlaNev);
                        if (szamla != null)
                        {
                            Console.Write("Add meg az összeget: ");
                            double osszeg = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Add meg a leírást: ");
                            string leiras = Console.ReadLine();
                            szamla.AddKiadas(osszeg, leiras, DateTime.Now);
                        }
                        else
                        {
                            Console.WriteLine("A megadott számla nem létezik.");
                        }
                        break;
                    case 3:
                        Console.Write("Add meg a számla nevét: ");
                        szamlaNev = Console.ReadLine();
                        szamla = kezelo.GetSzamla(szamlaNev);
                        if (szamla != null)
                        {
                            Console.Write("Add meg az összeget: ");
                            double osszeg = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Add meg a leírást: ");
                            string leiras = Console.ReadLine();
                            szamla.AddBevetel(osszeg, leiras, DateTime.Now);
                        }
                        else
                        {
                            Console.WriteLine("A megadott számla nem létezik.");
                        }
                        break;
                    case 4:
                        Console.Write("Add meg a számla nevét: ");
                        szamlaNev = Console.ReadLine();
                        szamla = kezelo.GetSzamla(szamlaNev);
                        if (szamla != null)
                        {
                            Console.WriteLine($"A(z) {szamlaNev} számla egyenlege: {szamla.CalculateBalance()}");
                        }
                        else
                        {
                            Console.WriteLine("A megadott számla nem létezik.");
                        }
                        break;
                    case 5:
                        Console.Write("Add meg a számla nevét, ahol a kiadást eltávolítani kívánod: ");
                        string szamlaNevKiadasEltav = Console.ReadLine();
                        Szamla szamlaKiadasEltav = kezelo.GetSzamla(szamlaNevKiadasEltav);
                        if (szamlaKiadasEltav != null)
                        {
                            Console.Write("Add meg a kiadás sorszámát: ");
                            int kiadasIndex = Convert.ToInt32(Console.ReadLine()) - 1;  // Az indexelés 0-tól kezdődik
                            if (szamlaKiadasEltav.RemoveKiadas(kiadasIndex))
                            {
                                Console.WriteLine("A kiadás sikeresen eltávolítva.");
                            }
                            else
                            {
                                Console.WriteLine("Érvénytelen kiadás sorszám.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("A megadott számla nem létezik.");
                        }
                        break;                        
                    case 6:
                        Console.Write("Add meg a számla nevét, ahol a bevételt eltávolítani kívánod: ");
                        string szamlaNevBevetelEltav = Console.ReadLine();
                        Szamla szamlaBevetelEltav = kezelo.GetSzamla(szamlaNevBevetelEltav);
                        if (szamlaBevetelEltav != null)
                        {
                            Console.Write("Add meg a bevétel sorszámát: ");
                            int bevetelIndex = Convert.ToInt32(Console.ReadLine()) - 1;  // Az indexelés 0-tól kezdődik
                            if (szamlaBevetelEltav.RemoveBevetel(bevetelIndex))
                            {
                                Console.WriteLine("A bevétel sikeresen eltávolítva.");
                            }
                            else
                            {
                                Console.WriteLine("Érvénytelen bevétel sorszám.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("A megadott számla nem létezik.");
                        }
                        break;                        
                    case 7:
                        Console.Write("Add meg az eltávolítandó számla nevét: ");
                        szamlaNev = Console.ReadLine();
                        kezelo.SzamlaEltavolitas(szamlaNev);
                        break;
                    case 8:
                        Console.Write("Add meg a számla nevét: ");
                        szamlaNev = Console.ReadLine();
                        szamla = kezelo.GetSzamla(szamlaNev);
                        if (szamla != null)
                        {
                            szamla.ListazTranzakciok();
                        }
                        else
                        {
                            Console.WriteLine("A megadott számla nem létezik.");
                        }
                        break;
                    case 9:
                        fut = false;
                        break;
                }
            }
        }
    }
}
