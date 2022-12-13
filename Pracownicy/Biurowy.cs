using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public class Biurowy : Pracownik
    {
        private static int LiczbaStanowisk = 0;
        public int NumerStanowiska;
        private int iq;
        public int Intelekt
        {
            get
            {
                return this.iq;
            }
            set
            {
                if (value < 70)
                    throw new ArgumentOutOfRangeException(nameof(Intelekt), "Intelekt poniżej dopuszczalnego poziomu");
                else if (value > 150)
                    throw new ArgumentOutOfRangeException(nameof(Intelekt), "Intelekt powyżej dopuszczalnego poziomu");
                else
                    this.iq = value;
            }
        }
        public Biurowy() { }
        public Biurowy(string Imie, string Nazwisko, int Wiek, int Exp, Adres ad, int iq)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Wiek = Wiek;
            this.Doswiadczenie = Exp;
            this.Adres = ad;
            this.Intelekt = iq;
            this.NumerStanowiska = WygenerujStanowisko();
        }

        public override int Wartosc()
        {
            return this.Doswiadczenie * this.Intelekt;
        }
        private int WygenerujStanowisko()
        {
            Interlocked.Increment(ref LiczbaStanowisk);
            return NumerStanowiska;
        }
    }

}
