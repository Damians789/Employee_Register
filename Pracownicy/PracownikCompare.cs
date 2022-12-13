using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public class PracownikCompare : IComparer<Pracownik>
    #region IComparer<Pracownik> Members
    {
        public int Compare(Pracownik p1, Pracownik p2)
        {
            int wynik = 1;
            if (p1 != null && p2 != null)
            {
                if (!p2.Doswiadczenie.Equals(p1.Doswiadczenie))
                    return p2.Doswiadczenie.CompareTo(p1.Doswiadczenie);
                else if (!p1.Wiek.Equals(p2.Wiek))
                    return p1.Wiek.CompareTo(p2.Wiek);
                else
                    return p1.Nazwisko.CompareTo(p2.Nazwisko);
            }
            else
                wynik = 0;
            return wynik;
        }
        #endregion
    }
}
