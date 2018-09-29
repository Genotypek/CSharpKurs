using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            Osoba osoba2 = new Osoba(1, "Marcin");
            Osoba osoba3 = new Osoba(2, "Matesz", "Styś");
            Osoba osoba4 = new Osoba(3, "Mariola", "Szechyńska", "Ul. Podgórska 25/52, Rzeszów", 20, "Kobieta");

            osoba.WypiszDane();
            osoba2.WypiszDane();
            osoba3.WypiszDane();
            osoba4.WypiszDane();
        }
    }
}
