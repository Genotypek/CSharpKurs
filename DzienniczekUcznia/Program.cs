using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzienniczekUcznia
{
    class Program
    {
        static void Main(string[] args)
        {
            Dzienniczek dzienniczek = new Dzienniczek();
            DodawanieOcen(dzienniczek);
            StatystykiOcen(dzienniczek);
        }

        /// <summary>
        /// Wypisywanie średniej ocen, najwyższej i najniższej oceny
        /// </summary>
        /// <param name="dzienniczek"></param>
        private static void StatystykiOcen(Dzienniczek dzienniczek)
        {
            if (dzienniczek.LiczbaOcen() > 0)
            {
                Console.WriteLine("Średnia ocen w dzienniczku to: " + dzienniczek.ObliczanieSredniej());
                Console.WriteLine("Najwyższa ocena w dzienniczku: " + dzienniczek.NajwyzszaOcena());
                Console.WriteLine("Najniższa ocena w dzienniczku: " + dzienniczek.NajnizszaOcena());
            }
            else
            {
                Console.WriteLine("Nie wprowadziłeś żadnych ocen!");
            }
        }

        /// <summary>
        /// Dodawanie ocen do wybranego dzienniczka
        /// </summary>
        /// <param name="dzienniczek"></param>
        private static void DodawanieOcen(Dzienniczek dzienniczek)
        {
            for (; ; )
            {
                Console.Write("Oceny w dzienniczku: ");
                dzienniczek.WypiszOceny();
                Console.Write("Podaj ocenę z zakresu 1-10: ");
                float ocena;
                bool result = float.TryParse(Console.ReadLine(), out ocena);

                Console.Clear();
                if (result)
                {
                    if (ocena < 1 || ocena > 10)
                    {
                        break;
                    }

                    dzienniczek.DodajOcene(ocena);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("To nie jest ocena!");
                }
            }
        }
    }
}