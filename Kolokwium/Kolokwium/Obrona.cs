using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium {
    class Obrona:Siatkarz
    {
        public Obrona() { }

        public Obrona(string imie, string nazwisko, int numerNaKoszulce) : base(imie, nazwisko, numerNaKoszulce) { }

        public override string ToString() {
            if (numerNaKoszulce % 2 != 0) return "Obrona: " + imie + " " + nazwisko + " " + numerNaKoszulce;
            else return "Błędny numer";
        }
    }
}
