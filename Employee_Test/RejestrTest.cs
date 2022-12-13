using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pracownicy;
using NUnit.Framework;

namespace PracownicyTest
{
    [TestFixture]
    internal class RejestrTest
    {
        private Rejestr _sut;
        private Adres ad;
        private Biurowy b;
        private Fizyczny f;
        private Handlowiec h;

        [SetUp]
        public void Setup()
        {
            ad = new Adres("Zakrzewski", 5, 7, "Krajenka");
            _sut = Rejestr.Instance;
        }
        [Test]
        public void CheckIfTestWorks()
        {
            Assert.Pass();
        }
        [Test]
        public void CheckIfCreate()
        {
            Assert.That(_sut, Is.Not.Null);
        }
        [Test]
        public void CheckIfCreate2()
        {
            Rejestr temp = Rejestr.Instance;
            Assert.That(_sut, Is.EqualTo(temp));
        }
        [Test]
        public void DowolnyTyp()
        {
            _sut.Wyczysc();
            b = new Biurowy("Marian", "Dolny", 37, 12, ad, 110);
            _sut.Dodaj(b);
            f = new Fizyczny("Marian", "Górny", 37, 12, ad, 69);
            _sut.Dodaj(f);
            h = new Handlowiec("Marian", "Środkowy", 37, 12, ad, 6.25, Skutecznosc.ŚREDNIA);
            _sut.Dodaj(h);
            Assert.That(_sut.Wyswietl, Is.EqualTo(b.ID + " Marian Dolny\n" + f.ID + " Marian Górny\n" + h.ID + " Marian Środkowy\n"));
        }
        [Test]
        public void DowolnyTypNaRaz()
        {
            _sut.Wyczysc();
            b = new Biurowy("Marian", "Dolny", 37, 12, ad, 110);
            f = new Fizyczny("Marian", "Górny", 37, 12, ad, 69);
            h = new Handlowiec("Marian", "Środkowy", 37, 12, ad, 6.25, Skutecznosc.ŚREDNIA);
            List<Pracownik> p = new List<Pracownik>();
            p.Add(b);
            p.Add(f);
            p.Add(h);
            _sut.Dodaj(p);
            Assert.That(_sut.Wyswietl, Is.EqualTo(b.ID + " Marian Dolny\n" + f.ID + " Marian Górny\n" + h.ID + " Marian Środkowy\n"));
        }
        [Test]
        public void CheckIfCanRemove()
        {
            _sut.Wyczysc();
            b = new Biurowy("Marian", "Dolny", 37, 12, ad, 110);
            f = new Fizyczny("Marian", "Dolny", 37, 12, ad, 69);
            List<Pracownik> p = new List<Pracownik>();
            p.Add(b);
            p.Add(f);
            _sut.Dodaj(p);
            _sut.Usun(f.ID);
            Assert.That(_sut.Wyswietl, Is.EqualTo(b.ID +  " Marian Dolny\n"));
        }
        [Test]
        public void CheckIfSortedCorrectly()
        {
            _sut.Wyczysc();
            b = new Biurowy("Marian", "Dolny", 38, 12, ad, 110);
            f = new Fizyczny("Marian", "Górny", 37, 11, ad, 69);
            h = new Handlowiec("Marian", "Środkowy", 36, 13, ad, 6.25, Skutecznosc.ŚREDNIA);
            List<Pracownik> p = new List<Pracownik>();
            p.Add(b);
            p.Add(f);
            p.Add(h);
            b = new Biurowy("Marian", "Młodszy", 35, 12, ad, 110);
            f = new Fizyczny("Marian", "Babinski", 35, 12, ad, 69);
            p.Add(b);
            p.Add(f);
            _sut.Dodaj(p);
            Assert.That(_sut.Posortowane(new PracownikCompare()), Is.EqualTo("Marian Środkowy 13 36\n" + "Marian Babinski 12 35\n" + "Marian Młodszy 12 35\n" + "Marian Dolny 12 38\n" + "Marian Górny 11 37\n"));
        }
        [Test]
        public void CheckIfSortedByCity()
        {
            _sut.Wyczysc();
            b = new Biurowy("Marian", "Dolny", 38, 12, ad, 110);
            f = new Fizyczny("Marian", "Górny", 37, 11, ad, 69);
            Adres a1 = new Adres("Lakowa", 3, 12, "Chlebowa");
            h = new Handlowiec("Marian", "Środkowy", 36, 13, a1, 6.25, Skutecznosc.ŚREDNIA);
            
            List<Pracownik> p = new List<Pracownik>();
            p.Add(b);
            p.Add(f);
            p.Add(h);
            _sut.Dodaj(p);
            Assert.That(_sut.PoMiescie("Chlebowa"), Is.EqualTo("Marian Środkowy\n"));
        }
        [Test]
        public void CheckIfPrintsWithValues()
        {
            _sut.Wyczysc();
            b = new Biurowy("Marian", "Dolny", 38, 12, ad, 110);
            f = new Fizyczny("Marian", "Górny", 37, 11, ad, 69);
            h = new Handlowiec("Marian", "Środkowy", 36, 13, ad, 6.25, Skutecznosc.ŚREDNIA);

            List<Pracownik> p = new List<Pracownik>();
            p.Add(b);
            p.Add(f);
            p.Add(h);
            _sut.Dodaj(p);
            string res = _sut.PoMiescie("Chlebowa");
            Assert.That(_sut.ZWartoscia(), Is.EqualTo("Marian Dolny " + b.Wartosc() + "\nMarian Górny " + f.Wartosc() + "\nMarian Środkowy " + h.Wartosc() + "\n"));
        }
    }
}
