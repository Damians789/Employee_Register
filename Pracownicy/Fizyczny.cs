using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public class Fizyczny : Pracownik
    {
        private int _sila;
        public int Sila { 
            get { 
                return this._sila;
            } 
            set {
                if (value < 1)
                    throw new ArgumentOutOfRangeException(nameof(Sila), "Siła poniżej dopuszczalnego poziomu");
                else if (value > 100)
                    throw new ArgumentOutOfRangeException(nameof(Sila), "Intelekt powyżej dopuszczalnego poziomu");
                else
                    this._sila = value;
            } 
        }
        public Fizyczny() { }
        public Fizyczny(string Imie, string Nazwisko, int Wiek, int Exp, Adres ad, int sila)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Wiek = Wiek;
            this.Doswiadczenie = Exp;
            this.Adres = ad;
            this.Sila = sila;
        }

        public override int Wartosc()
        {
            return this.Doswiadczenie * this.Sila / this.Wiek;
        }
    }
}
