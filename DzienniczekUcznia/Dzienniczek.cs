using System;
using System.Collections.Generic;
using System.Linq;

namespace DzienniczekUcznia
{
    class Dzienniczek
    {
        //Stan (zmienne - POLA)
        List<float> oceny;

        //Zachowania
        /// <summary>
        /// Dodawanie nowych ocen do dzienniczna
        /// </summary>
        /// <param name="ocena"></param>
        public void DodajOcene(float ocena)
        {
            oceny.Add(ocena);
        }

        /// <summary>
        /// Obliczanie średniej wszystkich ocen w dzienniczku
        /// </summary>
        /// <returns></returns>
        public float ObliczanieSredniej()
        {
            //float sum = 0, avg = 0;

            //foreach (var ocena in oceny)
            //{
            //    sum += ocena;
            //}

            //avg = sum / oceny.Count();

            return oceny.Average();
        }

        /// <summary>
        /// Zwracanie najwyższej oceny z dzienniczka
        /// </summary>
        /// <returns></returns>
        public float NajwyzszaOcena()
        {
            return oceny.Max();
        }

        /// <summary>
        /// Zaracanie najniższej oceny z dzienniczka
        /// </summary>
        /// <returns></returns>
        public float NajnizszaOcena()
        {
            return oceny.Min();
        }
    }
}
