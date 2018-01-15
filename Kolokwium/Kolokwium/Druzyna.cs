using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium {
    class Druzyna
    {
        private string nazwa;
        private List<Siatkarz> siatkarze;
        //private Druzyna nazwa;


        public Druzyna(string nazwa) 
        {
            this.nazwa = nazwa;
            siatkarze = new List<Siatkarz>();
        }


        public void UstawAtak(string imie, string nazwisko, int numerNaKoszulce)
        {
            siatkarze.Add(new Atak(imie, nazwisko, numerNaKoszulce));
        }

        public void UstawObrone(string imie, string nazwisko, int numerNaKoszulce)
        {
           siatkarze.Add(new Obrona(imie, nazwisko, numerNaKoszulce));
        }


        public string WypiszWszystko() {
            string wszystko = nazwa.ToUpper() + Environment.NewLine;
            foreach (var Siatkarz in siatkarze) {
                wszystko += Siatkarz.ToString() + Environment.NewLine;
            }
            return wszystko;
        }

    }
}
