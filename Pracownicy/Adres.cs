using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public class Adres
    {
        private string ul;
        public string Ulica
        {
            get
            {
                return this.ul;
            }
            set
            {
                if (!check2(value))
                {
                    throw new Exception("To nie jest poprawna nazwa ulicy");
                }
                this.ul = value;
            }
        }
        private int nrb;
        public int NumerBudynku
        {
            get { 
                return this.nrb;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Nieprawidłowy numer budynku");
                }
                this.nrb = value;
            }
        }
        private int nrl;
        public int NumerLokalu
        {
            get { 
                return this.nrl;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Nieprawidłowy numer lokalu");
                }
                this.nrl = value;
            }
        }
        private string m;
        public string Miasto
        {
            get
            {
                return this.m;
            }
            set
            {
                if (!check2(value))
                {
                    throw new Exception("To nie jest poprawna nazwa miasta");
                }
                this.m = value;
            }
        }

        public Adres(string U, int NrB, int NrL, string M)
        {
            if (!check2(U) || !check2(M) || NrB < 1 || NrL < 1)
            {
                throw new Exception("Wprowadzono nieprawidłowy adres");
            }
            this.Ulica = U;
            this.NumerBudynku = NrB;
            this.NumerLokalu = NrL;
            this.Miasto = M;
        }

        public Adres()
        {

        }
        public override string ToString()
        {
            return "Adres: " + this.Ulica + " " + this.NumerBudynku + " " + this.NumerLokalu + " " + this.Miasto + "\n";
        }

        private bool check1(string value)
        {
            foreach (char c in value)
            {

                if (!char.IsLetter(c))
                    if (c.Equals(" "))
                        continue;
                    else
                        return false;
            }

            return true;
        }
        private bool check2(object value)
        {
            string str = value as string;
            return str != null && check1(str);
        }
    }
}
