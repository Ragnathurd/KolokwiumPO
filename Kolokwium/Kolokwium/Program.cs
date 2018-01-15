using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium {
    class Program {
        static void Main(string[] args)
        {
            Druzyna druzyna1;
            druzyna1 = new Druzyna("Druzyna 1");

            string napis, imie, nazwisko;
            int numerNaKoszulce;

            Console.WriteLine("Co chcesz zrobić?\nLista komend:\nA - ustaw atak.\nB - ustaw obronę.\nC - ustaw nazwę.\nD - wyswietl zawodników.\nE - zakończ program.");

            do {
                napis = Console.ReadLine();
                napis = napis.ToUpper();

                if (napis == "A") {
                    Console.WriteLine("Ustawianie ataku. Podaj imię zawodnika:");
                    imie = Console.ReadLine();

                    Console.WriteLine("Podaj nazwisko zawodnika:");
                    nazwisko = Console.ReadLine();

                    Console.WriteLine("Podaj numer na koszulce zawodnika:");
                    numerNaKoszulce = Convert.ToInt32(Console.ReadLine());

                    druzyna1.UstawAtak(imie, nazwisko, numerNaKoszulce);

                    Console.WriteLine("Zawodnik w ataku dodany. Podaj komendę:");

                }

                if (napis == "B") {
                    Console.WriteLine("Dodawanie obrony. Podaj imie zawodnika:");
                    imie = Console.ReadLine();

                    Console.WriteLine("Podaj nazwisko zawodnika:");
                    nazwisko = Console.ReadLine();

                    Console.WriteLine("Podaj numer na koszulce zawodnika:");
                    numerNaKoszulce = Convert.ToInt32(Console.ReadLine());

                    druzyna1.UstawObrone(imie, nazwisko, numerNaKoszulce);

                    Console.WriteLine("Zawodnik w obronie dodany. Podaj komendę:");

                }

                if (napis == "C") {

                }

                if (napis == "D") {
                    Console.WriteLine(druzyna1.WypiszWszystko());
                    Console.WriteLine("Podaj nową komendę:");
                }


            } while (napis != "E");


        }

    }
}
