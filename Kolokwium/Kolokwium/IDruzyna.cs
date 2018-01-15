using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium {
    interface IDruzyna
    {
        void UstawAtak(string imie, string nazwisko, int numerNaKoszulce);

        void UstawObrone(string imie, string nazwisko, int numerNaKoszulce);

        //void UstawNazwe(string nazwa);

        //bool CzyOK();
    }
}
