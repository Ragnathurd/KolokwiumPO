using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium {
    class Siatkarz {

        protected string imie { get; set; }
        protected string nazwisko { get; set; }
        protected int numerNaKoszulce { get; set; }

        public Siatkarz() { }

        public Siatkarz(string imie, string nazwisko, int numerNaKoszulce)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerNaKoszulce = numerNaKoszulce;
        }

    }
}
