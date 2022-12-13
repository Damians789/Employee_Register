using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public sealed class Rejestr
    {
        private Dictionary<int, Pracownik> ListaPracownikow = new Dictionary<int, Pracownik>();
        private static readonly Lazy<Rejestr> lazy = new Lazy<Rejestr>(() => new Rejestr());

        public void Dodaj(Pracownik p)
        {
            ListaPracownikow.Add(p.ID, p);
        }
        public void Usun(int id)
        {
            ListaPracownikow.Remove(id);
        }
        public void Dodaj(List<Pracownik> listap)
        {
            foreach (Pracownik p in listap)
                ListaPracownikow.Add(p.ID, p);
        }
        public string PoMiescie(string miasto)
        {
            string res = "";
            foreach (Pracownik p in ListaPracownikow.Values)
                if (p.Adres.Miasto == miasto)
                    res += p.Imie + " " + p.Nazwisko + "\n";
            return res;
        }
        
        public string Wyswietl()
        {
            string res = "";
            foreach (Pracownik p in ListaPracownikow.Values)
                res += p.ID + " " + p.Imie + " " + p.Nazwisko + "\n";
            return res;
        }

        public string ZWartoscia()
        {
            string res = "";
            foreach (Pracownik p in ListaPracownikow.Values)
                res += p.Imie + " " + p.Nazwisko + " " + p.Wartosc() + "\n";
            return res;
        }

        public string Posortowane(IComparer<Pracownik> comp)
        {
            string res = "";
            List <Pracownik> temp = new List<Pracownik>(ListaPracownikow.Values);
            temp.Sort(comp);
            foreach (Pracownik p in temp)
                res += p.Imie + " " + p.Nazwisko + " " + p.Doswiadczenie + " " + p.Wiek + "\n";
            return res;
        }

        public void Wyczysc()
        {
            ListaPracownikow = new Dictionary<int, Pracownik>();
        }

        private Rejestr() { }
        public static Rejestr Instance { get { return lazy.Value; } }

        public static void Main()
        {
        }
    }
}
