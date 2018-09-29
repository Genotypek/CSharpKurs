using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (; ;)
            {
                Greeting();
                Age();
                Settings();
            }
        }

        /// <summary>
        /// Sprawdzamy minimalne i maksymalne wartości typów liczbowych.
        /// </summary>
        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("Max int = " + maxInt);
            Console.WriteLine("Min int = " + minInt);
            Console.WriteLine("Max long = " + maxLong);
            Console.WriteLine("Min long = " + minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Wypisujemy komunikat zależny od wieku.
        /// </summary>
        private static void Age()
        {
            Console.Write("Wpisz ile masz lat: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (result == false)
            {
                Console.WriteLine("Podałeś niepoprawny wiek!");
            }
            else if (age < 18)
            {
                Console.WriteLine("Możemy Ci zaoferować mleko.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bravo. Jesteś pełnoletni, możesz wypić Browara.");
            }
        }

        /// <summary>
        /// Wypisujemy powitanie użytkownika.
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name + "!");
        }
    }
}
