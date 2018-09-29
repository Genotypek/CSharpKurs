using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory
{
    class Osoba
    {
        int id;
        string imie;
        string nazwisko;
        string adres;
        int wiek;
        string plec;

        public Osoba()
        {
            id = 1;
            imie = "Marcin";
            nazwisko = "Kowal";
            wiek = 14;
        }

        public Osoba(int id, string imie, string nazwisko, string adres, int wiek, string plec)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.adres = adres;
            this.wiek = wiek;
            this.plec = plec;
        }

        public Osoba(int id, string imie, string nazwisko)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public Osoba(int id, string imie)
        {
            this.id = id;
            this.imie = imie;
        }

        public void WypiszDane()
        {
            Console.WriteLine(id + " " + imie + " " + nazwisko + " " + adres + " " + wiek + " " + plec);
        }
    }
}
