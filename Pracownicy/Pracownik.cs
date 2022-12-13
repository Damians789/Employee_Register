using System.Threading;


namespace Pracownicy
{
    public abstract class Pracownik
    {
        private static int LiczbaPracownikow = 0;
        public int ID { get; set;}
        private string _imie;
        public string Imie {
            get
            {
                return this._imie;
            }
            set
            {
                if (!check2(value))
                {
                    throw new Exception("To nie jest poprawne imie");
                }
                this._imie = value;
            }
        }
        private string _nazwisko;
        public string Nazwisko {
            get
            {
                return this._nazwisko;
            }
            set
            {
                if (!check2(value))
                {
                    throw new Exception("To nie jest poprawne nazwisko");
                }
                this._nazwisko = value;
            }
        }
        private int _wiek;
        public int Wiek {
            get { 
                return this._wiek;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Nieprawidłowy wiek");
                }
                this._wiek = value;
            }
        }
        private int exp;
        public int Doswiadczenie {
            get { 
                return this.exp; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Doświadczenie nie może być poniżej 0");
                }
                this.exp = value;
            }
        }
        public Adres Adres { get; set; } = new Adres();
        public Pracownik() {
            ID = Interlocked.Increment(ref LiczbaPracownikow);
        }
        public abstract int Wartosc();
        private bool check1(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
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