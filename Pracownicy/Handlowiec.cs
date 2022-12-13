using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public enum Skutecznosc
    {
        NISKA = 60,
        ŚREDNIA = 90,
        WYSOKA = 120,
    }
    public class Handlowiec : Pracownik
    {
        private double _prowizja;
        public double Prowizja
        {
            get
            {
                return _prowizja;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Prowizja), "Prowizja nie może być ujemna");
                }
                this._prowizja = value;
            }
        }
        public Skutecznosc Skutecznosc { get; set; }
        public Handlowiec() { }
        public Handlowiec(string Imie, string Nazwisko, int Wiek, int Exp, Adres ad, double Prowizja, Skutecznosc sk)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Wiek = Wiek;
            this.Doswiadczenie = Exp;
            this.Adres = ad;
            this.Prowizja = Prowizja;
            this.Skutecznosc = sk;
        }

        public override int Wartosc()
        {
            return this.Doswiadczenie * (int)this.Skutecznosc;
        }
    }
}
